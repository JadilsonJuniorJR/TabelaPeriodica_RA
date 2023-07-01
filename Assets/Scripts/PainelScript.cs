using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class PainelScript : MonoBehaviour
{
    //[SerializeField] private string Cena;
    [SerializeField] private GameObject PainelPausa;
    [SerializeField] private GameObject CarregarMenu;
    public void Pausar()
    {
       
        //Time.timeScale = 0f;
        VuforiaBehaviour.Instance.enabled = false;
        PainelPausa.SetActive(true);
        
    }

    public void FecharPausar()
    {
        PainelPausa.SetActive(false);
        VuforiaBehaviour.Instance.enabled = true;
    }

    public void Instrucoes()
    {
        SceneManager.LoadScene("Instrucoes");
    }

    public void RetornarMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
        Debug.Log("Sair do Jogo");
       
       
    }
}
