using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolUIBegin : MonoBehaviour
{

    // This Class just Set UI Volume
    private Image m_ButtonImage;
    public Sprite m_On, m_Off;
    [Header("true is music, false is SFX")]
    public bool IsMusic;// true is music, false is SFX
    // Start is called before the first frame update
    private void Awake()
    {
        m_ButtonImage = gameObject.GetComponent<Image>();
    }
    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        bool Musicvol = true;
        if (IsMusic)
        {
            Musicvol = objs.GetComponent<AllInfor>().getVolumeMusic();
        }
        else
        {
            Musicvol = objs.GetComponent<AllInfor>().getVolumeSfx();
        }


        if (Musicvol)
        {
            m_ButtonImage.sprite = m_On;
        }
        else
        {
            m_ButtonImage.sprite = m_Off;
        }
    }

    private void OnEnable()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        bool Musicvol = true;
        if (IsMusic)
        {
            Musicvol = objs.GetComponent<AllInfor>().getVolumeMusic();
        }
        else
        {
            Musicvol = objs.GetComponent<AllInfor>().getVolumeSfx();
        }


        if (Musicvol)
        {
            m_ButtonImage.sprite = m_On;
        }
        else
        {
            m_ButtonImage.sprite = m_Off;
        }
    }

}
