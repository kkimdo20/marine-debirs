using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debris : MonoBehaviour
{
    public Text ScoreUI;
    
    // Start is called before the first frame update

    void Start()
    {  
        float x = 5;
        float y = Random.Range(-5.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.03f, 0, 0);


        if (transform.position.x < -4.00f)
        {
            Destroy(gameObject);
        }
    }
}

   
