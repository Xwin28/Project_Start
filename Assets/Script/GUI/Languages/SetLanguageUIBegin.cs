
using UnityEngine;
using UnityEngine.UI;

public class SetLanguageUIBegin : MonoBehaviour
{
    // This Class just Set UI Volume
    private Image m_ButtonImage;
    public Sprite m_En, m_Vn;


    // Start is called before the first frame update
    private void Awake()
    {
        m_ButtonImage = gameObject.GetComponent<Image>();
    }
    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");

        string TempLang = objs.GetComponent<AllInfor>().getLanguage();


        if (TempLang == "En")
        {
            m_ButtonImage.sprite = m_En;
        }
        else if (TempLang == "Vn")
        {
            m_ButtonImage.sprite = m_Vn;
        }
    }

    private void OnEnable()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");

        string TempLang = objs.GetComponent<AllInfor>().getLanguage();


        if (TempLang == "En")
        {
            m_ButtonImage.sprite = m_En;
        }
        else if (TempLang == "Vn")
        {
            m_ButtonImage.sprite = m_Vn;
        }

    }
}
