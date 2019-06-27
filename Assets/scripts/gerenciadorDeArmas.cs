using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerenciadorDeArmas : MonoBehaviour{
}

public interface Arma{
    void atirar();
}

public class AtiraHalter1: MonoBehaviour, Arma{
    public void atirar(){
        Vector3 posicaoArma = this.gameObject.transform.position;
        Vector3 posicaoHalter2 = posicaoArma + Vector3.forward*1f;
        GameObject halter1 = Instantiate (Resources.Load("Halter1", typeof(GameObject))) 
        as GameObject;
        halter1.transform.position = posicaoHalter2;
        halter1.GetComponent<Rigidbody>().AddForce(Vector3.right*3000f);
    }
}

public class AtiraHalter2: MonoBehaviour, Arma{
    public void atirar(){
        Vector3 posicaoArma = this.gameObject.transform.position;
        Vector3 posicaoHalter2 = posicaoArma + Vector3.forward*1f;
        GameObject halter2 = Instantiate (Resources.Load("Halter2", typeof(GameObject))) 
        as GameObject;
        halter2.transform.position = posicaoHalter2;
        halter2.GetComponent<Rigidbody>().AddForce(Vector3.right*1200f);
    }
}
