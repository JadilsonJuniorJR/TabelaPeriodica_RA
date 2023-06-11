using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PainelScript : MonoBehaviour
{
    //[SerializeField] private string Cena;
    [SerializeField] private GameObject PainelPausa;
    [SerializeField] private GameObject CarregarMenu;
    public void Pausar()
    {
       PainelPausa.SetActive(true);
    }

    public void FecharPausar()
    {
        PainelPausa.SetActive(false);
    }

    public void RetornarMenu()
    {
        Debug.Log("Sair do Jogo");
       
        SceneManager.LoadScene("MenuPrincipal");
    }
}
