using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayerDos : MonoBehaviour
{
    [Range(0, 15)] public float speed;
    public float turnspeed;
    public bool canJump;
    public float forceJump;

    public GameObject chocolate;
    public bool haveChocolate;

    public Transform _initialPosition;
    public GameObject[] plataforms;
    public bool isInGround;

    [SerializeField] GameManager gameManager;

    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveController();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Danger") && gameManager.lifes>0)
        {
            transform.position = _initialPosition.position;
            gameManager.lifes -=1;
  
        }
        if (other.CompareTag("Chocolate"))
        {
            haveChocolate = true;
            Destroy(other.gameObject);
        }

        if(other.CompareTag("Chocolate"))
        {
            gameManager.haveChocolate=true;
        }
    }
    private void OnTriggerStay(Collider other)

    {
        if (other.CompareTag("Ground")) isInGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground")) isInGround = false;
    }

    //Este metodo es para controlar el movimiento

    public void MoveController()
    {

        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, moveVertical * speed * Time.deltaTime);
        transform.Rotate(0, moveHorizontal, 0 * turnspeed * Time.deltaTime);

        //Este metodo es para saltar
        if (canJump && isInGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
            }
        }
    }
}
