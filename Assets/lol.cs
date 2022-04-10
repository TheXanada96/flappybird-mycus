using System.Collections; // collezioni di classi necessari per Unity
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour // classe dello script Unity che serve per gestire delle funzioni integrate
{
    public float speed = 10.0f; // variabile in float che è possibile modificare nel pogramma
    private void Start() // funzione privata che non restituisce alcun valore e esegue un codice appena apri il gioco
    {
        
    }
    private void Update() //  funzione privata che esegue un codice ogni frame del gioco 
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // ottiene il valore di un asse virtuale orizzontale utilizzando come input le freccette destra e sinistra
        float verticalInput = Input.GetAxis("Vertical"); // ottiene il valore di un asse virtuale verticale utilizzando come input le freccette su e giù

        Vector2 direction = new Vector2(horizontalInput, verticalInput); // Coppia di valori float che che identificano un punto sullo schermo.
        transform.Translate((direction * (speed * Time.deltaTime))); // Sposta l'oggetto lungo l'asse x e y moltiplicando la velicità per il tempo che passa
    }
}
