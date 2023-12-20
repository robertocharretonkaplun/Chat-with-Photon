using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Message : MonoBehaviour
{
  public TMP_Text messageText;
  // Start is called before the first frame update
  void Start()
  {
    GetComponent<RectTransform>().SetAsFirstSibling();
  }
  // Update is called once per frame
  void Update()
  {

  }
}
