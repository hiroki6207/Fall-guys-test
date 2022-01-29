using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHelth : MonoBehaviour
{
    [SerializeField] private Wallcrash[] walls;
    // Start is called before the first frame update
    private void Start()
    {
        int index = Random.Range(0, walls.Length);
        walls[index].AttachRigidbody();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
