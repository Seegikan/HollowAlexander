//using - Librerias - Funciones prestadas de otros scripts 
using UnityEngine;


//Public - Da persmiso de usar su informacion 
//class - forma de declararla 
//MovementPlayer - Nombre del Script
// : - Herencia, permite usar las funciones y variables de  MonoBehaviour
public class MovementPlayer : MonoBehaviour
{
    //Variables 


    // donde empieza el Frame 1. Frame 2 dejo de llamarse 
    void Start()
    {
        print("Start inicia aqui");

    }//end Start


    // Desde Frame 2 hasta que termine el juego
    //Loop que se llama toooodo el tiempo 
    //Funciona mejor o peor dependiente de la PC, no tiene la
    void Update()
    {
        print("Update inicia aqui");

    }//end Update


    //Tasa fija de Frames
    private void FixedUpdate()
    {
        
    }


}//end class
