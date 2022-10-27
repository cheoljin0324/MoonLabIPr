using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetManager : MonoBehaviour
{
    private const string URL = "https://docs.google.com/spreadsheets/d/1-gP0cWn33NAy7nwtNeRAwouCVxcKAv4vYZENwB7LIOA/export?format=tsv";
    // private const string URL = "https://script.google.com/macros/s/AKfycbw-wn9ykF4riBOtNnZnvs-XXkGflsy14HkdcZL_Vv4gzuzQAYCFR5bCyDUfMr_HWZFk/exec";
    UnityWebRequest www = null;
    string data = string.Empty;

    private IEnumerator Start()
    {
        www = UnityWebRequest.Get(URL);

        yield return www.SendWebRequest();
        data = www.downloadHandler.text;
        Debug.Log(data);

        // www = UnityWebRequest.Post(URL, "aaa");
        // yield return www.SendWebRequest();
        // data = www.downloadHandler.text;
        // Debug.Log(data);
    }

    private IEnumerator Post()
    {
        www = UnityWebRequest.Post(URL, "aaa");
        yield return www.SendWebRequest();
        data = www.downloadHandler.text;
        Debug.Log(data);
    }
}
