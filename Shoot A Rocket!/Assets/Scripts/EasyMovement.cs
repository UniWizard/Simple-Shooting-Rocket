using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EasyMovement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float horizontal;
    float vertical;
    public Rigidbody2D bullet;
    public Transform player;
    public float sliderValuePlayer;
    public Rigidbody2D enemy;
    public float cooldownTime = 0.1f;
    public float nextFireTime = 0f;


    void Start()
    {
        if (StaticClass.start == true)
        {
            Time.timeScale = 1f;
        }
        enemy.GetComponent<Rigidbody2D>().gravityScale = 0.03f;

        m_Rigidbody = GetComponent<Rigidbody2D>();

        //sliderValuePlayer = StaticClass.sliderValue;
        sliderValuePlayer = PlayerPrefs.GetFloat("name");

        if (sliderValuePlayer == 0)
        {
        sliderValuePlayer = 6f;
        }

    }

    void Update()
    {

        if (Bullet.k > PlayerPrefs.GetFloat("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", Bullet.k);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown("space") && StaticClass.start)
        {

            if (Time.timeSinceLevelLoad > nextFireTime)
            {

                nextFireTime = Time.timeSinceLevelLoad + cooldownTime + 0.4f;

                Rigidbody2D bulletInstance;
                bulletInstance = Instantiate(bullet, player.position, player.rotation) as Rigidbody2D;
                bulletInstance.AddForce(player.up * 1500f);
                Destroy(bulletInstance.gameObject, 0.6f);

            }
        }

    }

    void FixedUpdate()
    {
        m_Rigidbody.velocity = new Vector2(horizontal * sliderValuePlayer, vertical * sliderValuePlayer);
    }
}
