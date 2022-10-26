using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetManager : MonoBehaviour
{
    private const string URL = "https://docs.google.com/spreadsheets/d/1-gP0cWn33NAy7nwtNeRAwouCVxcKAv4vYZENwB7LIOA/";

    private void Start()
    {
        StartCoroutine(GetData());
    }

    private IEnumerator GetData()
    {
        UnityWebRequest request = UnityWebRequest.Get(URL);
        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
        }
    }
}
