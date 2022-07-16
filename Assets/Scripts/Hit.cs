using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private float _force;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.CompareTag("Object"))
        {
            Debug.Log("Hitted");
            other.GetComponent<Rigidbody>().AddForce(Vector3.forward * _force);
        }

        if (other.CompareTag("Skelet"))
        {
            Debug.Log("enemyHitted");
            other.GetComponent<Rigidbody>().AddForce(Vector3.forward * _force);
        }

        
    }
    
}
