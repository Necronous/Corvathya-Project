using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
public class SaveFile
{
    public readonly string FilePath;

    public short VersionMajor { get; private set; }
    public short VersionMinor { get; private set; }
    public DateTime DateTime { get; private set; }
    public int MapIndex { get; private set; }

    public SaveFile(string filepath)
    {
        VersionMajor = World.VERSION_MAJOR; 
        VersionMinor = World.VERSION_MINOR;
        DateTime = DateTime.Now;
        MapIndex = 0;
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
            string magic = new string(reader.ReadChars(4));
            if (magic != "SAVE")
            {
                return;
            }
            VersionMajor = reader.ReadInt16();
            VersionMinor = reader.ReadInt16();
            DateTime = new(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32(),
                reader.ReadInt32(), reader.ReadInt32(), 0);
            MapIndex = reader.ReadInt16();
        }
    }

    public void Save()
    {
        byte[] worldData = SerializeDictionary(World.Instance.GetWorldVariables());
        byte[] playerData = SerializeDictionary(World.Player.CreateSavablePlayerData());
        //get player data.

        using (BinaryWriter writer = new(new FileStream(FilePath, FileMode.Create)))
        {
            //Header = 30 bytes.
            //the header of all saves will be loaded on game start to fill in the load game list with info.

            //magic
            writer.Write(new char[] { 'S', 'A', 'V', 'E' });
            //Game version. Major - Minor
            writer.Write(World.VERSION_MAJOR); writer.Write(World.VERSION_MINOR);
            //Date and time
            DateTime time = DateTime.Now;
            writer.Write(time.Year); writer.Write(time.Month); writer.Write(time.Day);
            writer.Write(time.Hour); writer.Write(time.Minute);

            //Write current map name as level index (short)
            writer.Write((short)World.Instance.GetCurrentMapIndex());

            //EndHeader 

            //Write serialized data.
            writer.Write(worldData.Length);
            writer.Write(worldData);
            writer.Write(playerData.Length);
            writer.Write(playerData);
        }

        //refresh header.
        VersionMajor = World.VERSION_MAJOR;
        VersionMinor = World.VERSION_MINOR;
        MapIndex = World.Instance.GetCurrentMapIndex();
        DateTime = DateTime.Now;
    }
    public void Load() 
    {
        using (BinaryReader reader = new(new FileStream(FilePath, FileMode.Open)))
        {
            reader.BaseStream.Position = 30; //Skip header.
            Dictionary<string, object> worldVars = DeserializeDictionary(reader.ReadBytes(reader.ReadInt32()));
            Dictionary<string, object> playerVars = DeserializeDictionary(reader.ReadBytes(reader.ReadInt32()));
            World.Instance.SetWorldVariables(worldVars);
            World.Player.LoadPlayerData(playerVars);
        }
    }

    public static byte[] SerializeDictionary(Dictionary<string, object> dict)
    {
        MemoryStream ms = new();
        using (BinaryWriter writer = new(ms))
        {
            writer.Write(dict.Count);
            foreach (KeyValuePair<string, object> kvp in dict)
            {
                //First we write the key, then we write a byte which indicates value type then we write the value.
                //Maybe implement ISavable interface for other values.
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
            }
        }
        return ms.ToArray();
    }

    public static Dictionary<string, object> DeserializeDictionary(byte[] b)
    {
        MemoryStream ms = new(b);
        ms.Position = 0;
        Dictionary<string, object> dict = new();

        using (BinaryReader reader = new(ms))
        {
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                string key = reader.ReadString();
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
                }
                dict.Add(key, value);
            }
        }
        return dict;
    }
}

