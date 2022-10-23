using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllCS : MonoBehaviour
{
    public GameManagerCS gameManager;
    public GameObject player;
    private Vector3 myPos;
    public GameObject lock_pad;

    // Start is called before the first frame update
    void Start()
    {
        myPos = transform.position;
    }

    void OnMouseOver(){
        Vector3 pos1 = player.transform.position;
        float scuffed_dist = Mathf.Abs(pos1.x - myPos.x) + Mathf.Abs(pos1.z - myPos.z) + Mathf.Abs(pos1.y - myPos.y);

        Debug.Log(scuffed_dist);

        if(scuffed_dist < 28){
            // transform.Rotate(new Vector3(0, 1, 0));
            // TODO: to actual message:
            Debug.Log("You have " + gameManager.keyCount + "/3 Keys!");

            if(Input.GetKeyDown(KeyCode.E) && gameManager.keyCount == 3){
                Destroy(lock_pad.gameObject);
            }
        }
    }
}
