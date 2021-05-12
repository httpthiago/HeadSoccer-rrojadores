using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveLogo : MonoBehaviour
{
    

   private void Start() {
        moveLogo();
    }

    public void moveLogo ()
    {
        transform.LeanMoveLocal(new Vector2(0, 0), 9);
    }
}
