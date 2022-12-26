using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    private string _loadSceneName = null;

    public void LoadScene(string sceneName)
    {
        gameObject.SetActive(true);
        float delay = 0f;
        SceneManager.sceneLoaded += LoadSceneEnd;
        _loadSceneName = sceneName;
        StartCoroutine(Load(sceneName, delay));
    }

    private IEnumerator LoadLoadingScene()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync("LoadingScene");
        op.allowSceneActivation = true;

        while (!op.isDone)
        {
            yield return null;
        }
        yield break;
    }

    private IEnumerator Load(string sceneName, float delay = 0f)
    {
        yield return LoadLoadingScene();
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
        op.allowSceneActivation = false;
        float timer = 0.0f - delay;

        while (timer < 1f)
        {
            yield return null;
            timer += Time.unscaledDeltaTime;
        }
        op.allowSceneActivation = true;

        while (!op.isDone)
        {
            yield return null;
        }

    }

    private void LoadSceneEnd(Scene scene, LoadSceneMode loadSceneMode)
    {
        if (scene.name == _loadSceneName)
        {
            SceneManager.sceneLoaded -= LoadSceneEnd;
        }
    }
}
