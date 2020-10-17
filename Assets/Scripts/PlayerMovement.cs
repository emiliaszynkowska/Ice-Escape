using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private bool alive = false;
    bool jumped = false;
    public Animator animator;
    private Text gameOverText;
    public GameObject start;

    public void SetAlive()
    {
        alive = true;
        start.gameObject.SetActive(false);
    }
    
    void Start()
    {
        SetAlive();
        gameOverText = GetComponentInChildren<Text>();
        gameOverText.gameObject.SetActive(false);
    }

    // Graphics & Input Updates
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) | Input.GetMouseButtonDown(0))
        {
            jumped = true;
            animator.SetTrigger("Fly");
        }
    }

    // Physics Engine Updates
    void FixedUpdate()
    {
        if (alive)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * 7);
        }
        if (alive & jumped)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 100);
            jumped = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Top Icicle") | collision.collider.CompareTag("Bottom Icicle"))
        {
            animator.SetTrigger("Death");
            Score.SetHighScore();
            gameOverText.gameObject.SetActive(true);
            alive = false;
        }
    }

}
