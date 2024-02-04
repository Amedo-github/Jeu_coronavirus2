using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppliquerForce : MonoBehaviour
{
    public GameObject canon;
   
    //public Text afficheurObus;
    Rigidbody rbBoulet;
    float moduleF=6000;
    public GameObject prefabBoulet;
    GameObject instanceBoulet;
    Vector3 F;
    Vector3 directionForce;
    //public Transform trCamera;
    // Update is called once per frame
    void Update()
    {
   
       
        directionForce = RotateWithMouse2.direction;
        if (Input.GetButtonDown("Fire1")&&!Inventaire.partieFinie)
        {
            
            instanceBoulet = Instantiate(prefabBoulet, canon.transform.position, canon.transform.rotation);
            instanceBoulet.transform.eulerAngles = new Vector3(0, 90, 0);
            instanceBoulet.GetComponent<Rigidbody>().AddForce(transform.forward * moduleF);
            //instanceBoulet.GetComponent<Rigidbody>().AddForce(directionForce * moduleF);
            //instanceBoulet.GetComponent<Rigidbody>().angularVelocity=new Vector3(0,2000,0);
            Destroy(instanceBoulet, 5);
            
        }

    }
    
    
    

}
