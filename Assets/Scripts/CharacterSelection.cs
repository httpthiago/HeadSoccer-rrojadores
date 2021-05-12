using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] listaPersonagens;

    public Text player1_nome;
    private int index; 



    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("personagemSelecionado");
        player1_nome.text = PlayerPrefs.GetString("nomeJogador1");
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

        if (listaPersonagens[index])
        {
            listaPersonagens[index].SetActive(true);
        }
    }

    public void Anterior()
    {
        //desativar o personagem atual da tela
        listaPersonagens[index].SetActive(false);
        index--;

        if (index < 0)
        {
            index = listaPersonagens.Length - 1;
        }

        switch (index)
        {
            
            case 0:
            player1_nome.text = "Thiago";
            break;
             case 1:
            player1_nome.text = "Maicon";
            break;
             case 2:
            player1_nome.text = "Vitorio";
            break;
             case 3:
            player1_nome.text = "Wendell";
            break;
             case 4:
            player1_nome.text = "Renan";
            break;
        }

        listaPersonagens[index].SetActive(true);
    }

    public void Proximo()
    {
        listaPersonagens[index].SetActive(false);
        index++;

        if (index == listaPersonagens.Length)
        {
            index = 0;
        }

        switch (index)
        {
            
            case 0:
            player1_nome.text = "Thiago";
            break;
             case 1:
            player1_nome.text = "Maicon";
            break;
             case 2:
            player1_nome.text = "Vitorio";
            break;
             case 3:
            player1_nome.text = "Wendell";
            break;
             case 4:
            player1_nome.text = "Renan";
            break;
        }

        listaPersonagens[index].SetActive(true);
    }



    public void Confirmar()
    {
        PlayerPrefs.SetInt("personagemSelecionado", index);
        PlayerPrefs.SetString("nomeJogador1", player1_nome.text);
        SceneManager.LoadScene("Game");
    }
}
