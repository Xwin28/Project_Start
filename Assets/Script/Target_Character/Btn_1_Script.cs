using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_1_Script : MonoBehaviour
{
    public Text _text;
    public DialogueManager _dialogueManager;

    public void Choose_1()
    {
        
        int _Next_Position =_dialogueManager._c1[_dialogueManager.Now_position];
        if(_Next_Position!=0)
        _dialogueManager.DisplaySentence(_Next_Position);
    }

    public void Openlv(int a)
    {
        Debug.LogError("NowPosition = " + _dialogueManager.Now_position);
        if(_dialogueManager.Now_position == a)
        {
            SceneManager.LoadScene("testLV");
        }

    }

}
