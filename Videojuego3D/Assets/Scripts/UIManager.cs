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

    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
     {
        if(lifeIndicator !=null)
        {
             lifeIndicator.sprite=lifeSprites[gameManager.lifes];
        }

        if (panelController != null)
        {
             if(Input.GetKeyDown(KeyCode.P))
             {
                panelController[0].SetActive(true);
                Time.timeScale=0;
             }
        }
     }

     public void QuitPause()
     {
         panelController[0].SetActive(false);
         Time.timeScale=1;
     }

}
