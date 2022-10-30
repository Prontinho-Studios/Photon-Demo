using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private void Start()
    {   
        print("Connecting to server.");
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.GameVersion = "0.0.1";
    }

    public override void OnConnectedToMaster(){
        print("Connected to server.");
    }

     public override void  OnDisconnected(DisconnectCause cause){
        print("disconected from server for reason: " + cause);
    }
}
