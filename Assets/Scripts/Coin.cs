using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -15)
            Destroy(gameObject);
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
            FindAnyObjectByType<Logic>().increaseScore();
            Destroy(gameObject);
        }

        else if (collision.collider.tag == "Trap")
        { 
            transform.position = new Vector2(transform.position.x*(-1), transform.position.y);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with: " + collision.name);

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player detected!");
            FindAnyObjectByType<Logic>().increaseScore();
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Trap"))
        {
            Debug.Log("Trap detected!");
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }
    }

}
