using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{

    public static int CoinCount = 0;
    [SerializeField] private TextMeshProUGUI coinText;

    // Update is called once per frame
    void Update()
    {
        coinText.text = CoinCount.ToString();
    }
}
