using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanger : MonoBehaviour
{
   public void StartGame() 
{
    SceneManager.LoadScene("final");
}
}
