using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class finishGame : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            finish();
        }


    }

    public void finish()
    {
        SceneManager.LoadScene("Scene_03");
    }
}