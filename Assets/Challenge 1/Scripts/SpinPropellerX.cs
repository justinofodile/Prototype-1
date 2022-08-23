using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f, speed * Time.fixedDeltaTime);
        //transform.Rotate(Vector3.right, Time.deltaTime * speed);
        transform.Rotate(0f, 0f, speed * Time.fixedDeltaTime, Space.Self);
    }
}
