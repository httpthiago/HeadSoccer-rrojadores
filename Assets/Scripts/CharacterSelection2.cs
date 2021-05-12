using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection2 : MonoBehaviour
{
    private GameObject[] listaPersonagens;
    private int index1;

    public Text player2_nome;



    // Start is called before the first frame update
    void Start()
    {
        index1 = PlayerPrefs.GetInt("personagemSelecionado2");
        player2_nome.text = PlayerPrefs.GetString("nomeJogador2");
        listaPersonagens = new GameObject[transform.childCount];

        //preencher o array com os objetos dos personagens:

        for (int i = 0; i < transform.childCount; i++)
        {
            listaPersonagens[i] = transform.GetChild(i).gameObject;
        }

        //desativar todos os game objects (personagens) da vizualização do player

        foreach (GameObject go in listaPersonagens)
        {
            go.SetActive(false);
        }

        //se o index for 0, ativará na tela de vizualização:

        if (listaPersonagens[index1])
        {
            listaPersonagens[index1].SetActive(true);
        }
    }

    public void Anterior1()
    {
        //desativar o personagem atual da tela
        listaPersonagens[index1].SetActive(false);
        index1--;

        if (index1 < 0)
        {
            index1 = listaPersonagens.Length - 1;
        }

        switch (index1)
        {
            
            case 0:
            player2_nome.text = "Thiago";
            break;
             case 1:
            player2_nome.text = "Maicon";
            break;
             case 2:
            player2_nome.text = "Vitorio";
            break;
             case 3:
            player2_nome.text = "Wendell";
            break;
             case 4:
            player2_nome.text = "Renan";
            break;
        }

        listaPersonagens[index1].SetActive(true);
    }

    public void Proximo1()
    {
        listaPersonagens[index1].SetActive(false);
        index1++;

        if (index1 == listaPersonagens.Length)
        {
            index1 = 0;
        }

        switch (index1)
        {
            
            case 0:
            player2_nome.text = "Thiago";
            break;
             case 1:
            player2_nome.text = "Maicon";
            break;
             case 2:
            player2_nome.text = "Vitorio";
            break;
             case 3:
            player2_nome.text = "Wendell";
            break;
             case 4:
            player2_nome.text = "Renan";
            break;
        }

        listaPersonagens[index1].SetActive(true);
    }

    public void Confirmar1()
    {
        PlayerPrefs.SetInt("personagemSelecionado2", index1);
        PlayerPrefs.SetString("nomeJogador2", player2_nome.text);
        SceneManager.LoadScene("Game");
    }

   
    
   
}
