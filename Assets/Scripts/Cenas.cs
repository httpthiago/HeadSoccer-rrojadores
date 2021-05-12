using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{

    public void CarregarNovaCena(string nome)
    {
        SceneManager.LoadScene(nome);
    }
}
