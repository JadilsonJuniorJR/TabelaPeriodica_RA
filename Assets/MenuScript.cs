using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    //[SerializeField] private string CarregarCena;
    //[SerializeField] private GameObject painelMenuInicial;


    public void Iniciar()
    {
        SceneManager.LoadScene("TabelaPeriodicaAR");
    }

    public void Sair()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
