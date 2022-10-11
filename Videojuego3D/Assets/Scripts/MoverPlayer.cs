using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{

    [Range(0, 15)]public float speed;
    public float turnspeed;
    public bool canJump;
    public float forceJump;

    public Transform _initialPosition;
    public GameObject[] plataforms;

    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        MoveController();
    }

    public void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Danger"))
      {
        transform.position=_initialPosition.position;
      }

       if(other.CompareTag("PowerUpJump"))
      {
        canJump = true;

        plataforms[0].GetComponent<Rigidbody>().useGravity = true;
        plataforms[0].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        plataforms[1].GetComponent<Rigidbody>().useGravity = true;
        plataforms[1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        Destroy(other.GameObject);
      }
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
