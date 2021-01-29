using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helahtbarscript : MonoBehaviour
{
    Image healthbar;
    float maxHealth = 100f; //the max amount of health
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
    healthbar = GetComponent<Image>(); //displays the healthbar image
    health = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
    healthbar.fillAmount = health / maxHealth; //health divided by the max amount you can have
    }
}