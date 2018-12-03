using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public GameObject newgame;
    public Animator loadscreen;
    public Animator title;

    public int count = 3;
    public GameObject Game_data;

    private void Start()
    {
        loadscreen.SetBool("open", true);
        StartCoroutine("startmenu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DontDestroyOnLoad(newgame);
        DontDestroyOnLoad(Game_data);
    }

    public void Continuegame()
    {
        scene_name con = newgame.GetComponent<scene_name>();
        con.Name_s = "continue";

    }

    public void Exit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    void Update()
    {
        if (count == 0)
        {
            title.SetBool("start", true);
            StopCoroutine("startmenu");
        }


    }

    IEnumerator startmenu()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);


            count--;



        }
    }
}
