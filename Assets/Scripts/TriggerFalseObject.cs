using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFalseObject : MonoBehaviour
{
    public GameObject Obj;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider player){
        if (player.gameObject.tag == "Player")
        {
            Obj.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}