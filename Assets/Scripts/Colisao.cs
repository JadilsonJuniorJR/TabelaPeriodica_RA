using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Colisao : MonoBehaviour
{

    public GameObject ImageTarget_1; // Referência à ImageTarget "Helio"
    public GameObject ImageTarget_2; // Referência à ImageTarget "Hidrogenio"
    public GameObject novoElemento; // Referência ao objeto "Cubo"

    public GameObject AtomoIT1;
    public GameObject AtomoIT2;

    private bool colidindo = false; // Flag para rastrear se há colisão

    private void Update()
    {
        // Verifica se as ImageTargets estão colidindo
        
         if (colidindo)
         {
            AtomoIT1.SetActive(false); // Oculta o objeto da ImageTarget "Helio"
            AtomoIT2.SetActive(false); // Oculta o objeto da ImageTarget "Hidrogenio"
             novoElemento.SetActive(true); // Ativa o objeto "Cubo"
             Debug.Log("Ativa Cubo");

         }
         else
         {
            AtomoIT1.SetActive(true); // Ativa o objeto da ImageTarget "Helio"
            AtomoIT2.SetActive(true); // Ativa o objeto da ImageTarget "Hidrogenio"
             novoElemento.SetActive(false); // Oculta o objeto "Cubo"
             Debug.Log("Desativa Cubo");
         }

        /*
    {
        // Verifica se as ImageTargets estão colidindo
        if (colidindo)
        {
            helioImageTarget.GetComponent<Renderer>().enabled = false; // Oculta o renderer do objeto da ImageTarget "Helio"
            hidrogenioImageTarget.GetComponent<Renderer>().enabled = false; // Oculta o renderer do objeto da ImageTarget "Hidrogenio"
            cuboObjeto.SetActive(true); // Ativa o objeto "Cubo"
            Debug.Log("Ativa Cubo");
        }
        else
        {
            helioImageTarget.GetComponent<Renderer>().enabled = true; // Ativa o renderer do objeto da ImageTarget "Helio"
            hidrogenioImageTarget.GetComponent<Renderer>().enabled = true; // Ativa o renderer do objeto da ImageTarget "Hidrogenio"
            cuboObjeto.SetActive(false); // Oculta o objeto "Cubo"
            Debug.Log("Desativa Cubo");
        }
    }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ImageTarget_1 || other.gameObject == ImageTarget_2)
        {
            colidindo = true; // Ativa a flag de colisão
            Debug.Log("Detecta Colisao");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == ImageTarget_1 || other.gameObject == ImageTarget_2)
        {
            colidindo = true; // Mantém a flag de colisão ativada enquanto a colisão persistir
            Debug.Log("continua Colisao");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == ImageTarget_1 || other.gameObject == ImageTarget_2)
        {
            colidindo = false; // Desativa a flag de colisão
            Debug.Log("Saiu Colisao");
        }
    }
}
