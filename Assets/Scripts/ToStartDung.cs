using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStartDung : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D other)
    { 
    
        print("23456789");

        SceneManager.LoadScene("Start");
    
    
    }
}
