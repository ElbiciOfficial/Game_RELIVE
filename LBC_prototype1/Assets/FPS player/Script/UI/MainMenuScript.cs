using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public GameObject newgame;
    public Animator loadscreen;
    public Animator title;

    public int count = 3;

    private void Start()
    {
        loadscreen.SetBool("open", true);
        StartCoroutine("startmenu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DontDestroyOnLoad(newgame);
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
            yield return new WaitForSeconds(1);


            count--;



        }
    }
}
