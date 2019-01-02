using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform pelota;
    public Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pelota.position.x+distancia.x, pelota.position.y + distancia.y, pelota.position.z + distancia.z);
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0,1,0);
        }
        else if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, -1, 0);
        }
    }
}
