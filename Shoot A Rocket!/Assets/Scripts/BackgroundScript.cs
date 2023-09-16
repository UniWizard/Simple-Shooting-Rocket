using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!StaticClass.imageEnabled)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!StaticClass.imageEnabled)
        {
            gameObject.SetActive(false);
        }
    }
}
