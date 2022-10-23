using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCS : MonoBehaviour
{

    public float AQI;
    public float AQI_increase_per_minute;
    public float AQI_decrease_on_item_pickup;

    public int itemCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        AQI = 200f;
        AQI_increase_per_minute = 200;
        AQI_decrease_on_item_pickup = 30;
    }

    // Update is called once per frame
    void Update()
    {
        AQI += (AQI_increase_per_minute / 60f) * Time.deltaTime;

        // Debug.Log(AQI);
    }

    public void itemPickedUp(){
        itemCount++;

        AQI -= AQI_decrease_on_item_pickup;
    }
}
