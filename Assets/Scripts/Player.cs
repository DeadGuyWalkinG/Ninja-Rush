using UnityEngine;

public class Player : MonoBehaviour
{
    private int isLeft = 0;
    public float speed = 10f;
    private void Start()
    {
        transform.position = new Vector2(1.79f, -2f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
            swapTower();
        }
    }

    void swapTower()
    {
        if (isLeft == 1)
        {
            while (isLeft == 1)
            {
                if (transform.position.x <= 1.79f)
                {
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                }
                else
                    isLeft = 0;
            }
        }
        else
        {
            while (isLeft == 0)
            {
                if (transform.position.x >= -1.79f)
                {
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                    
                }
                else
                    isLeft = 1;
            }
        }
    }
}
