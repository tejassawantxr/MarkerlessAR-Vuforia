using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   public void OpenMidAirAugmentation(){
    SceneManager.LoadScene("MidAirScene");
   }

   public void OpenGroundPlaneAugmentation(){
    SceneManager.LoadScene("GroundPlaneScene");
   }
}
