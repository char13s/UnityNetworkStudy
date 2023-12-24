using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerCamera : MonoBehaviour
{
    CinemachineVirtualCamera cam;
    // Start is called before the first frame update
    private void Awake() {
         cam=GetComponent<CinemachineVirtualCamera>();
    }
    void Start()
    {
       
    }
    public void SetCameraParameters(GameObject obj) {
        cam.m_Follow = obj.transform;
        cam.m_LookAt = obj.transform;
    }
}
