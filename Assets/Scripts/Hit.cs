using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Image _winUI;

    public byte _winTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.forward * _force);
        }

        if (other.CompareTag("Skelet"))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.forward * _force);
            if (_winTrigger<1)
            {
                StartCoroutine(Win());
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
        _winUI.gameObject.SetActive(true);
    }
    
}
