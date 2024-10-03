using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 1f;//velocidad del jugador
    public Transform camara;
    private Rigidbody rb;//

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = camara.forward;//sirve para guardae cordenadas xyz y en cao de rotacion es cuadrnios
        Vector3 right = camara.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward *moveZ + right * moveX);



        rb.AddForce(moveDirection * moveSpeed,ForceMode.Acceleration);
    }



}
