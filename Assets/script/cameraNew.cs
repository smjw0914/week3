using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraNew : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(21.621f, 179.408f, 0f), Time.deltaTime * 1.2f);
    }
}
