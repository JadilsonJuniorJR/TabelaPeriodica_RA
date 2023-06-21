using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instrucoes : MonoBehaviour
{
    // Start is called before the first frame update
    public void Voltar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    // Update is called once per frame
    public void Iniciar()
    {
        SceneManager.LoadScene("TabelaPeriodicaAR_5");
    }
}
