using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolAudio : MonoBehaviour
{
    public AudioMixer mixer;
    public Sprite m_On, m_Off;
    private Image m_ButtonImage;
    public bool m_IsMusic;

    private void Awake()
    {
        m_ButtonImage = gameObject.GetComponent<Image>();

    }



    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        bool Musicvol = true;
        if (m_IsMusic)
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
        if (m_IsMusic)
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

    public void ToggleMusic()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        bool m_musicVol = objs.GetComponent<AllInfor>().getVolumeMusic();
        if(m_musicVol)
        {
            TurnOff_music(objs);
            
        }
        else
        {
            TurnOn_music(objs);
        }
    }

    public void ToggleSFX()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        bool m_SFXVol = objs.GetComponent<AllInfor>().getVolumeSfx();
        if (m_SFXVol)
        {
            TurnOff_Sfx(objs);

        }
        else
        {
            TurnOn_Sfx(objs);
        }
    }





    public void TurnOn_music(GameObject objs)
    {
        mixer.SetFloat("MusicVol", -2);
        m_ButtonImage.sprite = m_On;
        objs.GetComponent<AllInfor>().setVolumeMusic(true);
    }

    public void TurnOff_music(GameObject objs)
    {
        mixer.SetFloat("MusicVol", -80);
        m_ButtonImage.sprite = m_Off;
        objs.GetComponent<AllInfor>().setVolumeMusic(false);
    }

    public void TurnOn_Sfx(GameObject objs)
    {
        mixer.SetFloat("SfxVol", 0);
        m_ButtonImage.sprite = m_On;
        objs.GetComponent<AllInfor>().setVolumeSfx(true);
    }

    public void TurnOff_Sfx(GameObject objs)
    {
        mixer.SetFloat("SfxVol", -80);
        m_ButtonImage.sprite = m_Off;
        objs.GetComponent<AllInfor>().setVolumeSfx(false);
    }
}
