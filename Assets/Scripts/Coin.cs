using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
            Destroy(gameObject);
            FindAnyObjectByType<Logic>().increaseScore();
        }
    }
}
