using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debrisSprite : MonoBehaviour
{

    public Sprite[] debris;
    int type;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        type = Random.Range(0, 8);
        GetComponent<SpriteRenderer>().sprite = debris[type];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
