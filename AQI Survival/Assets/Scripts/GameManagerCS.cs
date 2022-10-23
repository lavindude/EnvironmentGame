using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManagerCS : MonoBehaviour
{
    public TextMeshProUGUI AQI_text;
    public TextMeshProUGUI health_text;

    public float AQI;
    public float AQI_increase_per_minute;
    public float health;
    public float damage_constant;
    public float AQI_decrease_on_item_pickup;

    public int keyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        AQI = 200f;
        health = 1000;

        AQI_increase_per_minute = 200;
        damage_constant = 1;

        //text displayed on the screen
        UpdateScreenText(AQI, health);
        AQI_decrease_on_item_pickup = 30;
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
        AQI_text.text = "AQI: " + Math.Round(_AQI);
        health_text.text = "Health: " + Math.Round(_health);
    }

    public void itemPickedUp(){
        keyCount++;

        // AQI -= AQI_decrease_on_item_pickup;
    }
}
