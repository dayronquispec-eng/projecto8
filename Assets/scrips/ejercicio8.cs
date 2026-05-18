using UnityEngine;

public class ejercicio8 : MonoBehaviour
{
    int[] puntajes = { 100, 200, 300 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(int puntos in puntajes)
        {
            Debug.Log(puntos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
