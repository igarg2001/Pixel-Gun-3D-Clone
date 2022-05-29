using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class LaunchManager : MonoBehaviourPunCallbacks
{

    public GameObject EnterGamePanel;
    public GameObject ConnectionStatusPanel;

    #region Unity Methods
    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
        EnterGamePanel.SetActive(true);
        ConnectionStatusPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Public Methods
    public void ConnectToPhotonServer()
    {
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
            ConnectionStatusPanel.SetActive(true);
            EnterGamePanel.SetActive(false);
        }
    }

    #endregion

    #region Photon Callbacks
    public override void OnConnectedToMaster()
    {
        Debug.Log(PhotonNetwork.NickName + " is Connected to Photon Server");
    }

    public override void OnConnected()
    {
        Debug.Log("Connected to Internet");
    }



    #endregion

}
