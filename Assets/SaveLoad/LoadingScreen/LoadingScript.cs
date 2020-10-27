using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    public GameObject m_LoadingScene;
    public Slider m_SliderLoading;
    public Text m_textLoading;

    public void LoadLevel(int SceneIndex)
    {
        StartCoroutine(LoadAsyn(SceneIndex));
    }

    IEnumerator LoadAsyn(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        m_LoadingScene.SetActive(true);
        while(!operation.isDone)
        {
            float _process = Mathf.Clamp01(operation.progress / 0.9f);
            m_SliderLoading.value = _process;
            m_textLoading.text = _process * 100f + "%";
            Debug.Log(m_textLoading.text);
            yield return null;
        }
    }
}
