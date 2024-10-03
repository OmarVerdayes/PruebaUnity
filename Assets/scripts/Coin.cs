using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource moneda;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Ganaste una moneda");
            moneda.PlayOneShot(moneda.clip);
            Destroy(this.gameObject);
        }
    }
}
