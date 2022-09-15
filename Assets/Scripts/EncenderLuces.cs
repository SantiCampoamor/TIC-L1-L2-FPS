using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncenderLuces : MonoBehaviour
{
    [SerializeField] private GameObject Dialogo1;
    [SerializeField] private GameObject Dialogo2;
    [SerializeField] private GameObject MisionDialogo0;
    [SerializeField] private GameObject MisionDialogo1;
    [SerializeField] private GameObject MisionDialogo2;
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
        MisionDialogo0.SetActive(true); 
        MisionDialogo1.SetActive(false);
        MisionDialogo2.SetActive(false);
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
    if (tienellave == true)
        {
            MisionDialogo2.SetActive(true);
            MisionDialogo1.SetActive(false);

        }
    if (correzapzap == true)
        {
            objetoROJO.SetActive(false);
            objetoVERDE.SetActive(true);
            carritoPrendido = true;
            MisionDialogo2.SetActive(false);
        }
        if (carritoPrendido == true)
        {
            Dialogo1.SetActive(false);
            Dialogo2.SetActive(true);
            MisionDialogo0.SetActive(true); 
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
