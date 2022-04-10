using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{
    bool conto = false; // il bool del conto è false
    AudioSource a; 
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y); // muove verso sinistra i tubi 
        if (transform.position.x < -6f) // se il tubo raggiunge l'asse -6
        {
            Destroy(gameObject); // distrugge l'oggetto 
        }
        if (!conto && transform.position.x < -4f) { // se il tubo raggiunge il valore -4
            a.Play(); // riproduce audio punto
            conto = true; // conto diventa true
            PUNTI.valorepunti += 1; // ripesca lo script PUNTI e aggiunge 1 al punteggio.
        }
    }
}
