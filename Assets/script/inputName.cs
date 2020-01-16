using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inputName : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        PlayerPrefs.SetString("Name", inputField.text);
    }

    public void Load()
    {
        name.text = PlayerPrefs.GetString("Name");
    }
}
