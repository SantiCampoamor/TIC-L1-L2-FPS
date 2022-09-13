using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricidadcorriendo : MonoBehaviour
{
    [SerializeField] private GameObject objeto;
    [SerializeField] private GameObject Cajaelectrica;
    private bool tof;
    private bool electricidadcorriendo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tof = objeto.GetComponent<EncenderLuces>().carritoPrendido;
        electricidadcorriendo = Cajaelectrica.GetComponent<EncenderLuces>().carritoPrendido;
        if (Cajaelectrica.GetComponent<EncenderLuces>().carritoPrendido)
        {
            objeto.GetComponent<EncenderLuces>().carritoPrendido = true;
            gameObject.SetActive(false);
        }
           
    }
}
