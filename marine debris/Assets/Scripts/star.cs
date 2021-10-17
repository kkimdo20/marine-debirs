using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour

{
    int type;
    int score;
    // Start is called before the first frame update

    void Start()
    {
        float x = 5;
        float y = Random.Range(-3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.01f, 0, 0);

        if (transform.position.x < -5.00f)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        {
            if (coll.gameObject.tag == "Player")
            {
                gameManager.I.addScore(score);
                Destroy(gameObject);

            }
        }
    }
}
    