using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class chat : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI answer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void send()
    {
        PlayerPrefs.SetString("ask", inputField.text);
    }

    public void setText(string s)
    {
        answer.text = s;
    }
}
