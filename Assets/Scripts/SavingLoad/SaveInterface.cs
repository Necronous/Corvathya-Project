using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveInterface
{
    public readonly string SaveDirectory;

    private SaveFile[] _allSaves;
    private SaveFile _activeSave;

    public SaveFile[] AllSaves => _allSaves;
    public SaveFile ActiveSave => _activeSave;

    public SaveInterface()
    {
        SaveDirectory = Path.Combine(Application.persistentDataPath, "Saves");
        Debug.Log("save directory: " + SaveDirectory);
        if(!Directory.Exists(SaveDirectory))
            Directory.CreateDirectory(SaveDirectory);
        LoadAllSaves();
    }

    public void SetActiveSave(SaveFile save)
    { 
        _activeSave = save; 
    }

    public SaveFile CreateNewSave()
    {
        string filename = GenerateSaveFileID();
        SaveFile save = new SaveFile(filename);
        _activeSave = save;
        Save();
        return _activeSave;
    }

    public bool Save()
    {
        if (_activeSave == null)
            return false;
        _activeSave.Save();
        return true;
    }

    public bool Load()
    {
        if (_activeSave == null)
            return false;
        _activeSave.Load();
        return true;
    }

    public bool Load(SaveFile file)
    {
        if (_activeSave == null)
            return false;
        _activeSave = file;
        Load();
        return true;
    }

    private string GenerateSaveFileID()
    {
        string name = Path.Combine(SaveDirectory, "save_");
        int id = 0;
        while(File.Exists(name + id + SaveFile.SAVE_EXTENSION))
            id++;
        return name + id + SaveFile.SAVE_EXTENSION;
    }

    private void LoadAllSaves()
    {
        List<SaveFile> savesfiles = new();
        string[] saves = Directory.GetFiles(SaveDirectory);
        foreach (string s in saves)
        {
            if (Path.GetExtension(s) != SaveFile.SAVE_EXTENSION)
                continue;

            SaveFile file = new(s);
            if (file.Fault != SaveFile.SaveFault.NONE)
            {
                //If invalid save, report then add it the list anyway.
                Debug.LogError($"SaveFile Error :: Name: {Path.GetFileName(s)}, Error: {file.Fault}");
            }
            savesfiles.Add(file);
        }

        _allSaves = savesfiles.ToArray();
#if DEBUG
        Debug.Log($"Loaded {_allSaves.Length} valid save files.");
#endif
    }
}
