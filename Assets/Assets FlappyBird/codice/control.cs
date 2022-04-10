using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour { 
    float spawntimer;
    float spawnrate = 3f;
    public GameObject tubo;
    public static bool gameover;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!gameover) // se gameover è falso
        {
            spawntimer += Time.deltaTime; // il tempo di spawn aumenta 
            if (spawntimer >= spawnrate) // se il tempo di spawn è maggiore/uguale al reggio di spawn
            {
                spawntimer -= spawnrate; // sottrae 
                Vector2 posizione = new Vector2(2f, Random.Range(-1f, 2f)); // crea i tuti in un range
                Instantiate(tubo, posizione, Quaternion.identity); // clona il prefab dei tubi e annulla la rotazione

            }
        }
    }
}
