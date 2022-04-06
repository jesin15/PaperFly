using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FINALSCENEMANAGER : MonoBehaviour
{
   public void retry()
    {
        SceneManager.LoadScene(1);
        score.scorevalue = 0;

    }
   public void home()
    {
        SceneManager.LoadScene(0);
        score.scorevalue = 0;
    } 
}
