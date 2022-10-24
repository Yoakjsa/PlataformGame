using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoRampa : MonoBehaviour
{
       [SerializeField] TMP_Text dialogs;
       [SerializeField] GameObject dialogPanel;
       [SerializeField] GameManager gameManager;
       [SerializeField] Animator plataformPink;

       bool movePlataform;

     private void OnTriggerStay(Collider other)
     {
          if(other.CompareTag("Player"))
          {
               dialogPanel.SetActive(true);
               if (gameManager.haveChocolate==false&&!movePlataform)
               {
                    dialogs.text="¡Necesitas encontrar un chocolate!";
               }
               else 
               {
                    dialogs.text="Presiona 'y' para subir";
               }
          }

          if(Input.GetKey(KeyCode.Y))
          {
               plataformPink.SetBool("UseChocolate", true);
               movePlataform=true;
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
