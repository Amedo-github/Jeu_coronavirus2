using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SourceVirus : MonoBehaviour
{
    public GameObject PrefabVirus;
    GameObject instanceVirus;
    Renderer rInstanceVirus;
    public static Animator animInstanceVirus;
    //bool isIdle = true;
    float delai = Inventaire.delai;
    public Text afficheurFin;

    public Transform[] sourcePositions;
    // Update is called once per frame
    void Update()
    {
        

        
        
        if (!Inventaire.partieFinie)
        {
            delai = delai - Time.deltaTime;
            if(delai < 0)
            {
                //transform.position = new Vector3(Random.Range(-200, 200), 50,Random.Range(50,90));
                int rand = Random.Range(0, sourcePositions.Length);
                transform.position = sourcePositions[rand].position;
                instanceVirus = Instantiate(PrefabVirus, transform.position, transform.rotation);
               // animInstanceVirus = instanceVirus.GetComponent<Animator>();
               // animInstanceVirus.SetBool("isIdle", true);
                Inventaire.nbVirus += 1;
                if(instanceVirus.transform.position.z<-90)
                {
                    Destroy(animInstanceVirus);
                }
                delai = Inventaire.delai;
            }
            
        }
        
        
    }
   


}
