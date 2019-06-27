using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaFimDeJogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chamarTelaInicial() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TelaInicialScene");
    }

    public void sairJogo()
    {
        Application.Quit(); 
    }
}
