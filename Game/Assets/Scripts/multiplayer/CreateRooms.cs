using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
public class CreateRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField roomInput;
    [SerializeField] Button joinButton;
    [SerializeField] Button createButton;

    // Start is called before the first frame update
    void Start()
    {
        joinButton.onClick.AddListener(join);
        createButton.onClick.AddListener(create);


    }

    public override void OnJoinedRoom()
    {
        //base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("Game");
    }

    void join()
    {
        string text = roomInput.text;
        PhotonNetwork.JoinRoom(text);
    }

    void create()
    {
        string text = roomInput.text;
        PhotonNetwork.CreateRoom(text);
    }
}
