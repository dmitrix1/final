using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleportcontroller : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
  {

      //if (Input.GetKeyDown(KeyCode.E))
      {


          SceneManager.LoadScene("Dungeon");
      }
  }
}
