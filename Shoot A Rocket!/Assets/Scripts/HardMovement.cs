using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardMovement : MonoBehaviour
{
    private Vector2 pos1 = new Vector2(-4, -0.9f);
    private Vector2 pos2 = new Vector2(3.6f, -0.9f);
    public Rigidbody2D bullet;
    public Transform player;
    public Rigidbody2D enemy;
    public float cooldownTime = 0.1f;
    public float nextFireTime = 0;
   

    public void Start()
    {
        if(StaticClass.start == true)
        {
            Time.timeScale = 1f;
        }
        player.transform.position = new Vector2(-4, -0.9f);
        enemy.GetComponent<Rigidbody2D>().gravityScale = 0.010f;
    }
    void Update()
    {
        if(Bullet.k > PlayerPrefs.GetFloat("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", Bullet.k);
        }

        if (Input.GetKeyDown("space") && StaticClass.start)
        {

            if (Time.timeSinceLevelLoad > nextFireTime)
            {
                nextFireTime = Time.timeSinceLevelLoad + cooldownTime;
 
                Rigidbody2D bulletInstance;
                bulletInstance = Instantiate(bullet, player.position, player.rotation) as Rigidbody2D; 
                bulletInstance.AddForce(player.up * 1500f);
                Destroy(bulletInstance.gameObject, 0.6f);
               
            }
        }
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * 0.3f, 1f));
    }
}
