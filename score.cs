﻿using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (player.position.z + 684).ToString("0");
    }
}
