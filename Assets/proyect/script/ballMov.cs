﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMov : MonoBehaviour
{
    public int speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed,rb.velocity.y, Input.GetAxis("Vertical") * speed);
    }
}
