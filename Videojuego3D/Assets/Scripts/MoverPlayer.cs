using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{

    [Range(0, 15)]public float speed;
    public float turnspeed;

    public bool jump;
    public float JumpForce;
    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }

        Move();
    }

    public void Move()
    {

        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, moveVertical * speed * Time.deltaTime);
        transform.Rotate(0, moveHorizontal, 0 * turnspeed * Time.deltaTime);
    }
    


}
