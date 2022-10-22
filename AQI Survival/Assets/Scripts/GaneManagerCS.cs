using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaneManagerCS : MonoBehaviour
{

    public float AQI;
    public float AQI_increase_per_minute;

    // Start is called before the first frame update
    void Start()
    {
        AQI = 200f;
        AQI_increase_per_minute = 200;
    }

    // Update is called once per frame
    void Update()
    {
        AQI += (AQI_increase_per_minute / 60f) * Time.deltaTime;

        Debug.Log(AQI);
    }
}
