using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;


public class GoogleSheetManager : Singleton<GoogleSheetManager>
{
    private const string URL = "https://script.google.com/macros/s/AKfycbxoiQETAGMY9zMY7_zzCVTHaLqERFFVhDC5bxjnONOMWoZ_4LHIyoiN1AHGP1Jol2Ud/exec";

    // 밑에 3개의 상수는 따로 저장해둬야 될 듯
    const string POST_DATA_KEY = "DATA";
    const string POST_ID_KEY = "ID";
    const string GET_TRAIN_CAR_DATA_VALUE = "GET_TRAIN_CAR_DATA";

    private UnityWebRequest www = null;

    public TrainCarInfo GetDataPost(string dataType, string id)
    {
        WWWForm form = new WWWForm();
        form.AddField(POST_DATA_KEY, dataType);
        form.AddField(POST_ID_KEY, id);

        StartCoroutine(Post(form));

        return ParseData(www.downloadHandler.text);
    }

    private TrainCarInfo ParseData(string data)
    {
        return JsonConvert.DeserializeObject<TrainCarInfo>(data);
    }

    private IEnumerator Post(WWWForm form)
    {
        www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();
    }
}

