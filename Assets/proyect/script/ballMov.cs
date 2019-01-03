using System.Collections;
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

        rb.AddRelativeForce(new Vector3(Input.GetAxis("Horizontal")*speed,rb.velocity.y, Input.GetAxis("Vertical") * speed),ForceMode.Acceleration);
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up * 10);
        }
        else if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.down * 10);
        }
    }
}
