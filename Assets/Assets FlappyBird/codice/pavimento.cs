using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavimento : MonoBehaviour
{
    Vector2 inizio;
    // Start is called before the first frame update
    void Start()
    {
        inizio = transform.position; // variabile a cui affido il valore default della posizione
        Debug.Log(Time.deltaTime); // il valore di delta time è 0.02
    }

    // Update is called once per frame
    void Update()
    {
        if (!control.gameover) // se richiamando il file con la funzione gameover è falsa
        {
            if (transform.position.x >= -0.76f)

                transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
            // fa muovere il pavimento verso sinistra 
            // Time.deltaTime è il tempo trascorso dall'ultimo fotogramma. bisogna aggiungerlo per avere una velocità costante. 

            else // altrimenti ritorna a 0
                transform.position = inizio;

        }
    }
}
