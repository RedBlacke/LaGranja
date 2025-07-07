using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerHuevo : MonoBehaviour
{
    public GameObject huevo;
    public float intervalo = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating(nameof(PonerUnHuevo), intervalo, intervalo); 
    }

       void PonerUnHuevo(){
            Instantiate(huevo, transform.position, Quaternion.identity);
    }
    
}
