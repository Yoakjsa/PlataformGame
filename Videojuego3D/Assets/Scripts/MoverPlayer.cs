using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{

    [Range(0, 15)]public float speed;
    public float turnspeed;
    public bool canJump;
    public float forceJump;
    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        MoveController();
    }
    //Este metodo es para controlar el movimiento
    public void MoveController()
    {

        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, moveVertical * speed * Time.deltaTime);
        transform.Rotate(0, moveHorizontal, 0 * turnspeed * Time.deltaTime);
   
   if (canJump)
     {
    if(Input.GetKeyDown(KeyCode.Space))
      {
        _rigidbody.AddForce(Vector3.up*forceJump, ForceMode.Impulse); //(0,1,0)
      }
     }
    }
}
