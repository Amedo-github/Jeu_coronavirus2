using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoutonCommencer : MonoBehaviour
{
    private void Start()
    {

    }
    public void Commencer(int numeroScene)
    {
        Inventaire.temps = 0;
        Inventaire.delai = 2;
       
        SceneManager.LoadScene(1);
       
    }
    
    
}
