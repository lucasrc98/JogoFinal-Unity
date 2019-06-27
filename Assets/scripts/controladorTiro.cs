using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorTiro : MonoBehaviour
{
    // Start is called before the first frame update
           Arma arma;
    void Start()
    {
         arma = gameObject.AddComponent<AtiraHalter1>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            atira();
        }
        if(Input.GetKeyDown(KeyCode.B)){
            //Trocar arma
            //Destruir a arma anterior
            destruiArmaAntiga();
            arma = gameObject.AddComponent<AtiraHalter1> ();
        }
        if(Input.GetKeyDown(KeyCode.C)){
            //Trocar arma
            //Destruir a arma anterior
            destruiArmaAntiga();
            arma = gameObject.AddComponent<AtiraHalter2> ();
        }
        
    }

    void destruiArmaAntiga(){
        Component c = this.gameObject.GetComponent<Arma> () as Component;
        if(c != null){
            Destroy (c);
        }

    }
    void atira(){
        arma.atirar();
    }
}
