using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainHandler : MonoBehaviour
{
    public void BackNew()
    {
        SceneManager.LoadScene(0);
    }
}
