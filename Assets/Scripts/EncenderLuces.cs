using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncenderLuces : MonoBehaviour
{
    [SerializeField] private GameObject Dialogo1;
    [SerializeField] private GameObject Dialogo2;
    [SerializeField] private GameObject objetoROJO;
    [SerializeField] private GameObject objetoVERDE;
    private bool en_rango_obj;
    public bool tienellave;
    public bool correzapzap;
    public bool carritoPrendido;

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
    if (correzapzap == true)
        {
            objetoROJO.SetActive(false);
            objetoVERDE.SetActive(true);
            carritoPrendido = true;
        }
        if (carritoPrendido == true)
        {
            Dialogo1.SetActive(false);
            Dialogo2.SetActive(true);
        }
        else if (carritoPrendido == false)
        {
            Dialogo1.SetActive(true);
            Dialogo2.SetActive(false);
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
