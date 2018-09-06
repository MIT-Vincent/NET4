using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTransfer : MonoBehaviour {

    public static ProgressTransfer Instance { set; get; }
    public SaveState state;

    private void Awake()
    {
        Instance = this;
        Load();
    }

    public void Save()
    {
        PlayerPrefs.SetString("save", Helper.Serialize<SaveState>(state));
    }

    public void Load()
    {
       if (PlayerPrefs.HasKey("save"))
        {
            state = Helper.Deserialize<SaveState>(PlayerPrefs.GetString("save"));
        }
       else
        {
            state = new SaveState();
            Save();
            
        }
    }
}
