using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int isLeft = 0;
    public float speed = 10f;
    [SerializeField] private float wallPos = 1.6f;
    private int swapping=0;
    public Animator anim;
    [SerializeField] private Rigidbody2D rb;
    private void Start()
    {
        transform.position = new Vector2(wallPos, -2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && swapping == 0)
        { 
            swapTower();
        }
    }
    void swapTower()
    {
        swapping = 1;
        anim.SetInteger("Jump",swapping);
        StartCoroutine(SwapTowerCoroutine());
        swapping = 0;
        anim.SetInteger("Jump",swapping);

    }
    IEnumerator SwapTowerCoroutine()
    {
        if (isLeft == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
            rb.linearVelocityX = speed;
            while (transform.position.x < wallPos)
            { 
                //transform.Translate(Vector2.down * speed * Time.deltaTime);
                Debug.Log(transform.position.x);
                yield return null;
            }
            rb.linearVelocityX = 0;
            isLeft = 0;
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 90);
            rb.linearVelocityX = -speed;
            while (transform.position.x > -wallPos)
            {
                //transform.Translate(Vector2.up * speed * Time.deltaTime);
                Debug.Log(transform.position.x);
                yield return null;
            }
            rb.linearVelocityX = 0;
            isLeft = 1;
        }
    }
}
