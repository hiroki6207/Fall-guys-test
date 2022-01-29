using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallcrash : MonoBehaviour
{
    [SerializeField] private float thrust = 1.0f;
    private Rigidbody rb;

    public void AttachCrashMode()
    {
        gameObject.AddComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && rb)
        {
            rb.AddForce(transform.forward * thrust);
            StartCoroutine(DelayDestroy());
        }
    }

    private IEnumerator DelayDestroy()
    {
        // 3秒後に消える
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
