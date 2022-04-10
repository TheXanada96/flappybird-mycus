using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uccello : MonoBehaviour
    
{
    public GameObject gameover; // richiamo un gameobject pubblico da Unity
    public GameObject restart;
    Rigidbody2D oggetto; // dichiaro una variabile rigidbody che gestisce la fisica del personaggio
    public AudioClip[] clips; // dichiaro un array audio 
    AudioSource b; // dichiato
    
    void Start()
    {
        oggetto = GetComponent<Rigidbody2D>(); // richiama il componente del rigidbody
        b = GetComponent<AudioSource>(); // richiama il componente audiosource
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !control.gameover) { // se clicco il tasto sinistro del mouse e se il gameover è negativo
            b.PlayOneShot(clips[0]); // riproduce il primo suono dell'array (volo)
            oggetto.velocity = new Vector2(0f, 6f); // lo sprite salta di 6 valori Y float
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) // se entra in collisione con un tubo
    {
        b.PlayOneShot(clips[1]); // riproduce il secondo suono dell'array (gameover)
        control.gameover = true; // lo scenario di gameover diventa vero 
        gameover.SetActive(true); // mostra la scritta gameover
        restart.SetActive(true); // mostra il pulsante restart
    }
}