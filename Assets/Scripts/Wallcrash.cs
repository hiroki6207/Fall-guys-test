using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallcrash : MonoBehaviour
{
    [SerializeField] private float thrust = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    public void AttachRigidbody()
    {
        gameObject.AddComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && rb != null)
        {
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
            StartCoroutine(DelayDestroy());
        }
    }

    public IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
