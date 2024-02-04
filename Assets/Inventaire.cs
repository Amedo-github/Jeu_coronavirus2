using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventaire : MonoBehaviour
{
    public static int temps;
    public static float delai;//temps entre chaque virus
    private float t;
   
    public static int hit = 0;
    public static int nbVirus = 0;
   
    public Text afficheurTemps;
    public Text afficheurHit;
    public Text afficheurNbVirus;
    public Text afficheurFin;
    public Text afficheurMessages;
    // public Text afficheurSpheres;
    public static bool partieFinie = false;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        delai=2;
        t = delai;
        Object.DontDestroyOnLoad(afficheurTemps);
        Object.DontDestroyOnLoad(afficheurHit);
        Object.DontDestroyOnLoad(afficheurNbVirus);
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(delai);
        if (!partieFinie)
        {
            t = t - Time.deltaTime;
           
            if (t < 0)
            {
                temps = temps + 1;
                afficheurMessages.text = "30 s d'entrainement:un virus toutes les 2 s!";
                t = delai;
                if (temps > 30)
                {
                    delai = 1;
                    afficheurMessages.text = "Choses sérieuses: un virus par s!";

                }
                
                if (temps > 60)
                {
                    delai = .2f;
                    afficheurMessages.text = "Vous êtes un as: 5 virus s!";
                }
               
                
                if (temps > 90)
                {
                    SceneManager.LoadScene(2);
                    partieFinie = true;
                    Cursor.visible = true;
                }
                
            }
                
                
         }       
       
         
       
        afficheurTemps.text = "Temps:" + temps;
        afficheurHit.text = "Tués :" + hit;
        afficheurNbVirus.text = "Virus :" + nbVirus;
       

    }
}
