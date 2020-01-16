using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(24.838f, 160.384f, -8f), Time.deltaTime * 1.2f);
    }
}
