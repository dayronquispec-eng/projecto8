using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    string[] inventario = new string[] {"Espada","Poción","Escudo","Arco","Flechas" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (string item in inventario)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
