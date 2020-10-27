using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllInfor : MonoBehaviour
{

    public static GameObject m_InstanceData;

    private void Awake()
    {

        // Create instance
        if (m_InstanceData == null)
        {
            m_InstanceData = this.gameObject;
        }
        else
        {
            Destroy(gameObject);
            return;

        }
    }



    public bool VolumeMusic;
    public bool VolumeSfx;
    public int Music = 0; // pick music in array
    public string Language = "En";
    public int coin;
    public int coinpersecond;

    [Header("HOUSE")]
    public bool[] Phong_1 = new bool[20];
    public bool[] Phong_2 = new bool[20];
    public bool[] Phong_3 = new bool[20];
    public bool[] Phong_4 = new bool[20];
    public bool[] Phong_5 = new bool[20];
    public bool[] Phong_6 = new bool[20];
    public bool[] Phong_7 = new bool[20];
    public bool[] Phong_8 = new bool[20];
    public bool[] Phong_9 = new bool[20];
    public bool[] Phong_10 = new bool[20];
    public bool[] Phong_11 = new bool[20];
    public bool[] Phong_12 = new bool[20];

    #region getset Block
    ///GET SET
    ///
    //GetPhong
    public bool getPhong_1(int i)
    {
        return Phong_1[i];
    }
    public bool getPhong_2(int i)
    {
        return Phong_2[i];
    }
    public bool getPhong_3(int i)
    {
        return Phong_3[i];
    }
    public bool getPhong_4(int i)
    {
        return Phong_4[i];
    }
    public bool getPhong_5(int i)
    {
        return Phong_5[i];
    }
    public bool getPhong_6(int i)
    {
        return Phong_6[i];
    }
    public bool getPhong_7(int i)
    {
        return Phong_7[i];
    }
    public bool getPhong_8(int i)
    {
        return Phong_8[i];
    }
    public bool getPhong_9(int i)
    {
        return Phong_9[i];
    }
    public bool getPhong_10(int i)
    {
        return Phong_10[i];
    }
    public bool getPhong_11(int i)
    {
        return Phong_11[i];
    }
    public bool getPhong_12(int i)
    {
        return Phong_12[i];
    }

    //GetPhong




    //SET PHONG
    public void SetPhong_1(int i, bool value)
    {
        Phong_1[i] = value;
    }

    public void SetPhong_2(int i, bool value)
    {
        Phong_2[i] = value;
    }
    public void SetPhong_3(int i, bool value)
    {
        Phong_3[i] = value;
    }

    public void SetPhong_4(int i, bool value)
    {
        Phong_4[i] = value;
    }

    public void SetPhong_5(int i, bool value)
    {
        Phong_5[i] = value;
    }

    public void SetPhong_6(int i, bool value)
    {
        Phong_6[i] = value;
    }

    public void SetPhong_7(int i, bool value)
    {
        Phong_7[i] = value;
    }

    public void SetPhong_8(int i, bool value)
    {
        Phong_8[i] = value;
    }

    public void SetPhong_9(int i, bool value)
    {
        Phong_1[i] = value;
    }

    public void SetPhong_10(int i, bool value)
    {
        Phong_10[i] = value;
    }

    public void SetPhong_11(int i, bool value)
    {
        Phong_11[i] = value;
    }

    public void SetPhong_12(int i, bool value)
    {
        Phong_12[i] = value;
    }

    //SET PHONG


    public void setVolumeMusic(bool VolumeMusic)
    {
        this.VolumeMusic = VolumeMusic;
    }

    public void setVolumeSfx(bool VolumeSfx)
    {
        this.VolumeSfx = VolumeSfx;
    }

    public void setMusic(int Music)
    {
        this.Music = Music;
    }

    public void setLanguage(string language)
    {
        this.Language = language;
    }

    public void setCoin(int coin)
    {
        this.coin = coin;
    }

    public void setCoinpersecond(int coinpersecond)
    {
        this.coinpersecond = coinpersecond;
    }


    public bool getVolumeMusic()
    {
        return VolumeMusic;
    }

    public bool getVolumeSfx()
    {
        return VolumeSfx;
    }

    public int getMusic()
    {
        return Music;
    }

    public string getLanguage()
    {
        return Language;
    }

    public int getCoin()
    {
        return coin;
    }

    public int getCoinpersecond()
    {
        return coinpersecond;
    }

    
    ///GET SET
    #endregion 

    public void Start()
    {
        // Load all infor
        Load();
        // Give Infor music + volume + language + Heal, Ammo, Shield, Guns, coin
        StartCoroutine(DelayOpenLevel());
    }

    //Save DATA
    public void Save()
    {
        SAVESYS.SaveDATA(this);
    }

    public void Load()
    {
        InforDATA data = SAVESYS.LoadDATA();
        this.VolumeMusic = data.VolumeMusic;
        this.VolumeSfx = data.VolumeSfx;
        this.Music = data.Music;
        this.Language = data.Language;
        this.coin = data.coin;
        this.coinpersecond = data.coinpersecond;


            this.Phong_1 = data.Phong_1;
            this.Phong_2 = data.Phong_2;
            this.Phong_3 = data.Phong_3;
            this.Phong_4 = data.Phong_4;
            this.Phong_5 = data.Phong_5;
            this.Phong_6 = data.Phong_6;
            this.Phong_7 = data.Phong_7;
            this.Phong_8 = data.Phong_8;
            this.Phong_9 = data.Phong_9;
            this.Phong_10 = data.Phong_10;
            this.Phong_11 = data.Phong_11;
            this.Phong_12 = data.Phong_12;

    }

    public string lv;
    public void Openlevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(lv);
    }
    //Delay Open Level
    public IEnumerator DelayOpenLevel()
    {

        yield return new WaitForSeconds(1f);
        //Openlevel();

    }
}
