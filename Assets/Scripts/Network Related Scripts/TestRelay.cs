using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Relay;
using Unity.Services.Relay.Models;
using Unity.Netcode;
using Unity.Networking.Transport.Relay;
using Unity.Netcode.Transports.UTP;

public class TestRelay : MonoBehaviour
{
    public static event UnityAction<string> code;
    string CODE;
    // Start is called before the first frame update
    private async void Start()
    {
        await UnityServices.InitializeAsync();
        AuthenticationService.Instance.SignedIn += () => {
            Debug.Log("Signed in "+ AuthenticationService.Instance.PlayerId);
        };
        await AuthenticationService.Instance.SignInAnonymouslyAsync();

        NetworkManagerUIMenu.openRelay+=CreateRelay;
        SendCode.sendCode += JoinRelay;
        SendCode.sendCode += Testprint;
    }
    private async void CreateRelay() {
       
        try { 
        Allocation allocation = await RelayService.Instance.CreateAllocationAsync(3);
            string joinCode=await RelayService.Instance.GetJoinCodeAsync(allocation.AllocationId);
            CODE = joinCode;
            Debug.Log(joinCode);
            code.Invoke(joinCode);
            RelayServerData relayServerData = new RelayServerData(allocation, "dtls");
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);
          
            
            NetworkManager.Singleton.StartHost();
        }
        catch (RelayServiceException e) {
            Debug.Log(e);
        }
        
    }
    private void Testprint(string bithc) {
        print(bithc+1);
        
    }
    private async void JoinRelay(string joinCode) {
        try {
            Debug.Log("Joining Relay with " + joinCode);
            JoinAllocation joinAllocation= await RelayService.Instance.JoinAllocationAsync(joinCode);
  

            RelayServerData relayServerData = new RelayServerData(joinAllocation, "dtls");
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);

            NetworkManager.Singleton.StartClient();
        }
        catch (RelayServiceException e) {
            Debug.Log(e);
            code.Invoke("e");
        }
    }
}
