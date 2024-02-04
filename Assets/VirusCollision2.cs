using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusCollision2 : MonoBehaviour
{
    public GameObject prefabVirus;
    public GameObject PrefabDebris;
    GameObject instanceDebris;

    private void OnCollisionEnter(Collision autreObjet)
    {
        if (autreObjet.gameObject.tag == "virus")
        {

            Inventaire.hit += 1;
            instanceDebris = Instantiate(PrefabDebris, transform.position, transform.rotation);
            Destroy(autreObjet.gameObject);
            instanceDebris.GetComponentInChildren<Rigidbody>().AddForce(new Vector3(1, 1, 1) * 1000);
            instanceDebris.GetComponentInChildren<Rigidbody>().angularVelocity=new Vector3(10,10,10);
            Destroy(instanceDebris, 2);
        }
       
      
    }
    
}
