using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropNET : MonoBehaviour
{
    public GameObject compu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollissionEnter(Collision col)
    {
        if (col.gameObject.name == "FPSController" & Input.GetKeyDown(KeyCode.N))
        {
            Instantiate (compu);
        }
    }
}
