using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
public class SaveFile
{
    public enum SaveFault
    {
        NONE,
        INVALID_MAGIC,
        VERSION_MISMATCH,
    }
    public const string SAVE_EXTENSION = ".sve";

    public readonly string FilePath;

    public short VersionMajor { get; private set; }
    public short VersionMinor { get; private set; }
    public DateTime DateTime { get; private set; }
    public int MapIndex { get; private set; }

    public SaveFault Fault { get; private set; }

    public SaveFile(string filepath)
    {
        VersionMajor = WorldVariables.VERSION_MAJOR; 
        VersionMinor = WorldVariables.VERSION_MINOR;
        DateTime = DateTime.Now;
        MapIndex = 0;

        FilePath = filepath;
        if (!filepath.EndsWith(SAVE_EXTENSION))
            filepath += SAVE_EXTENSION;

        if (Exists())
            ReadHeader();

    }
    public bool Exists()
        => File.Exists(FilePath);

    private void ReadHeader()
    {
        //Header is 30 bytes long.
        using (BinaryReader reader = new(new FileStream(FilePath, FileMode.Open)))
        {
            Fault = SaveFault.NONE;

            string magic = new string(reader.ReadChars(4));
            if (magic != "SAVE")
            {
                Fault = SaveFault.INVALID_MAGIC;
                return;
            }
            VersionMajor = reader.ReadInt16();
            VersionMinor = reader.ReadInt16();
            DateTime = new(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32(),
                reader.ReadInt32(), reader.ReadInt32(), 0);

        }
    }

    public void Save()
    {
        byte[] worldData = SerializeDictionary(WorldVariables.Variables);
        

        using (BinaryWriter writer = new(new FileStream(FilePath, FileMode.Create)))
        {
            //Header = 28 bytes.
            writer.Write(new char[] { 'S', 'A', 'V', 'E' });
            writer.Write(WorldVariables.VERSION_MAJOR); writer.Write(WorldVariables.VERSION_MINOR);
            DateTime time = DateTime.Now;
            writer.Write(time.Year); writer.Write(time.Month); writer.Write(time.Day);
            writer.Write(time.Hour); writer.Write(time.Minute);

            //EndHeader 

            //Write serialized data.
            writer.Write(worldData.Length);
            writer.Write(worldData);
        }

        //refresh header.
        VersionMajor = WorldVariables.VERSION_MAJOR;
        VersionMinor = WorldVariables.VERSION_MINOR;
        MapIndex = MapManager.Instance.CurrentMapIndex;
        DateTime = DateTime.Now;
    }
    public void Load() 
    {
        WorldVariables.Reset();
        using (BinaryReader reader = new(new FileStream(FilePath, FileMode.Open)))
        {
            reader.BaseStream.Position = 30; //Skip header.
            Dictionary<int, object> worldVars = DeserializeDictionary(reader.ReadBytes(reader.ReadInt32()));
            WorldVariables.Add(worldVars);
        }
    }

    public static byte[] SerializeDictionary(Dictionary<int, object> dict)
    {
        MemoryStream ms = new();
        using (BinaryWriter writer = new(ms))
        {
            writer.Write(dict.Count);
            foreach (KeyValuePair<int, object> kvp in dict)
            {
                //First we write the key, then we write a byte which indicates value type then we write the value.
                //Add encryption for strings.
                writer.Write(kvp.Key);
                if (kvp.Value is byte by)
                { writer.Write((byte)0); writer.Write(by); }
                else if (kvp.Value is short sh)
                { writer.Write((byte)1); writer.Write(sh); }
                else if (kvp.Value is int i)
                { writer.Write((byte)2); writer.Write(i); }
                else if (kvp.Value is long lo)
                { writer.Write((byte)3); writer.Write(lo); }
                else if (kvp.Value is bool bo)
                { writer.Write((byte)4); writer.Write(bo); }
                else if (kvp.Value is string st)
                { writer.Write((byte)5); writer.Write(st); }
                else if (kvp.Value is UnityEngine.Vector2 v2)
                { writer.Write((byte)6); writer.Write(v2.x); writer.Write(v2.y); }
                else if (kvp.Value is UnityEngine.Vector3 v3)
                { writer.Write((byte)7); writer.Write(v3.x); writer.Write(v3.y); writer.Write(v3.z); }
                else if (kvp.Value is UnityEngine.Vector4 v4)
                { writer.Write((byte)8); writer.Write(v4.x); writer.Write(v4.y); writer.Write(v4.z); writer.Write(v4.w); }
                else if (kvp.Value is float f)
                { writer.Write((byte)9); writer.Write(f); }
                else if (kvp.Value is double dd)
                { writer.Write((byte)10); writer.Write(dd); }
                else if (kvp.Value is int[] ia)
                { writer.Write((byte)11); writer.Write(ia); }

            }
        }
        return ms.ToArray();
    }

    public static Dictionary<int, object> DeserializeDictionary(byte[] b)
    {
        MemoryStream ms = new(b);
        ms.Position = 0;
        Dictionary<int, object> dict = new();

        using (BinaryReader reader = new(ms))
        {
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                int key = reader.ReadInt32();
                byte valuetype = reader.ReadByte();
                object value = 0;
                switch (valuetype)
                {
                    case 0: value = reader.ReadByte(); break;
                    case 1: value = reader.ReadInt16(); break;
                    case 2: value = reader.ReadInt32(); break;
                    case 3: value = reader.ReadInt64(); break;
                    case 4: value = reader.ReadBoolean(); break;
                    case 5: value = reader.ReadString(); break;
                    case 6: value = new UnityEngine.Vector2(reader.ReadSingle(), reader.ReadSingle()); break;
                    case 7: value = new UnityEngine.Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()); break;
                    case 8: value = new UnityEngine.Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()); break;
                    case 9: value = reader.ReadSingle(); break;
                    case 10: value = reader.ReadDouble(); break;
                    case 11: value = reader.ReadIntArray(); break;
                }
                dict.Add(key, value);
            }
        }
        return dict;
    }
}

