using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRotate : MonoBehaviour
{
    Transform transform;
    [SerializeField] float speed=100;
    Vector3 startVec, stopVec;
    bool isRotateEnd;
    // Start is called before the first frame update
    void Start()
    {
        startVec=new Vector3(0,0,18);
        stopVec = new Vector3(0,0,-25);
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.T))
         {
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -30), speed * Time.deltaTime);
         }*/
        Rotate();

    }
    void Rotate()
    {
        if (transform.rotation == Quaternion.Euler(stopVec))
        {
            isRotateEnd = true;
        }
        if (transform.rotation == Quaternion.Euler(startVec))
        {
            isRotateEnd = false;
        }
        if (!isRotateEnd)
        {

            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(stopVec), speed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(startVec), speed * Time.deltaTime);
        }
    }
}
