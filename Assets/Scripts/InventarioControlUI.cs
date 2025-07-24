using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventarioControlUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;
    
    void OnEnable(){
         var root = GetComponent<UIDocument>().rootVisualElement;
         labelHuevos = root.Q<Label>("labelHuevos");
         
    }
    
    void Update()
    {
        if(GameManagment.instancia.contadorHuevo != huevosPrevios){
        huevosPrevios = GameManagment.instancia.contadorHuevo;
        labelHuevos.text = $"Huevos: {huevosPrevios}";
        
    }
    
   }
}
