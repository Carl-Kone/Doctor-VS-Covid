using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomescreenButtons : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadScene("Game");
   }

   public void Quit()
   {
      Application.Quit();
   }
}
