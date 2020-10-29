using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingGraphic : MonoBehaviour
{
    [Header("0 = low, 1 = medium, 2=high")]
    public int m_Quality;
    [Header("Run Start or not")]
    public bool m_IsrunStart;
    private Image m_ButtonImage;
    

    private void Start()
    {
        if(m_IsrunStart)
        {
            if (gameObject.GetComponent<Image>() != null)
            {
                m_ButtonImage = gameObject.GetComponent<Image>();
                AllInfor all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
                switch (all.Quality)
                {
                    case 4:
                        Debug.LogError("White");
                        m_ButtonImage.color = new Color32(255, 255, 255, 255);
                        break;
                    case 2:
                        Debug.LogError("Yellow");
                        m_ButtonImage.color = new Color32(241, 255, 0, 255);
                        break;
                    case 0:
                        Debug.LogError("Green");
                        m_ButtonImage.color = new Color32(6, 255, 0, 255);
                        break;
                }
            }
        }
    }

    private void OnEnable()
    {
        if (m_IsrunStart)
        {
            if (gameObject.GetComponent<Image>() != null)
            {
                m_ButtonImage = gameObject.GetComponent<Image>();
                AllInfor all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
                switch (all.Quality)
                {
                    case 4:
                        Debug.LogError("White");
                        m_ButtonImage.color = new Color32(255, 255, 255, 255);
                        break;
                    case 2:
                        Debug.LogError("Yellow");
                        m_ButtonImage.color = new Color32(241, 255, 0, 255);
                        break;
                    case 0:
                        Debug.LogError("Green");
                        m_ButtonImage.color = new Color32(6, 255, 0, 255);
                        break;
                }
            }
        }
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(m_Quality);
        AllInfor all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        all.Quality = QualitySettings.GetQualityLevel();
    }    
}
