
using UnityEngine;
using UnityEngine.Audio;

public class Ctrl_VolBegin : MonoBehaviour
{
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        // Đặt lại âm lượng khi vào game
        GameObject objs = GameObject.FindGameObjectWithTag("DATA");
        bool volMusic = objs.GetComponent<AllInfor>().getVolumeMusic();
        bool volSfx = objs.GetComponent<AllInfor>().getVolumeSfx();
        #region SetMusic Vol
        if (volMusic)
        {
            mixer.SetFloat("MusicVol", 0);
        }
        else
        {
            mixer.SetFloat("MusicVol", -80);
        }
        #endregion

        #region SetSFX Vol
        if (volSfx)
        {
            mixer.SetFloat("SfxVol", 0);
        }
        else
        {
            mixer.SetFloat("SfxVol", -80);
        }
        #endregion



    }
}
