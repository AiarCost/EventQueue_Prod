using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAmmo : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 300, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
