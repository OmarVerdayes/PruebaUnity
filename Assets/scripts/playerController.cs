using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;//velocidad del jugador
    private Rigidbody rb;//

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        rb.AddForce(moveX*moveSpeed,0,moveZ*moveSpeed,ForceMode.Acceleration);
    }



}
