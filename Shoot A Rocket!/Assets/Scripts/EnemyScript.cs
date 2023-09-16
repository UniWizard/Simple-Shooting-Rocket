using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "EasyMovementPlayer(Clone)")
        {
            StaticClass.start = false;
            Time.timeScale = 0f;

            StaticClass.paus = false;

            SceneManager.LoadSceneAsync("GameOverScene", LoadSceneMode.Additive);
        }
        if (other.gameObject.name == "HardMovementPlayer(Clone)")
        {
            StaticClass.lifes -= 1;

            if (StaticClass.lifes == 0)
            {
                StaticClass.imageEnabled = false;

                Destroy(gameObject);
                Destroy(PlayerBehaviour.life1_clone);

                Time.timeScale = 0f;

                SceneManager.LoadSceneAsync("GameOverScene", LoadSceneMode.Additive);
            }
            else
            {
                if (StaticClass.lifes == 2)
                {
                    Destroy(gameObject);
                    Destroy(PlayerBehaviour.life3_clone);

                    SceneManager.LoadScene("Game");
                }
                if (StaticClass.lifes == 1)
                {
                    Destroy(gameObject);
                    Destroy(PlayerBehaviour.life2_clone);

                    SceneManager.LoadScene("Game");
                }
            }
        }
        if (other.gameObject.name == "Collider")
        {
            Destroy(gameObject);
        }
    }
}