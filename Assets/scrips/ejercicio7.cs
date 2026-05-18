using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    string[] enemigos = { "zombi", "araña", "Esqueleto" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            Debug.Log(enemigos[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
