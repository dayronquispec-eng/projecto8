using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Target;
    public float speed;
    public float distance;

    public float radius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(Target.transform.position, transform.position);
        if(distance < radius)
        { 
            Vector3 dir = Target.transform.position - transform.position;

            transform.position += dir * Time.deltaTime;
        }

    }
}
