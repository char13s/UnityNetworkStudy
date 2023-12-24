using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject cam;
    internal Stats stats = new Stats();
    // Start is called before the first frame update
    void Start()
    {
        GameObject newCam=Instantiate(cam, transform.position, Quaternion.identity);
        newCam.GetComponent<PlayerCamera>().SetCameraParameters(gameObject);
    }
}
