using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    [SerializeField] private GameObject spikes;
    [SerializeField] private GameObject coin;
    [SerializeField] private float spikeRate = 2f;
    [SerializeField] private float coinRate = 1.5f;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private Text gameScore;
    private float nextSpike;
    private float nextCoin;
    private int score=0;

    void Start()
    {
        nextSpike = spikeRate;
        nextCoin = coinRate;
    }

    void Update()
    {
        if (Time.time > nextSpike)
        {
            spawnItem(spikes);
            nextSpike = Time.time + spikeRate;
        }

        if (Time.time > nextCoin)
        {
            spawnItem(coin);
            nextCoin = Time.time + coinRate;
        }

    }

    public void spawnItem(GameObject item)
    {
        //spawn spikes or coins randomly on the two sides of the tower
        float sp = -1.5f;
        float r = 0;
        int x;
        if (Random.Range(1, 3) == 1)
            x = 1;
        else
            x = -1;
        sp = sp * x;
        if (item.tag != "Coin")
        {
            r = -90 * x;
            sp = -1.79f * x;
        }
        Instantiate(item, new Vector2(sp, 8), Quaternion.Euler(0,0,r));
    }

    public void gameOver()
    {
        //gameover screen enabless
        Debug.Log("Game Over");
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);

    }

    public void increaseScore()
    {
        //increase scorepoints
        score++;
        gameScore.text = score.ToString();
    }

    public void retryButton()
    {
        Debug.Log("Game Reset");
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void exitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void startButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void exitGameButton()
    { 
        Application.Quit();
    }
}
