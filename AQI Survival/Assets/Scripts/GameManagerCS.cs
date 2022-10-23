using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManagerCS : MonoBehaviour
{
    public TextMeshProUGUI AQI_text;
    public TextMeshProUGUI health_text;
    public TextMeshProUGUI key_count_text;

    public GameObject player;

    public float AQI;
    public float AQI_increase_per_minute;
    public float health;
    public float damage_constant;
    public float AQI_decrease_on_item_pickup;

    public int keyCount = 0;

    // Start is called before the first frame update
    void Start()
    {       
        AQI = 200;
        health = 1000;

        AQI_increase_per_minute = 200;
        damage_constant = 0.7f;

        //text displayed on the screen
        UpdateScreenText();
        AQI_decrease_on_item_pickup = 30;
    }

    // Update is called once per frame
    void Update()
    {
        AQI += (AQI_increase_per_minute / 60f) * Time.deltaTime;
        health -= (damage_constant / 60f) * Time.deltaTime * AQI;

        // makes it harder for player to move once AQI is 400+
        if (AQI > 400)
        {
            player.GetComponent<PlayerControllCS>().walkingSpeed = 6;
            player.GetComponent<PlayerControllCS>().runningSpeed = 6f;
            player.GetComponent<PlayerControllCS>().jumpSpeed = 5;
        }

        else // otherwise back to normal
        {
            player.GetComponent<PlayerControllCS>().walkingSpeed = 7.5f;
            player.GetComponent<PlayerControllCS>().runningSpeed = 11.5f;
            player.GetComponent<PlayerControllCS>().jumpSpeed = 8;
        }
        
        //update text displayed on the screen
        UpdateScreenText();
        if (health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    private void UpdateScreenText() 
    {
        AQI_text.text = "AQI: " + Math.Round(AQI);
        health_text.text = "Health: " + Math.Round(health);
        key_count_text.text = "Keys Collected: " + keyCount + "/3";
    }

    public void itemPickedUp(){
        keyCount++;

        // AQI -= AQI_decrease_on_item_pickup;
    }
}
