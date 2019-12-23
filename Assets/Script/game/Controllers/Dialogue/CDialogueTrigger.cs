using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDialogueTrigger : MonoBehaviour
{
    public CDialogue _Dialogue;
    // Start is called before the first frame update
  public void TrigerDialogue()
    {
        FindObjectOfType<CDialogueManager>().StartDialogue(_Dialogue);
    }
}
