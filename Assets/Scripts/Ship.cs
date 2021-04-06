using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField]
    GameObject fire;

    [SerializeField]
    float velocidade = 5f;

    [SerializeField]
    int Vidas = 3;



    float minX, maxX;

    Vector3 bottomLeftWorld, topRightWorld;

    // Start is called before the first frame update
    void Start()
    {
        
        
        minX = Camera.main.ViewportToWorldPoint(Vector2.zero).x + 0.5f;
        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x - 0.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, transform.position, transform.rotation);
        }

        MoveShip();
    }

    void MoveShip()
    {
        float hMov = Input.GetAxis("Horizontal");
        transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    
    {
        if (collision.gameObject.tag == "ProjectilInimingo") 
        {
            Vidas -= 1;
            if (Vidas <= 0)
            {
                Destroy(gameObject);
            }










        }
        
    }


}
