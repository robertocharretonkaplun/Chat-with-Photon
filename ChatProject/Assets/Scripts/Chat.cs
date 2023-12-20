using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
public class Chat : MonoBehaviour
{
  public TMP_InputField inputfield;
  public GameObject Message;
  public GameObject ClientMessage;
  public GameObject Content;
  public TMP_Text ClientName;
  private void Start()
  {
    if (GetComponent<PhotonView>().IsMine == false)
    {
      if (GetComponent<PhotonView>().Controller.NickName == "")
      {
        ClientName.text = "Dummy Client";
      }
      else
      {
        ClientName.text = GetComponent<PhotonView>().Controller.NickName;
      }
    }
  }
  public void SendMessage()
  {
    GetComponent<PhotonView>().RPC("GetMessage", RpcTarget.All, (PhotonNetwork.NickName + " : " + inputfield.text));

    inputfield.text = "";
  }

  [PunRPC]
  public void GetMessage(string ReciveMsg)
  {
    GameObject Msg = Instantiate(Message, Vector3.zero, Quaternion.identity, Content.transform);
    Msg.GetComponent<Message>().messageText.text = ReciveMsg;
  }
}
