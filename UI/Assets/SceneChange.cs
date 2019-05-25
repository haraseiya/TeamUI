using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public void Picture1()
    {
        SceneManager.LoadScene("Picture 1");
    }

    public void Pucture2()
    {
        SceneManager.LoadScene("Picture 2");
    }

    public void Pucture3()
    {
        SceneManager.LoadScene("Picture 3");
    }
}
