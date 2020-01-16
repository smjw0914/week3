using System.Collections;
using System.Collections.Generic;
//using System.Web.Script.Serialization;
using UnityEngine;
using System;
using UnityEngine.Networking;
using JsonData;
using UnityEngine.UI;
using TMPro;


//using Google.Apis.Dialogflow.v2;

public class DialogflowAPIScript : MonoBehaviour {
    public TextMeshProUGUI answerText;

    // Use this for initialization
    void Start () {
        // AccessToken is being generated manually in terminal
        //StartCoroutine(GetAgent(""));

        //https://stackoverflow.com/questions/51272889/unable-to-send-post-request-to-dialogflow-404
        //first param is the dialogflow API call, second param is Json web token
        StartCoroutine(PostRequest("https://dialogflow.googleapis.com/v2/projects/simsim-oyqqfs/agent/sessions/34563:detectIntent",
                              "ya29.c.Kl65B19KxGpFyuwiymZ6LUt_b-HCaWT4KRb47QnWYID3NUcUIPT8m8m8xjQ5OiKIfFZmb28Da4kw7UnVz3QE5cPZSxyAy_C-PqU52iwEC0U60RVw47KmUb_jIavNr2K3"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator PostRequest(String url, String AccessToken){
        UnityWebRequest postRequest = new UnityWebRequest(url, "POST");
        RequestBody requestBody = new RequestBody();
        string answer = PlayerPrefs.GetString("ask");
        Debug.Log("111111111111111" + answer);
        requestBody.queryInput = new QueryInput();
        requestBody.queryInput.text = new TextInput();
        //requestBody.queryInput.text.text = GameObject.Find("Canvas").GetComponent<chat>().send();
        requestBody.queryInput.text.text = answer;
        requestBody.queryInput.text.languageCode = "en";

        string jsonRequestBody = JsonUtility.ToJson(requestBody,true);
        Debug.Log(jsonRequestBody);

        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonRequestBody);
       //Debug.Log(bodyRaw);
        postRequest.SetRequestHeader("Authorization", "Bearer " + AccessToken);
        postRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        postRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        //postRequest.SetRequestHeader("Content-Type", "application/json");

        yield return postRequest.SendWebRequest();

        if(postRequest.isNetworkError || postRequest.isHttpError)
        {
            Debug.Log(postRequest.responseCode);
            Debug.Log(postRequest.error);
        }
        else
        {
            // Show results as text
            Debug.Log("Response: " + postRequest.downloadHandler.text);
            answerText.text = postRequest.downloadHandler.text;
            //var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(postRequest.downloadHandler.text);

            // Debug.Log("Response: " + JSONObj["fulfillmentText"]);

            //GameObject.Find("Canvas").GetComponent<chat>().setText(postRequest.downloadHandler.text);
            //users = JsonConvert.DeserializeObject<PeopleList>(response.SelectToken("data"))

            // Or retrieve results as binary data
            byte[] results = postRequest.downloadHandler.data;
        }
    }
    IEnumerator GetAgent(String AccessToken)
    {

        UnityWebRequest www = UnityWebRequest.Get("https://dialogflow.googleapis.com/v2/projects/simsim-oyqqfs/agent");
        www.SetRequestHeader("Authorization", "Bearer " + AccessToken);

        yield return www.SendWebRequest();
        //myHttpWebRequest.PreAuthenticate = true;
        //myHttpWebRequest.Headers.Add("Authorization", "Bearer " + AccessToken);
        //myHttpWebRequest.Accept = "application/json";

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);

            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }
}