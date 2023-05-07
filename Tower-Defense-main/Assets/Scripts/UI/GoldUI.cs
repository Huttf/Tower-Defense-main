using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUI : MonoBehaviour
{
    /* takes care of displaying the amount of gold the player has on the canvas*/
    public TMPro.TextMeshProUGUI goldText;
    //public Text goldText;
   
    // Update is called once per frame
    void Update()
    {
        goldText.text = "$" + PlayerResources.Gold.ToString();
    }
}
