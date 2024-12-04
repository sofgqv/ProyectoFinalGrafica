using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaTemporizador : MonoBehaviour
{
    public float tiempoEspera = 2f; // Tiempo en segundos

    void Start()
    {
        Invoke("CambiarEscena", tiempoEspera);
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene(1); // Cambiar a la escena con índice 1
    }
}
