using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetManager : MonoBehaviour
{
    private const string URL = "https://docs.google.com/spreadsheets/d/1-gP0cWn33NAy7nwtNeRAwouCVxcKAv4vYZENwB7LIOA/export?format=tsv";
    UnityWebRequest www = null;
    string data = string.Empty;

    private IEnumerator Start()
    {
        www = UnityWebRequest.Get(URL);
        yield return www.SendWebRequest();
        data = www.downloadHandler.text;
        Debug.Log(data);
    }
}
