using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField]GameObject[] sillas;
    // Start is called before the first frame update
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("Silla");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            AgregarRBAElementosDelArray();
            //DesactivarElementosDelArray();
            AgregarColliderElementosDelArray();
        }
    }
    
    void DesactivarElementosDelArray()
    {
        for (int i = 0;i<sillas.Length;i++)
        {
            //sillas[i].SetActive(false);
            sillas[i].AddComponent<Rigidbody>();
        }
    }

    void AgregarRBAElementosDelArray()
    {
        sillas[0].AddComponent<Rigidbody>(); 
    }

    void AgregarColliderElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            //sillas[i].SetActive(false);
            sillas[i].AddComponent<Collider>();
        }
    }
}


