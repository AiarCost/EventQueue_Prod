using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchingAmmo : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 800, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y <= 0)
        {
            Destroy(gameObject);
        }
    }
}
