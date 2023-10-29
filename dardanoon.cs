using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dardanoon : MonoBehaviour
{
    // health
    public int health = 5;
    //move
    public int speed = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
