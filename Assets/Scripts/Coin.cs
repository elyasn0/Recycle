using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed;

    void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PurpleBall"|| other.tag == "GreenBall" || other.tag == "RedBall")
        {
            FindObjectOfType<AudioManager>().Play("CoinSound");
            Destroy(gameObject);
        }
    }
}
