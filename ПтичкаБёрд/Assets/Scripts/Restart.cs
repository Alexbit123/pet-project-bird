using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    // Update is called once per frame
    public void RestartGame()
    {
        Time.timeScale = 0.0F;
        Application.LoadLevel(Application.loadedLevel);
        
    }
}
