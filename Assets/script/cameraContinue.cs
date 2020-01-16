using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraContinue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(12.386f, 162.16f, -7.43f), Time.deltaTime * 1.2f);
    }
}
