using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public AudioSource mysfx;

    public AudioClip jumpsfx;
    public AudioClip bangsfx;
    public AudioClip starsfx;

    public GameObject player;
    Rigidbody2D rb2d;
    public float jumpPower = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            JumpSound();
            rb2d.velocity = Vector2.up * jumpPower;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 0.01f;
            Application.LoadLevel("GameStage");
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Vinyl")
        {
            BangSound();
            gameManager.I.gameOver();
        }
        
  
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        {
            if (coll.gameObject.tag == "Star")
            {
                StarSound();
            }
        }
    }
    public void JumpSound()
    {
        mysfx.PlayOneShot(jumpsfx);
    }

    public void BangSound()
    {
        mysfx.PlayOneShot(bangsfx);
    }
   
    public void StarSound()
    {
        mysfx.PlayOneShot(starsfx);
    }
}
