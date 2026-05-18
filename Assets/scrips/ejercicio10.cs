using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    string[] niveles = { "bosque", "cuevas", "castillo" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (string nivel in niveles)
        {
            Debug.Log("Nivel desbloqueado: " + nivel);                                       
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
