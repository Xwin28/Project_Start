using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class AudioPlayer : MonoBehaviour
{


    public AudioClip[] clips;


    public bool randomizePitch = false;
    public float pitchRange = 0.2f;

    protected AudioSource m_Source;


    private void Awake()
    {

        m_Source = GetComponent<AudioSource>();
       
    }




    // Fade in MUSIC
    public IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = targetVolume - 0.5f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

    //Fade Out
    public IEnumerator StartFadeOut(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = targetVolume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, 0, currentTime / duration);
            yield return null;
        }
        audioSource.Stop();
        yield break;
    }

    public void FadeOutMusic()
    {
        if (m_Source.isPlaying)
        {
            GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
            bool m_music = allinfor.GetComponent<AllInfor>().getVolumeMusic();
            float tempM = 1;
            if (m_music)
            {
                tempM = 1;
            }
            else
            {
                tempM = 0;
            }

            StartCoroutine(StartFadeOut(m_Source, 2, tempM));

        }
    }


    public void Playmusic(int i)
    {
        m_Source.Stop();
        AudioClip[] temp = clips;
        if (i < temp.Length)
        {
            GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
            bool m_music = allinfor.GetComponent<AllInfor>().getVolumeMusic();
            float tempM = 1;
            if (m_music)
            {
                tempM = 1;
            }
            else
            {
                tempM = 0;
            }
            StartCoroutine(StartFade(m_Source, 3, tempM));
            //m_Source.loop = true;
            m_Source.clip = temp[i];
            m_Source.Play(0);
        }

    }


    //dừng các âm thanh khác và Bật âm thanh 1 lần
    public void S_Playsfx(int i)
    {
        AudioClip[] temp = clips;
        if( i < temp.Length)
        {
            m_Source.Stop();
            if (randomizePitch)
                m_Source.pitch = Random.Range(1.0f - pitchRange, 1.0f + pitchRange);
            m_Source.PlayOneShot(temp[i]);
        }
    }


    //Bật âm thanh 1 lần
    public void Playsfx(int i)
    {
        AudioClip[] temp = clips;
        if (i < temp.Length)
        {
            if (randomizePitch)
                m_Source.pitch = Random.Range(1.0f - pitchRange, 1.0f + pitchRange);
            m_Source.PlayOneShot(temp[i]);
        }


    }



    public void Stop()
    {
        m_Source.Stop();
    }
}

