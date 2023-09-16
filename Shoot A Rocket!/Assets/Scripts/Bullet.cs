using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static int k = 0;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Enemy1(Clone)")
        {
            Destroy(other.collider.gameObject);
            Destroy(gameObject);
            k += 1;
            Debug.Log(k);
        }
    }
}
