using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{

    public Vector2 entrada;
    Rigidbody2D rb;
    public float velocidad = 5f;
    public GameObject trigoPreFab;

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
      
          Vector2 valorEntrada = contexto.ReadValue<Vector2>();

        // Determinar el eje dominante
        if (Mathf.Abs(valorEntrada.x) > Mathf.Abs(valorEntrada.y))
        {
            // Movimiento horizontal
            entrada = new Vector2(Mathf.Sign(valorEntrada.x), 0);
        }
        else if (Mathf.Abs(valorEntrada.y) > 0)
        {
            // Movimiento vertical
            entrada = new Vector2(0, Mathf.Sign(valorEntrada.y));
        }
        else
        {
            entrada = Vector2.zero;
        }
   
        }
        
        
        public void SembrarTrigo(InputAction.CallbackContext contexto){
              if(contexto.started)
              {
                   Instantiate(trigoPreFab , transform.position , Quaternion.identity);
              }
        
        }
}
