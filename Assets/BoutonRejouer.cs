using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoutonRejouer : MonoBehaviour
{
   
    public void Rejouer(int numeroScene)
    {
        SceneManager.LoadScene(1);
        Inventaire.partieFinie = false;
        Inventaire.temps = 0;
        Inventaire.nbVirus = 0;
        Inventaire.hit = 0;
        Cursor.visible = false;

    }
}
