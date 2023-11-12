using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField] GameObject muruPrefab;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(muruPrefab.name, transform.position, Quaternion.identity);   
    }

}
