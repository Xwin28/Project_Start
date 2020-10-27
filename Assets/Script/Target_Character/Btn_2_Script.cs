using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_2_Script : MonoBehaviour
{
    public Text _text;
    public DialogueManager _dialogueManager;

    public void Choose_2()
    {
        int _Next_Position = _dialogueManager._c2[_dialogueManager.Now_position];
        _dialogueManager.DisplaySentence(_Next_Position);
    }
}
