using UnityEngine;
using UnityEngine.UI;

public class ToggleTest : MonoBehaviour
{
    [SerializeField] private Toggle Easy, Hard;
    private void Awake()
    {
        Debug.Log(StaticClass.toggleStateID);
        switch (StaticClass.toggleStateID)
        {
            case 1:
                Easy.isOn = false;
                break;
            case 2:
                Hard.isOn = false;
                break;
        }  
    }


    public void ChangeToggleState(int id)
    {
        switch (id)
        {
            case 1:
                StaticClass.toggleStateID = id;
                StaticClass.isHardmode = true;
                break;
            case 2:
                StaticClass.toggleStateID = id;
                StaticClass.isHardmode = false;
                break;        
        }
    }
}
