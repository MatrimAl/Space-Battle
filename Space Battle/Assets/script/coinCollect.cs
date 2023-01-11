using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinCollect : MonoBehaviour
{
    public TextMeshProUGUI MyscoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Coin Score :" + ScoreNum;
        
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "coin")
        {
            ScoreNum += 1;
            Destroy(coin.gameObject);
            MyscoreText.text = "Coin Score :" + ScoreNum;
            
        }
    }
}
