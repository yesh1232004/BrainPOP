using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadAnatomies : MonoBehaviour
{
   public void loadAnat()
    {
        SceneManager.LoadScene("AnatomiesScene");
    }
}
