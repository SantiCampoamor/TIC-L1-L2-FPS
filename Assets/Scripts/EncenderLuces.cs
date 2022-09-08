using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderLuces : MonoBehaviour
{
    private bool en_rango_obj;
    PlayerSO data;
    // Start is called before the first frame update
    void Start()
    {
        data.tienellave = false;
    }

    // Update is called once per frame
    void Update()
    {
    if (en_rango_obj == true && data.tienellave == true)
        {
            if (Input.GetKey(KeyCode.M))
            {
                gameObject.SetActive(false);
                data.correzapzap = true;
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
