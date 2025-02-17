using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float spawnFlag = -5.69f;
    private int flag = 1;
    [SerializeField] private float deletePoint = -21.5f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < spawnFlag && flag == 1)
        {
            FindAnyObjectByType<Logic>().spawnTower();
            flag = 0;
        }

        if (transform.position.y < deletePoint)
            Destroy(gameObject);
    }

}
