using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            // Debug.Log("It works!");
            SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);
        }
    }
}
