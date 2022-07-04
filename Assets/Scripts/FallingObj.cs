using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObj : MonoBehaviour
{
    MeshRenderer rendered;
    Rigidbody rb;
    [SerializeField] float secondrule = 3f;
    private void Start()
    {
        rendered = GetComponent<MeshRenderer>();
        rendered.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
    }
    void Update()
    {
        if (Time.time > secondrule)
        {
            rb.useGravity = true;
            rendered.enabled = true;
        }
    }
}
