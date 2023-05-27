using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TpWin : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {

        if ((KeyText.keys == 3) && CoinText.coin == 9 )
        {
            SceneManager.LoadScene("won");
        }
    }
}
