using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{

    // Update is called once per frame
    public void Next()
    {
        Time.timeScale = 0.0f;
        SceneManager.LoadScene("Game");
    }
}
