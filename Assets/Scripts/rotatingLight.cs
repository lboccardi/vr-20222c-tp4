using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,-Time.deltaTime * 360f,0);
    }
}
