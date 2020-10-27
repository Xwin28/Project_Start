using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLanguage : MonoBehaviour
{
    public void SetEnglish()
    {
        AllInfor m_allinfor = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        m_allinfor.setLanguage("En");
        I18n.updataLangages();
    }


    public void SetVietnamese()
    {
        AllInfor m_allinfor = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        m_allinfor.setLanguage("Vn");
        I18n.updataLangages();
    }

}
