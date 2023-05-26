using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   public float health;
   public int numOfHearts;
   public Image[] hearts;
   public Sprite FullHeart;
   public Sprite EmptyHeart;

   private void FixedUpdate()
   {
      if (health > numOfHearts)
      {
         health = numOfHearts;
      }

      for (int i = 0; i <hearts.Length; i++)
      {
         if (i > Mathf.RoundToInt(health))
         {
            hearts[i].sprite = FullHeart;
         }
         else
         {
            hearts[i].sprite = EmptyHeart;
         }

         if (i < numOfHearts)
         {
            hearts[i].enabled = true;
         }
         else
         {
            hearts[i].enabled = false; 
         }
      }
   }
}
