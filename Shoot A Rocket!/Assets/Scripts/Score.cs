using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text myText;
    public GameObject boss;
    private GameObject boss_clone;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "0 Points";
    }

    // Update is called once per frame
    void Update()
    {
            myText.text = Bullet.k + " Points";

    }

}
