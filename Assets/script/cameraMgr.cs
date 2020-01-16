using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cameraMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveNewStart()
    {
        // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(21.621f, 179.408f, 0f), Time.deltaTime * 1.2f);
        transform.rotation = Quaternion.Euler(25.888f, 172.762f, -2.681f);
    }

    public void moveEnter()
    {
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(24.838f, 160.384f, -8f), Time.deltaTime * 1.2f);
        transform.rotation = Quaternion.Euler(24.838f, 160.384f, -8f);
    }

    public void moveContinue()
    {
        transform.rotation = Quaternion.Euler(12.386f, 162.16f, -7.43f);
    }
}
