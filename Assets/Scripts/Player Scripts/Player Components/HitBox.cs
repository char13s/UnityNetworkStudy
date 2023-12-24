using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class HitBox : MonoBehaviour
{
    [SerializeField] private GameObject hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        Instantiate(hitEffect, transform.position, Quaternion.identity);
    }

}
 