using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField]
    public float degrees = 0f;
    public float increase = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        degrees += increase;
        transform.eulerAngles = Vector3.forward * degrees;
    }
}
