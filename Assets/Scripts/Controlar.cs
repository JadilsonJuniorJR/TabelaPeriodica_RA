using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlar : MonoBehaviour
{
    public GameObject controlar;

    public void mostrar()
    {
        controlar.SetActive(true);
    }

    public void esconder()
    {
        controlar.SetActive(false);
    }
}
