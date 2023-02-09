using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("LoadSceneNext");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}