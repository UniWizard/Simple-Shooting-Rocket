using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Text text;
    private void Start()
    {
        text.text = "Highscore: " + PlayerPrefs.GetFloat("highscore") +" Points";
    }
    private void Update()
    {
        text.text = "Highscore: " + PlayerPrefs.GetFloat("highscore") + " Points";
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        StaticClass.start = true;
        SceneManager.LoadScene("Game");
        Bullet.k = 0;
        Time.timeScale = 1f;
    }

    public void Reset()
    {
        Debug.Log("Reset");
        PlayerPrefs.SetFloat("highscore", 0);
        PlayerPrefs.SetFloat("name", 6.00f);
    }
}
