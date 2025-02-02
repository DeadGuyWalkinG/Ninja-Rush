using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int isLeft = 0;
    public float speed = 10f;
    [SerializeField] private float wallPos = 1.6f;
    private int swapping = 0;
    private void Start()
    {
        transform.position = new Vector2(wallPos, -2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && swapping == 0)
            swapTower();
    }

    void swapTower()
    {
        swapping = 1;
        StartCoroutine(SwapTowerCoroutine());

    }
    IEnumerator SwapTowerCoroutine()
    {
        if (isLeft == 1)
        {
            while (transform.position.x < wallPos)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                yield return null;
            }
            isLeft = 0;
        }
        else
        {
            while (transform.position.x > -wallPos)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                yield return null;
            }
            isLeft = 1;
        }
        swapping = 0;
    }
}
