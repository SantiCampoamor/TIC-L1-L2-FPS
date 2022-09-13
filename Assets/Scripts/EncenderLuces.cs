using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderLuces : MonoBehaviour
{
    private bool en_rango_obj;
    public bool tienellave;
    public bool correzapzap;

    // Start is called before the first frame update
    void Start()
    {
        tienellave = false;
        correzapzap = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    if (en_rango_obj && tienellave == true)
        {
            if (Input.GetKey(KeyCode.N))
            {
                gameObject.SetActive(false);
                correzapzap = true;
                Debug.Log("N");
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "PLAYER")
        {
            en_rango_obj = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "PLAYER")
        {
            en_rango_obj = false;
        }
    }
}
