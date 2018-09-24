using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartButton : MonoBehaviour {

    public void OnClickRestart()
    {
        SceneManager.LoadScene(0);
    }
}
