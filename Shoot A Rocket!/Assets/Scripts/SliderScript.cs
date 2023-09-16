using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{

    [SerializeField] private Slider slider; //This should not be static since the value will be constantly changing
    [SerializeField] private Text sliderText;
    //the value variable isn't really necessary here

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("name", 6f);
        // Player Prefabs into Text
        if(slider.value == 6f)
        {
            sliderText.text = "6,00";
        }
        sliderText.text = slider.value.ToString();
        slider.onValueChanged.AddListener(v => {
            sliderText.text = v.ToString("0.00");
            Debug.Log("V" + v); //you're getting the slider value as a parameter of the function, pass that instead of a second useless value
            StaticClass.sliderValue = v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 6f)
        {
            sliderText.text = "6,00";
        }
        slider.onValueChanged.AddListener(v => {
            sliderText.text = v.ToString("0.00");
            PlayerPrefs.SetFloat("name", v);
            sliderText.text = slider.value.ToString();
            StaticClass.sliderValue = v; //you're getting the slider value as a parameter of the function, pass that instead of a second useless value
        });
        //sliderText.text = "" + PlayerPrefs.GetFloat("name");
        slider.value = PlayerPrefs.GetFloat("name");
    }
}
