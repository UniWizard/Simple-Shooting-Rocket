using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float i = 0;
    public float j = 0;
    public GameObject original;
    public static GameObject clone1;
    public static GameObject clone2;
    public static GameObject clone3;
    public static GameObject clone4;
    public static GameObject clone5;
    public static GameObject clone6;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (Time.timeSinceLevelLoad > i && !StaticClass.isHardmode)
        {
            i += 4;

            clone1 = Instantiate(original, new Vector2(-3.35f, 3.2f), transform.rotation);
            clone2 = Instantiate(original, new Vector2(-1.95f, 3.2f), transform.rotation);
            clone3 = Instantiate(original, new Vector2(-0.55f, 3.2f), transform.rotation);

            clone4 = Instantiate(original, new Vector2(0.85f, 3.2f), transform.rotation);
            clone5 = Instantiate(original, new Vector2(2.25f, 3.2f), transform.rotation);
            clone6 = Instantiate(original, new Vector2(3.65f, 3.2f), transform.rotation);

        }
        if(Time.timeSinceLevelLoad > j && StaticClass.isHardmode)
        {
            j += 6.9f;

            clone1 = Instantiate(original, new Vector2(-3.35f, 3.2f), transform.rotation);
            clone2 = Instantiate(original, new Vector2(-1.95f, 3.2f), transform.rotation);
            clone3 = Instantiate(original, new Vector2(-0.55f, 3.2f), transform.rotation);

            clone4 = Instantiate(original, new Vector2(0.85f, 3.2f), transform.rotation);
            clone5 = Instantiate(original, new Vector2(2.25f, 3.2f), transform.rotation);
            clone6 = Instantiate(original, new Vector2(3.65f, 3.2f), transform.rotation);

        }    
    }
}
