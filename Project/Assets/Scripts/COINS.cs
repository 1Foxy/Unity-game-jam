using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COINS : MonoBehaviour
{
    public int Coins;
    public Text text;

    public void Start()
    {
        text = GetComponent<Text>();
    }
    public void Update()
    {
        text.text = "Trees Killed : " + Coins;
    }
    public void Add()
    {
        Coins += 1;
    }


}
