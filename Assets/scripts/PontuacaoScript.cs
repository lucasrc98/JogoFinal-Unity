﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PontuacaoScript : MonoBehaviour
{
    public Text vidasUI;
    public Text pontosUI;
    int pontos;
    int vidas;
     static int cont = 3;
    // Start is called before the first frame update
    void Start(){
        pontos = 0;
        vidas = 3;
    }

    // Update is called once per frame
    void Update(){
        passarfase();
        gameOver();
        
    }
    public void incrementaPontos(){
        this.pontos = this.pontos + 20;
        pontosUI.text = pontos.ToString();
        Debug.Log(pontos);
    }
      public void incrementaPontos2(){
        this.pontos = this.pontos + 30;
        pontosUI.text = pontos.ToString();
        Debug.Log(pontos);
    }
    public void decrementaVidas(){
        this.vidas = this.vidas - 1;
        vidasUI.text = vidas.ToString();
        Debug.Log(vidas);
    }

    void gameOver()
    {
        if (vidas <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("TelaFimDeJogo");
        }
    }
    void passarfase(){
        if(cont == 3){
            if(pontos >= 1300){
                cont--;   
                UnityEngine.SceneManagement.SceneManager.LoadScene("prefase2");
            }
        }
        if(cont == 2){
            if(pontos >= 2000){
                cont--;
                UnityEngine.SceneManagement.SceneManager.LoadScene("prefase3");
            }
        }
    }
}

