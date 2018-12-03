using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ssave_game : MonoBehaviour {

    private const string SAVE_SEPARATOR = "#SAVE-VALUE#";

    [SerializeField] private GameObject unitGameObject;
    private saveunit unit;

    public GameObject game_saved;
    private int close = 2;
	// Use this for initialization
	void Start () {
        unit = unitGameObject.GetComponent<saveunit>();
    }
    public void savegame()
    {
        game_saved.SetActive(true);
        string scene = unit.Getscene;
        string stage = unit.Getstage_type;
        int right = unit.numr;
        int wrong = unit.numw;
        StartCoroutine("saveclose");
        string[] contents = new string[] {
            ""+scene,
            ""+stage,
            ""+right,
            ""+wrong,
        };
        string saveString = string.Join(SAVE_SEPARATOR, contents);
        File.WriteAllText(Application.dataPath + "/save.txt", saveString);

    }

    public void Update()
    {
        if(close == 0)
        {
            game_saved.SetActive(false);
            close = 2;
        }
    }
    IEnumerator saveclose()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);


            close--;



        }
    }

}
