using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoadScript : MonoBehaviour {

    public void Load()
    {
        SaveGame.Load();
        transform.position = SaveGame.Instance.PlayerPosition;
    }

    public void Save()
    {
        SaveGame.Instance.PlayerPosition = transform.position;
        SaveGame.Save();
    }

}

