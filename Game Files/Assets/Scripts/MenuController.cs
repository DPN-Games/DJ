using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadControllerDebug () {
        SceneManager.LoadScene("ControllerDebug");
    }

    public void LoadMenu () {
        SceneManager.LoadScene("MainMenu");
    }
}
