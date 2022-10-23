using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
    public bool isUnlocked=true;
    public float doorSpeed=1f;
    public Transform openTransform;
    public Transform closeTransform;

    Vector3 targetPosition;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition=closeTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isUnlocked && door.position !=targetPosition)
        {
            door.transform.position=Vector3.Lerp(door.transform.position, targetPosition, time);
            time = Time.deltaTime * doorSpeed;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            targetPosition = openTransform.position;
        }
    }
}
