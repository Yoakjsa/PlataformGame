using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDoor : MonoBehaviour
{

       [SerializeField] TMP_Text dialogs;
       [SerializeField] GameObject dialogPanel;
       [SerializeField] GameManager gameManager;

     private void OnTriggerStay(Collider other)
     {
          if(other.CompareTag("Player"))
          {
            dialogs.text="¡Felicidades!, avanza al siguiente nivel";
          }
     }
}