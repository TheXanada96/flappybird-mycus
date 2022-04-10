using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void clickrestart()
    {
        control.gameover = false; // setta il gameover a false
        SceneManager.LoadScene(1); // riavvia la scena
    }
}
