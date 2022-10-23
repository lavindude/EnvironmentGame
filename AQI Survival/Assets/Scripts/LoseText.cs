using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoseText : MonoBehaviour
{
    private string text = "You died.";
    public TextMeshProUGUI textHold;
    private string[] values = new string[] {"As a result of your failure, countless children suffer from asthma and additional diseases. Big corporations continue to pollute massive amounts, ruining the world more and more.", 
                                            "As a result of your failure, the environment has been thrown out of balance. Countless ecosystems are destroyed from your incompetance.", 
                                            "As a result of your failure, plants and animals have started dying from respiratory diseases caused by continued pollution. Their population dwindles."};
    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(0, values.Length);
        textHold.text = text + " " + values[r];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
