using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusSeDirigeVersMoi : MonoBehaviour
{
   
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision autreObjet)
    {
        if(autreObjet.gameObject.tag=="sol"&&!Inventaire.partieFinie)
        {
            GetComponent<Rigidbody>().AddForce((new Vector3(0,2,-80) - transform.position) * 20);
        }
       
    }
}
