﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCheve : MonoBehaviour
{
    public GameObject R;
    public GameObject L;

    public GameObject Up;

    public GameObject leo;
    public GameObject Down;
    public float velocidadex;
    public float velocidadey;
    public float aumento;
    // Start is called before the first frame update
    public int resistencia;
    void Start()
    {   
        velocidadex = 0.4f;
        velocidadey = 0.4f;
        aumento = 0.01f;
        resistencia = 25;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidadex,velocidadey,0);    
        rebater();
    }

      void rebater(){

         /* if((int)this.gameObject.transform.position.x == (int)R.transform.position.x - 1){
              velocidadex = aumento + velocidadex * -1;
              if(leo.GetComponent<SpriteRenderer>().flipX == true){
                  leo.GetComponent<SpriteRenderer>().flipX = !leo.GetComponent<SpriteRenderer>().flipX;
              }
             
         } */
         if( (int)this.gameObject.transform.position.x == (int)L.transform.position.x + 1){
             velocidadex = aumento + velocidadex * -1;
             leo.GetComponent<SpriteRenderer>().flipX = !leo.GetComponent<SpriteRenderer>().flipX;
         }
         if((int)this.gameObject.transform.position.y == (int)Up.transform.position.y - 1|| (int)this.gameObject.transform.position.y == (int)Down.transform.position.y + 1 ){
             velocidadey = aumento + velocidadey * -1;
         }
     }

      void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "player"){
             GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().decrementaVidas();
        }
        if(collision.gameObject.tag == "Halter1"){
            resistencia--;
GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().incrementaPontosChefe();
GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().decrementaPorcentagem();

            Destroy(collision.gameObject);
             if(resistencia <= 0){
                UnityEngine.SceneManagement.SceneManager.LoadScene("telafinalVitoria");
             }
        }
        if(collision.gameObject.tag == "Halter2"){
            resistencia--;
GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().incrementaPontosChefe();
GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().decrementaPorcentagem2();

            Destroy(collision.gameObject);
             if(resistencia <= 0){
                UnityEngine.SceneManagement.SceneManager.LoadScene("prefase1");
             }
        }
        if(collision.gameObject.name == L.name){
            velocidadex = aumento + velocidadex * -1;
            leo.GetComponent<SpriteRenderer>().flipX = !leo.GetComponent<SpriteRenderer>().flipX;
              
        }
        if(collision.gameObject.name == Up.name){
            velocidadey = aumento + velocidadey * -1;
             
        }
        if(collision.gameObject.name == Down.name){
            velocidadey = aumento + velocidadey * -1;
             
        }
         if(collision.gameObject.name == R.name){
            velocidadex = aumento + velocidadex * -1;
              if(leo.GetComponent<SpriteRenderer>().flipX == true){
                  leo.GetComponent<SpriteRenderer>().flipX = !leo.GetComponent<SpriteRenderer>().flipX;
              }
        }
    }

}
