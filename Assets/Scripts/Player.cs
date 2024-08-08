using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float turnSpeed;

    public void Update()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }
}
