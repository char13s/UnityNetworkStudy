using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class Player : NetworkBehaviour
{
    [SerializeField] private GameObject cam;
    internal Stats stats = new Stats();
    // Start is called before the first frame update
    void Start()
    {
        if (IsOwner) { 
        GameObject newCam=Instantiate(cam, transform.position, Quaternion.identity);
        newCam.GetComponent<PlayerCamera>().SetCameraParameters(gameObject);
        }
    }
}
