using System;
using System.IO;

public static class BinaryExtensions
{
    public static void Write(this BinaryWriter writer, int[] array)
    {
        writer.Write(array.Length);
        for (int i = 0; i < array.Length; i++)
            writer.Write(array[i]);
    }
    public static int[] ReadIntArray(this BinaryReader reader)
    {
        int[] array = new int[reader.ReadInt32()];
        for (int i = 0; i < array.Length; i++)
            array[i] = reader.ReadInt32();
        return array;
    }
}
