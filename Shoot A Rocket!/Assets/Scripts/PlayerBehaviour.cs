using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    public GameObject EasyPlayer;
    public GameObject HardPlayer;
    public static GameObject easy_player;
    public static GameObject hard_player;
    public GameObject life1, life2, life3;
    public static GameObject life1_clone, life2_clone, life3_clone;
    public Image image;

     void Start()
     {

        Time.timeScale = 0f;

        if (StaticClass.isHardmode == true)
        {
            image.enabled = true;
            Debug.Log("Hard");
            hard_player = Instantiate(HardPlayer, new Vector2(-3.8f, -0.9f), transform.rotation);

            if (StaticClass.lifes == 3)
            {
                life1_clone = Instantiate(life1, new Vector2(-4f, 2.55f), transform.rotation);
                life2_clone = Instantiate(life2, new Vector2(-3.55f, 2.55f), transform.rotation);
                life3_clone = Instantiate(life3, new Vector2(-3.1f, 2.55f), transform.rotation);
            }
            if (StaticClass.lifes == 2)
            {
                life1_clone = Instantiate(life1, new Vector2(-4f, 2.55f), transform.rotation);
                life2_clone = Instantiate(life2, new Vector2(-3.55f, 2.55f), transform.rotation);
            }
            if(StaticClass.lifes == 1)
            {
                life1_clone = Instantiate(life1, new Vector2(-4f, 2.55f), transform.rotation);
            }
            
        }

        else if(StaticClass.isHardmode == false)
        {
            image.enabled = false;
            Debug.Log("Easy");
            easy_player = Instantiate(EasyPlayer, new Vector2(0, -0.9f), transform.rotation);
           
        }
     }
}
