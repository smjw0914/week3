using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class setting : MonoBehaviour
{
    public GameObject newStartBtn;
    public GameObject ContinueBtn;
    public GameObject EnterBtn;
    public GameObject inputField;
    public GameObject welcome;
    public GameObject name;
    public GameObject START;

    void Awake()

    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1440, 2560, true);
    }


    // Start is called before the first frame update
    void Start()
    {
        EnterBtn.SetActive(false);
        inputField.SetActive(false);
        welcome.SetActive(false);
        name.SetActive(false);
        START.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickNewStart()
    {
        newStartBtn.SetActive(false);
        ContinueBtn.SetActive(false);
        inputField.SetActive(true);
        EnterBtn.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<cameraMgr>().moveNewStart();
       // GameObject.Find("Main Camera").GetComponent<cameraNew>();
    }

    public void clickContinue()
    {
        welcome.SetActive(true);
        name.SetActive(true);
        START.SetActive(true);
        newStartBtn.SetActive(false);
        ContinueBtn.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<cameraMgr>().moveContinue();
        //GameObject.Find("Main Camera").GetComponent<cameraContinue>();
        GameObject.Find("Canvas").GetComponent<inputName>().Load();
    }

    public void clickEnter()
    {
        GameObject.Find("Canvas").GetComponent<inputName>().Save();
        inputField.SetActive(false);
        EnterBtn.SetActive(false);
        newStartBtn.SetActive(true);
        ContinueBtn.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<cameraMgr>().moveEnter();
        //GameObject.Find("Main Camera").GetComponent<cameraEnter>();
        Debug.Log(PlayerPrefs.GetString("Name"));
    }
}
