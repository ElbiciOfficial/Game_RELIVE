using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_game : MonoBehaviour {

    private const string SAVE_SEPARATOR = "#SAVE-VALUE#";

    [SerializeField] private GameObject unitGameObject;
    private loadunit unit;

    // Use this for initialization
    void Start()
    {
        unit = unitGameObject.GetComponent<loadunit>();
    }
    public void loadgame()
    {
      
        if (File.Exists(Application.dataPath + "/save.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/save.txt");

            string[] contents = saveString.Split(new[] { SAVE_SEPARATOR }, System.StringSplitOptions.None);

            string scene = contents[0];
            string stage = contents[1];

            int right = int.Parse(contents[2]);
            int wrong = int.Parse(contents[3]);

            unit.Setscene(scene);
            unit.Setstage(stage);
            unit.Setright(right);
            unit.Setwrong(wrong);
            if (scene == "chapter1_stage1")
            {
                SceneManager.LoadScene("chapter1_stage1");
                DontDestroyOnLoad(unitGameObject);
            }
            else if (scene == "chapter1_stage2")
            {
                SceneManager.LoadScene("chapter1_stage2");
                DontDestroyOnLoad(unitGameObject);
            }
            else if(scene == "chapter1_stage3")
            {
                SceneManager.LoadScene("chapter1_stage3");
                DontDestroyOnLoad(unitGameObject);
            }
            else if(scene == "chapter2_stage1")
            {
                SceneManager.LoadScene("chapter2_stage1");
                DontDestroyOnLoad(unitGameObject);
            }
            else if(scene == "chapter2_stage3")
            {
                SceneManager.LoadScene("chapter2_stage3");
                DontDestroyOnLoad(unitGameObject);
            }
            else if(scene == "chapter3_stage1")
            {
                SceneManager.LoadScene("chapter3_stage1");
                DontDestroyOnLoad(unitGameObject);
            }
            else if(scene == "chapter3_stage3")
            {
                SceneManager.LoadScene("chapter3_stage3");
                DontDestroyOnLoad(unitGameObject);
            }

        }

    }
}
