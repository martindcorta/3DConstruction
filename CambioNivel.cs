using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    // Start is called before the first frame update
    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }


    public void Salir()
    {

    }
}
