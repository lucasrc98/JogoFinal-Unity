using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarInimigo2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inimigo3;
    public GameObject inimigoGuiado;
    private float startTime;
    void Start()
    {
        startTime = Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        float duracao = 1.7f;
        int posi; 
        
        if (t > duracao)
         {
            posi = posicaoAleatoria();
            if (posi == 1)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 10f, 0);
                lancarInimigo(inimigoAleatorio());
            }
         }
        
        if (t > duracao)
         {
            posi = posicaoAleatoria();
            if (posi == 2)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 0f, 0);
                lancarInimigo(inimigoAleatorio());
            }
         }
        
        if (t > duracao)
         {
            posi = posicaoAleatoria();
            if (posi == 3)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, -10f, 0);
                lancarInimigo(inimigoAleatorio());
            }
         }

        if (t > duracao) {
            posi = posicaoAleatoria();
            if (posi == 4) {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, -18, 0);
                lancarInimigo(inimigoAleatorio()); 
            }
        }
        

    }

    void lancarInimigo(GameObject inimigo) {

        GameObject g = Instantiate(inimigo) as GameObject;
        //g.transform.position = this.transform.position + (this.gameObject.transform.forward * 2.0f);
        g.transform.position = this.gameObject.transform.position; 
        g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 100.0f);
        startTime = Time.time;
    }

    int posicaoAleatoria() {
        int r;
        r = Random.Range(1,5);
        return r;
    }

    GameObject inimigoAleatorio(){
        int r;
        r = Random.Range(1,10);
        if(r <= 5){
            return inimigo3;
        }
        else{
            return inimigoGuiado;
        }
    }
}
