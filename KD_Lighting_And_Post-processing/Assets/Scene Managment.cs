using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{

    public void nextScene()
    {

        SceneManager.LoadScene(((SceneManager.GetActiveScene().buildIndex + 1) % (SceneManager.sceneCount + 1)));

    }

}
