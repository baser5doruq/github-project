using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gap : MonoBehaviour
{
    public GameObject cember;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(cember);
    }
}
