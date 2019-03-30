using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Cos : MonoBehaviour
{
    public float speed = 10f;

    Rigidbody rigidbody;

    Vector3 movement;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Run(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;        

        rigidbody.MovePosition(transform.position + movement);
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Run(h, v);
    }

    float GetSin(float x, float y)
    {
        return x / y;
    }
}
