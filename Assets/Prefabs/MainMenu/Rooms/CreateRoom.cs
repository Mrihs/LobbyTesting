using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviourPunCallbacks
{

    [SerializeField]
    private Text _roomName;


    public void OnClick_CreateRoom()
    {
        //Stop if no connection to Photon!
        if (!PhotonNetwork.IsConnected)
            return;

        //CreateRoom


        //JoinOrCreateRoom
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 3;
        PhotonNetwork.JoinOrCreateRoom("basic", options, TypedLobby.Default);
    }


    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
        print("Room creation successfull!");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Room creation failed: " + message);

    }


}
