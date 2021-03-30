using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapceInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    GameObject[] invasores;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = 0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;


    void Awake()
    {
        float y = yMin;

        for(int line = 0; line <5; line++)
        {
            GameObject invader = null;

            if(line == 0 || line == 1)
            {
                invader = invasorA;
            }else if (line == 2 || line == 3)
            {
                invader = invasorB;
            }else if( line == 4)
            {
                invader = invasorC;
            }

            
            float x = xMin;
            for(int i = 1; i <=nInvasores; i++)
            {
                GameObject newInvader = Instantiate(invader, transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;
            }
            y += yInc;
                   

        }
    }
        
    


}
