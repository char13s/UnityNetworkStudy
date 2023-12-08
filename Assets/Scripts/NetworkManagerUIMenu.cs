using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using UnityEngine.Events;
public class NetworkManagerUIMenu : MonoBehaviour
{
    public static UnityAction openRelay;
    public static UnityAction openClientMenu;
    [SerializeField] private Button host;
    [SerializeField] private Button server;
    [SerializeField] private Button client;
    private void Awake() {
        host.onClick.AddListener(() => {
            
            
            openRelay.Invoke(); 
        });
        server.onClick.AddListener(() => {

        });
        client.onClick.AddListener(() => {
            
           
        });

    }
    private void Start() {
        
    }
    private void CreateOpenClientMenu() { 

    }

}
