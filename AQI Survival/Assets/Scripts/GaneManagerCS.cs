using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GaneManagerCS : MonoBehaviour
{
    public TextMeshProUGUI AQI_text;
    public TextMeshProUGUI health_text;

    public float AQI;
    public float AQI_increase_per_minute;
    public float health;
    public float damage_constant;

    // Start is called before the first frame update
    void Start()
    {
        AQI = 200f;
        health = 1000;

        AQI_increase_per_minute = 200;
        damage_constant = 1;

        //text displayed on the screen
        UpdateScreenText(AQI, health);
    }

    // Update is called once per frame
    void Update()
    {
        AQI += (AQI_increase_per_minute / 60f) * Time.deltaTime;
        health -= (damage_constant / 60f) * Time.deltaTime * AQI;

        //update text displayed on the screen
        UpdateScreenText(AQI, health);
    }

    private void UpdateScreenText(float _AQI, float _health) 
    {
        AQI_text.text = "AQI: " + _AQI;
        health_text.text = "Health: " + _health;
    }
}
