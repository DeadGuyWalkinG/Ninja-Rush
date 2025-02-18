using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private int flag = 1;
    [SerializeField] private float spawnFlag;
    [SerializeField] private float deletePoint;
    private Vector2 movementDirection;

    void Start()
    {
        if (transform.position.x > 0)
            movementDirection = Vector2.left;
        else
            movementDirection = Vector2.right;

    }

    void Update()
    {
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
            FindAnyObjectByType<Logic>().gameOver();
    }

}
