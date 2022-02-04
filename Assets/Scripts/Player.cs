using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // public float moveSpeed;
    //  private float movementX;

    Rigidbody2D rb;
    public float jumpForce;
    private bool isGrounded;
    public int health;
    public Text healthText;
    public GameObject gameOver;
    public GameObject spawner;
    private Animator anim;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        
        healthText.text = health.ToString();

        // transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        if (health <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameOver.SetActive(true);
            spawner.SetActive(false);
            anim.SetTrigger("dead");
            SoundScript.PlaySound("deadSound");
            Destroy(gameObject,.5f);
        }
        // audioSource.Play();

        if (QuitScript.gamePaused)
        {
            audioSource.pitch *= .5f;
        }
        else
        {
            audioSource.pitch = 1f;
        }
    }

    void FixedUpdate()
    {
        //if(Input.GetButtonDown("Jump") && isGrounded)
        if(Input.touchCount > 0 && isGrounded)
        {
            //Debug.Log("pressed!");
            //rb.AddForce(new Vector2(0f, jumpForce),  ForceMode2D.Impulse);
            
            rb.velocity = Vector2.up * jumpForce;
            anim.SetBool("jump", true);
            SoundScript.PlaySound("jump");
            //anim.SetTrigger("jump");
            isGrounded = false;
        }

        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            // SoundScript.PlaySound("footstep");
            anim.SetBool("jump", false);
        }
    }
}
