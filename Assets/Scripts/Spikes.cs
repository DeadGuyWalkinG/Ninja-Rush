using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private int flag = 1;
    [SerializeField] private float spawnFlag;
    [SerializeField] private float deletePoint;

   void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        /*if (transform.position.y < spawnFlag && flag == 1)
        {
            FindAnyObjectByType<Logic>().spawnTower(-3.221583f);
            flag = 0;
        }

        if (transform.position.y < deletePoint)
            Destroy(gameObject);*/

    }

}
