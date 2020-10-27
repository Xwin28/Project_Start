
using UnityEngine;



public class SaveSetting : MonoBehaviour
{



    public void SaveData()
    {
        GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().Save();
    }
}
