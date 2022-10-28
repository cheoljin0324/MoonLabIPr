using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetManager : Singleton<GoogleSheetManager>
{
    private const string URL = "https://script.google.com/macros/s/AKfycbxoiQETAGMY9zMY7_zzCVTHaLqERFFVhDC5bxjnONOMWoZ_4LHIyoiN1AHGP1Jol2Ud/exec";

    // 밑에 3개의 상수는 따로 저장해둬야 될 듯
    const string POST_DATA_KEY = "DATA";
    const string POST_ID_KEY = "ID";

    const string GET_TRAIN_CAR_DATA_VALUE = "GET_TRAIN_CAR_DATA";


    private UnityWebRequest www = null;

    private string data = string.Empty;

    public TrainCarInfo GetData(string dataType, string id)
    {
        WWWForm form = new WWWForm();
        form.AddField(POST_DATA_KEY, dataType);
        form.AddField(POST_ID_KEY, id);

        www = UnityWebRequest.Post(URL, form);
        www.SendWebRequest();

        while (!www.isDone)
        {
            Debug.Log("Waiting...");
        }

        return ParseData(www.downloadHandler.text);
    }

    private void Start()
    {
        WWWForm form = new WWWForm();
        form.AddField(POST_DATA_KEY, GET_TRAIN_CAR_DATA_VALUE);
        form.AddField(POST_ID_KEY, "N_0000");

        www = UnityWebRequest.Post(URL, form);
        www.SendWebRequest();

        while (!www.isDone)
        {
            Debug.Log("Waiting...");
        }

        data = JsonUtility.FromJson(www.downloadHandler.text, typeof(string)).ToString();
        string[] datas = data.Split(',');

        Debug.Log(datas[2]);
    }

    private IEnumerator Post(WWWForm form)
    {
        www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }

    private TrainCarInfo ParseData(string data)
    {
        string[] datas = data.Split(',');
        string id = datas[0];
        string name = datas[1];
        int hp = int.Parse(datas[2]);
        int atk = int.Parse(datas[3]);
        int def = int.Parse(datas[4]);
        int spd = int.Parse(datas[5]);
        int rank = int.Parse(datas[6]);
        int type = int.Parse(datas[7]);
        int skillType = int.Parse(datas[8]);
        int skillAimType = int.Parse(datas[9]);
        bool playerUse = bool.Parse(datas[10]);


        return new TrainCarInfo();
    }
}

//{"id":"N_0000","name":"null","atk":10,"atkSpeed":3,"heavy":10,"health":50,"shotSpeed":10,"skillCool":3,"skillDamage":70,"rank":"Normal","type":"normal","skillType":"Active","skillAimType":"FirstType","playerUse":true}
