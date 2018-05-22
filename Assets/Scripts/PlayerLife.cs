﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

    //player life
    public Image playerLife1;
    public Image playerLife2;
    public Image playerLife3;
    public RectTransform numPlayerLives;
    public Slider healthSlider;

    public static int lives;
    public static int countLives;

    // Use this for initialization
    void Start () {      
        if (PlayerLife.countLives != 0){
            checkLife();
        }
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    
    void checkLife() {
        if (PlayerLife.lives == 2) {
            removeLife(playerLife3);
        } else if (PlayerLife.lives == 1) {
            removeLife(playerLife3);
            removeLife(playerLife2);
        }else if (PlayerLife.lives == 0) {
            //gameOver();
        }
    }

    void removeLife(Image playerLifeImg) {
        playerLifeImg.enabled = false;
        float difference = healthSlider.transform.position.x - playerLifeImg.transform.position.x;
        Vector3 temp = healthSlider.transform.position; // copy to an auxiliary variable...
        temp.x = healthSlider.transform.position.x - difference + 5; // modify the component you want in the variable...
        healthSlider.transform.position = temp;
    }

}
