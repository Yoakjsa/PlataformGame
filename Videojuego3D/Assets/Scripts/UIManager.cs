using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
   [SerializeField] GameManager gameManager;
   [SerializeField] Image lifeIndicator;
   [SerializeField] Sprite[] lifeSprites;

   [SerializeField] GameObject[] panelController;

   [SerializeField] TMP_Text[] dialogs;

     private void Update()
     {
        lifeIndicator.sprite=lifeSprites[gameManager.lifes];

     }

     public void starGame()
     {
         SceneManager.LoadScene(1);
     }
}
