using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PUNTI : MonoBehaviour
{
    public static int valorepunti;
    // Start is called before the first frame update
    void Start()
    {
        valorepunti = 0; 

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = valorepunti.ToString(); //ottiene il componente testo e converte la variabile in una stringa.
    }
}
