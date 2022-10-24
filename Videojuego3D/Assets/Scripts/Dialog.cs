using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
       [SerializeField] TMP_Text dialogs;
       [SerializeField] GameObject dialogPanel;
       [SerializeField] GameManager gameManager;

     private void OnTriggerStay(Collider other)
     {
          if(other.CompareTag("Player"))
          {
               dialogPanel.SetActive(true);
               if (gameManager.haveKey==false)
               {
                    dialogs.text="!Necesitas encontrar una llave!";
               }
               else
               {
                    dialogs.text="Presiona 'k' para abrir la puerta";
               }
          }
     }

     private void OnTriggerExit(Collider other)
     {
          if(other.CompareTag("Player"))
          {
               dialogPanel.SetActive(false);
          }
     }
}
