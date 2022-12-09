using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour
{
    public GameObject Obj;
    public GameObject Obj2;
    public AudioSource AudioSource;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider player){
        if (player.gameObject.tag == "Player")
        {
            Obj.SetActive(true);
            Obj2.SetActive(false);
            AudioSource.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}