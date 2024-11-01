// Tutorial for changing scenes
// Documentatin: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideTriggerTwi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "LevelExit")
        {

            Debug.Log(SceneManager.GetActiveScene().name);
            // Change scene
            SceneManager.LoadScene("02_Next");
            
            // This will do the same thing.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
