using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class UiManager : MonoBehaviour
{

    public TMP_Text txtGold;
    public int goldInVault;


    public void UpdateUi()
    {
        txtGold.text = goldInVault.ToString();
    }
}
