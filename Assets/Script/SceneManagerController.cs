using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour
{
    public void CambiarEscena(int escena)
    {
        SceneManager.LoadScene(escena);
    }
}