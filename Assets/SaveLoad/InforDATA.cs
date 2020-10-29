using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class InforDATA
{
    public bool VolumeMusic;
    public bool VolumeSfx;
    public int m_Quality;//0 = low, 1 = medium, 2=high
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


    public InforDATA()
    {
        //System Infor
        VolumeMusic = true;
        VolumeSfx = false;
        m_Quality = 1;
        Language = "En";
        //COIN
        coin = 0;
        coinpersecond = 0;

        //Do các mảng bằng nhau nên for 1 lần
        for( int i = 0; i<Phong_1.Length;i++)
        {
            Phong_1[i] = false;
            Phong_2[i] = false;
            Phong_3[i] = false;
            Phong_4[i] = false;
            Phong_5[i] = false;
            Phong_6[i] = false;
            Phong_7[i] = false;
            Phong_8[i] = false;
            Phong_9[i] = false;
            Phong_10[i] = false;
            Phong_11[i] = false;
            Phong_12[i] = false;
        }
       
    }

    public InforDATA(AllInfor _allInfor)
    {
        //System Infor
        VolumeMusic = _allInfor.VolumeMusic;
        VolumeSfx = _allInfor.VolumeSfx;
        m_Quality = _allInfor.Quality;
        Language = _allInfor.Language;
        //COIN
        coin = _allInfor.coin;
        coinpersecond = _allInfor.coinpersecond;

        Phong_1 = _allInfor.Phong_1;
        Phong_2 = _allInfor.Phong_2;
        Phong_3 = _allInfor.Phong_3;
        Phong_4 = _allInfor.Phong_4;
        Phong_5 = _allInfor.Phong_5;
        Phong_6 = _allInfor.Phong_6;
        Phong_7 = _allInfor.Phong_7;
        Phong_8 = _allInfor.Phong_8;
        Phong_9 = _allInfor.Phong_9;
        Phong_10 = _allInfor.Phong_10;
        Phong_11 = _allInfor.Phong_11;
        Phong_12 = _allInfor.Phong_12;

    }
}
