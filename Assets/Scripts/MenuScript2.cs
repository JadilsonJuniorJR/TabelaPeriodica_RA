using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript2 : MonoBehaviour
{

    public void Iniciar()
    {
        SceneManager.LoadScene("TabelaPeriodicaAR_2");
    }

    public void Sair()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
