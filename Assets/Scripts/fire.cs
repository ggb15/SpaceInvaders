using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    float force = 200f;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    
}
