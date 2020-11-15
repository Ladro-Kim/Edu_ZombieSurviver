using Photon.Pun; // 유니티용 포톤 컴포넌트
using Photon.Realtime; // 포톤 서비스 관련 라이브러리
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public InputField Text_connectinoInfo;
    public Button Button_Connect;


    void Start()
    {
        Button_Connect.interactable = false;
    }

    void Update()
    {
        
    }

    public void Connect()
    {

    }

    

}
