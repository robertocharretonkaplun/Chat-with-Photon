using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class UserName : MonoBehaviour
{
  public TMP_InputField inputfield;
  public GameObject UserNamePage;
  


  // Start is called before the first frame update
  void Start()
  {
    if(PlayerPrefs.GetString("Username") == "" || PlayerPrefs.GetString("Username") == null)
    {
      UserNamePage.SetActive(true);
    }
    else
    {
      PhotonNetwork.NickName = PlayerPrefs.GetString("Username");

      UserNamePage.SetActive(false);
    }
  }

  public void SaveUserName()
  {
    PhotonNetwork.NickName = inputfield.text;

    PlayerPrefs.SetString("Username", inputfield.text);

    UserNamePage.SetActive(false);
  }
}
