using UnityEngine;

public class ejercicio9 : MonoBehaviour
{
    int[] monedas = { 5, 10, 20, 30 };
    int total = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < monedas.Length; i++)
        {
            total += monedas[1];
        }
        Debug.Log("total: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
