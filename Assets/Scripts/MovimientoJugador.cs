using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{

    public Vector2 entrada;
    Rigidbody2D rb;
    public float velocidad = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = velocidad * entrada; 
    }
    
      public void Movimiento(InputAction.CallbackContext contexto){
            
            
            entrada = contexto.ReadValue<Vector2>();  
             Debug.Log("Contexto " + entrada);
    }
}
