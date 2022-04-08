using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.

public class ej02 : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;
    public int montodedinero;
    
    // Start is called before the first frame update
    void Start()
    {
        int dinerorestante = producto1 + producto2 + producto3 - montodedinero;
        int dinerodisponible = montodedinero - producto1 - producto2 - producto3;
        if (montodedinero >= producto1 + producto2 + producto3)
        {
            Debug.Log("te sobra " + dinerodisponible + "pesos");
        }
        
        else
        {
            Debug.Log ("supera el monto y te falta" + dinerodisponible + "pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
