using System.Collections.Generic;
using UnityEngine;


public class SO8EXAMPLE : MonoBehaviour
{
    private List<string> monstruos
    = new List<string>() { "Esqueleto", "orco", "ogro", "goblin" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        foreach (string item in monstruos)
        {
            if (item == "orco" || item == "ogro")
                continue;
            print(item);
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
