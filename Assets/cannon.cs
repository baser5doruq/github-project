using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public float movementSpeed = 200.0f;
    public float currentSpeed = 0;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(currentSpeed > 200f)
        {
            currentSpeed = movementSpeed;
        }
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            currentSpeed += movementSpeed;
            rb.AddForce(Vector3.up * currentSpeed);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("degdi");
        this.transform.position = new Vector3(0, -8, 0);
        currentSpeed = -200f;
    }
}
