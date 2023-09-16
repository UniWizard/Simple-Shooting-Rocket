using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
        SceneManager.UnloadSceneAsync("Ending");

        // Static Class Werte zurücksetzen

        StaticClass.start = false;
    }
}
