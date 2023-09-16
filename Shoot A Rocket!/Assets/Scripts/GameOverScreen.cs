using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text text;
    public Canvas canvas;
    public void Start()
    {
        canvas.worldCamera = Camera.main;
        text.text = Bullet.k.ToString() + " Points";
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void RestartButton()
    {

        StaticClass.paus = true;

        Bullet.k = 0;

        StaticClass.start = true;

        StaticClass.lifes = 3;

        StaticClass.imageEnabled = true;

        SceneManager.LoadScene("Game");

    }

}
