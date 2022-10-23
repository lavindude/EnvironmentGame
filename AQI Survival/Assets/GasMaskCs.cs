using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMaskCs : MonoBehaviour
{
    public GameManagerCS gameManager;
    public GameObject player;
    private Vector3 myPos;

    // Start is called before the first frame update
    void Start()
    {
        myPos = transform.position;
    }

    void OnMouseOver(){

        Vector3 pos1 = player.transform.position;
        float scuffed_dist = Mathf.Abs(pos1.x - myPos.x) + Mathf.Abs(pos1.z - myPos.z) + Mathf.Abs(pos1.y - myPos.y);
        
        if(scuffed_dist < 10){
            transform.Rotate(new Vector3(0, 0, 1.5f));

            if(Input.GetKeyDown(KeyCode.E)){
                gameManager.gasMaskPickUp();
                Destroy(gameObject);
            }
        }
    }
}
