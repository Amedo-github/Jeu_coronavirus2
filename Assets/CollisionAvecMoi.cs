using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionAvecMoi : MonoBehaviour
{
    private WaitForSeconds attente;
    public Text afficheurTemps;
    public Text afficheurNbVirus;
    public Text afficheurHit;//détruits
   
    private void Start()
    {
        attente =new WaitForSeconds(2);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "virus")
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            Inventaire.partieFinie = true;
            Cursor.visible = true;
            other.transform.position = new Vector3(0,2.77f,-77);
            


            StartCoroutine(Attendre());


        }
    }
    /*
    private void OnCollisionEnter(Collision autreObjet)
    {
        
    }
  */
    IEnumerator Attendre()
    {
        yield return attente;

        SceneManager.LoadScene(3);
        afficheurTemps.text = "Temps:" + Inventaire.temps;
        afficheurNbVirus.text = "Virus :" + Inventaire.nbVirus;
          afficheurHit.text = "Tués :" +Inventaire.hit;
        
       



    }


}
