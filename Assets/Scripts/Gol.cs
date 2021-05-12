using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public GameController gameController;
    public bool Jogador1SofreuGol;

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ball") == true)
        {
                if(Jogador1SofreuGol)
                {
                    gameController.GolJogador2();
                }    
                else
                {
                    gameController.GolJogador1();
                }
        }
        
    }
}
