using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChamaCena1() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("prefase1");
    }
     
    public void ChamaPrimeiraFase(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("fase1");
    } 
    public void ChamaSegundaFase(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("fase2");
    }
    public void ChamaTerceiraFase(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("fase3");
    }
    public void SairJogo() {
        ///23.90093
        Application.Quit();    
    
     }
}
