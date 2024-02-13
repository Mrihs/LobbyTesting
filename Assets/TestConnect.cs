using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        //Message that Server-Connection is Set-Up
        print("Now connecting to Server.");

        PhotonNetwork.NickName = MasterManager.GameSettings.Nickname;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;

        //Enter the Game-Version
        //PhotonNetwork.GameVersion = "0.0.1";
        // This makes that only Users with the same version can cooperate together

        //Connect to the Photon-Server
        PhotonNetwork.ConnectUsingSettings();



        //Connect to the Best Server with the best Pinkg:
        //PhotonNetwork.ConnectToBestCloudServer;

        //Connect to a System with Master, Server and ID
        //PhotonNetwork.ConnectToMaster;

        //Connect to a specific Region
        //PhotonNetwork.ConnectToRegion;

        //Connect to Photon with the Settings defined in Unity
        //PhotonNetwork.ConnectUsingSettings();


    }

    //When the Connection to the server has been achieved
    public override void OnConnectedToMaster() //MonoBehaviourPunCallbacks is needed so that this works
    {
        //Print when there is connection to the Server
        print("Connected to Server.");
        //Print The Nickname
        print(PhotonNetwork.LocalPlayer.NickName);
    }

    //When the Connection to the server fails
    public override void OnDisconnected(DisconnectCause cause)
    {
        //Print the Reason for Disconnection (The reasno is in cuase and inherited from OnDisconnected
        print("Disconnected from server because: " + cause.ToString());
    }
    



}
