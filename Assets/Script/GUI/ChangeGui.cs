using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGui : MonoBehaviour
{
    public Animator m_animator;
    public GameObject CloseObj, OpenObj;
   public void CloseGUI()
    {
        m_animator.SetBool("Close", true);
        StartCoroutine(OpenNewObj());
    }

    IEnumerator OpenNewObj()
    {
        
        yield return new WaitForSeconds(0.55f);
        OpenObj.SetActive(true);
        CloseObj.SetActive(false);
        
    }
}
