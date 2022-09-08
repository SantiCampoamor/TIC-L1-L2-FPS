using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agarrarllave : MonoBehaviour
{
    bool pickeado;
    private bool en_rango_obj;
    public bool tienellave;

    // Start is called before the first frame update
    void Start()
    {
        en_rango_obj = false;
        pickeado = false;
        tienellave = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (en_rango_obj)
        {
            if (Input.GetKey(KeyCode.M))
            {
                gameObject.SetActive(false);
                tienellave = true;
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
