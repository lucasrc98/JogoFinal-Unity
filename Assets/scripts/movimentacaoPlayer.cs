using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
 
public class movimentacaoPlayer : MonoBehaviour
{
    public GameObject barreiraL;
    public GameObject barreiraR;
    public GameObject barreiraUp;
    public GameObject barreiraDown;
    public GameObject cInimigo;
    static int cont = 2;
    private float tempoInicio;
   // public int vidas;

    public GameObject prefabProjetil;
    public float velocidadex;
    public float velocidadey;
    public float velocidade; 
    // Start is called before the first frame update
    void Start()
    {
        tempoInicio = Time.time;
       // vidas = 3; 
        velocidade = 20f;
        velocidadex = velocidade;
        velocidadey = velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        velocidade = 20f;
       /* if (Time.time - tempoInicio > 60)
        {
            Debug.Log("Destruiu");
            Destroy(cInimigo);
        }
        if (Time.time - tempoInicio > 62 && cont == 2) {
            cont--;
            UnityEngine.SceneManagement.SceneManager.LoadScene("prefase2");
            //UnityEngine.SceneManagement.SceneManager.LoadScene("TelaInicialScene");
        }
         */
        if (Input.GetKey(KeyCode.W)) {
            velocidadey = velocidade;
            if (BarreiraUp()) {
                velocidadey = 0;
            }
                transform.Translate(0, velocidadey * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S)){
            velocidadey = velocidade;
            if(BarreiraDown())
            {
                velocidadey = 0;
            }
            transform.Translate(0, -velocidadey * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A)){
            velocidadex = velocidade;
            //if(this.gameObject.transform.position.x <= -49.93784f)
            //{
            //   velocidadex = 0;
            //}
            if (BarreiraL()) {
                velocidadex = 0;
            }
            transform.Translate(velocidadex * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            velocidadex = velocidade;
            if(BarreiraR())
            {
                velocidadex = 0;
            }
            transform.Translate(-velocidadex * Time.deltaTime, 0, 0);
        }

  /*       if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(prefabProjetil) as GameObject;
            go.transform.position = this.transform.position + (this.gameObject.transform.forward * 2.0f);
            go.transform.rotation = this.gameObject.transform.rotation;
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * 100.0f);

        } */
         
       // gameOver(); 


    }

   private bool BarreiraL()
    {
        if (transform.position.x <= barreiraL.transform.position.x)
        {
            return true;
        }
        else {
            return false;
        }
    }
    private bool BarreiraR()
    {
        if (transform.position.x >= barreiraR.transform.position.x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool BarreiraUp()
    {
        if (transform.position.y >= barreiraUp.transform.position.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool BarreiraDown()
    {
        if (transform.position.y <= barreiraDown.transform.position.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="inimigo")
        {

            GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().decrementaVidas();

            /* vidas = vidas - 1;
            Debug.Log("qtd = "+vidas);  */
        }
    }

   /* void gameOver()
    {
        if (vidas <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("TelaFimDeJogo");
        }
    }*/
}
