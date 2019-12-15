using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenericCharacter : CCharacterControllers,Iinteractive
{
    // Start is called before the first frame update

    public void OnInteractive()
    {
        Debug.Log("Soy un PERSONAJE COMPLEJO");
    }
 
}
