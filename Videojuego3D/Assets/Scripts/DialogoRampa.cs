using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoRampa : MonoBehaviour
{
       [SerializeField] TMP_Text dialogs;
       [SerializeField] GameObject dialogPanel;
       [SerializeField] GameManager gameManager;
       [SerializeField] Animator openDoorAnim;

       bool doorOpen;

     private void OnTriggerStay(Collider other)
     {
          if(other.CompareTag("PlayerDos"))
          {
               dialogPanel.SetActive(true);
               if (gameManager.haveChocolate==false&&!doorOpen)
               {
                    dialogs.text="¡Necesitas encontrar un chocolate!";
               }
               else 
               {
                    dialogs.text="Presiona 'k' para abrir la puerta";
               }
          }

          if(Input.GetKey(KeyCode.K))
          {
               openDoorAnim.SetBool("UseChocolate", true);
               doorOpen=true;
          }

          if(doorOpen)
          {
          dialogs.text="¡Felicidades!, acabaste el juego, avanza para regresar al inicio";
          }
     
     }

     private void OnTriggerExit(Collider other)
     {
          if(other.CompareTag("PlayerDos"))
          {
               dialogPanel.SetActive(false);
          }
     }
}

