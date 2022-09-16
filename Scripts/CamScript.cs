using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.1f;
    public Vector3 offset;
    private float chicken;
    private float dog;
    public GameObject hitd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        chicken = target.position.z;
        dog = target.position.x;
        dog = 0 - dog;
        chicken = 0 - chicken;
        offset = new Vector3(dog, 4, chicken);
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    
    }
}