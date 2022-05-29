﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNameInputManager : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void SetPlayerName(string playerName)
    {
        if(string.IsNullOrEmpty(playerName))
        {
            Debug.Log("Player name is empty");
            return;
        }
        PhotonNetwork.NickName = playerName;
    }

    
}
