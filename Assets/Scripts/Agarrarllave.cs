using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agarrarllave : MonoBehaviour
{
    bool pickeado;
    private bool en_rango_obj;
    public bool tienellave;
    public GameObject data;

    // Start is called before the first frame update
    void Start()
    {
        en_rango_obj = false;
        pickeado = false;
    }

    // Update is called once per frame
    void Update()
    {
        tienellave = data.GetComponent<EncenderLuces>().tienellave;
        if (en_rango_obj && Input.GetKey(KeyCode.M))
        {
            gameObject.SetActive(false);
            data.GetComponent<EncenderLuces>().tienellave = true;
            
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
