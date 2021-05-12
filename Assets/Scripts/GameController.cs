using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [Header("Bola")]
    public Ball bola;

    [Header("Jogador 1")]
    public GameObject Jogador1;
    public GameObject Gol1;

    [Header("Jogador 2")]
    public GameObject Jogador2;
    public GameObject Gol2;

    [Header("Interface")]

    public Text textoPontuacaoJogador1;
    public Text textoPontuacaoJogador2;

    public int PontuacaoVitoria = 10;

    private int PontuacaoJogador1=0;
    private int PontuacaoJogador2=0;

    
    private void ResetarPosicao()
    {
        bola.ResetPosition();
    }

    public void GolJogador1()
    {
        PontuacaoJogador1++;
        textoPontuacaoJogador1.text = PontuacaoJogador1.ToString();
        ResetarPosicao();

        if (PontuacaoJogador1 == PontuacaoVitoria)
        {
            //carregar painel UI/Cena vitoria jogador1
        }
    }
    
    public void GolJogador2()
    {
        PontuacaoJogador2++;
        textoPontuacaoJogador2.text = PontuacaoJogador2.ToString();
        ResetarPosicao();

        if (PontuacaoJogador2 == PontuacaoVitoria)
        {
            //carregar painel UI/Cena vitoria jogador2
        }
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}
