using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOnClick : MonoBehaviour
{
    public void ButtonPlay(string Level)
    {
        SceneManager.LoadScene(Level, LoadSceneMode.Single);
    }

    public void ButtonSettings(string Level)
    {
        SceneManager.LoadScene(Level, LoadSceneMode.Single);
    }

    public void ButtonBack(string Level)
    {
        SceneManager.LoadScene(Level, LoadSceneMode.Single);
    }
}
