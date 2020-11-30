using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontroluScripti : MonoBehaviour {

    public void SonrakiSahne()
    {
        int MevcutSahneninİndexi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(MevcutSahneninİndexi + 1);
    }

    public void OyunSahnesineYönlen()
    {
        SceneManager.LoadScene(1);
    }

    public void OyundanCik()
    {
        Application.Quit();
    }

}

