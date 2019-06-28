using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;

    
    private void Update(){

        if(Input.GetKey(KeyCode.Escape)){
            isPaused = !isPaused;
        }
        if (isPaused){
            AtivarMenu();
        }
        else {
            DesativarMenu();
        }
    }

    void AtivarMenu()
    {
        AudioListener.pause = true;
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
    }
    public void DesativarMenu()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void sairDoJogo()
    {
        Application.Quit();
    }
}
