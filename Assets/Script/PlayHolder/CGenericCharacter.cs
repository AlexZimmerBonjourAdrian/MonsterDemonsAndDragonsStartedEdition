using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenericCharacter : CCharacterControllers,Iinteractive
{
    // Start is called before the first frame update
    private CDialogueTrigger Dialogue;
    public void Start()
    {
        Dialogue = GetComponent<CDialogueTrigger>();
    }
    public void OnInteractive()
    {
        Debug.Log("Soy un PERSONAJE COMPLEJO");
        Dialogue.TrigerDialogue();
    }
 
}
