using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaVirtual : MonoBehaviour
{
    public int CantidadEntradas;
    public string TipoEntrada;
    public string Prioridad;

    int TipoEntrada = "B" = 800;
    int TipoEntrada = "N" = 1200;
    int TipoEntrada = "P"= 2000;
    
    
    int PrecioTotal;



    // Start is called before the first frame update
    void Start()
    {
        if(CantidadEntradas > 4 && TipoEntrada = B){
            Debug.Logerror("Error, no podes comprar tantas entradas basicas");
            return;
        }
        if(CantidadEntradas > 6 && TipoEntrada = N){
            Debug.Logerror("Error, no podes comprar tantas entradas normales");
            return;
        }
        if(CantidadEntradas <= 0){
            Debug.Logerror("Error, cantidad ingresada no valida");
            return;
        }
        if(Prioridad = S && TipoEntrada = B || TipoEntrada = N){
            Debug.Logerror("Error, no podes tener prioridad en la compra si no compraste la entrada premium");
            return;
        }
        if(Prioridad = S && TipoEntrada = P){
            Debug.Log("Tenes prioridad en la compra");
        }
        int PrecioTotal = (TipoEntrada * CantidadEntradas);
        Debug.Log("El precio total es de $" + PrecioTotal);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
