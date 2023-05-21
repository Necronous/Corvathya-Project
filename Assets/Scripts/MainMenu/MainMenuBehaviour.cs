using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBehaviour : MonoBehaviour
{
    
    private void Start()
    {
    }

    #region MainMenu
    public void NewGame_Click() 
    {
        World.Instance.SaveHandler.CreateNewSave();
        World.Instance.SetupGame();
    }
    public void LoadGame_Click() 
    {
        if (World.Instance.SaveHandler.AllSaves.Length > 0)
        {
            World.Instance.SaveHandler.SetActiveSave(World.Instance.SaveHandler.AllSaves[0]);
            World.Instance.SetupGame();
        }
    }
    public void OptionsMenu_Click() 
    {
        Debug.Log("options menu clicked");
    }
    public void Quit_Click() 
    {
        Application.Quit();
    }
    #endregion
}
