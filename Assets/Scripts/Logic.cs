using UnityEngine;

public class Logic : MonoBehaviour
{
    [SerializeField] private GameObject towers;
    [SerializeField] private GameObject spikes;
    [SerializeField] private float spawnPoint = 21.86f;
    [SerializeField] private float spikeRate = 2f;
    private float nextSpike;
    private int score=0;

    void Start()
    {
        nextSpike = spikeRate;
    }

    void Update()
    {
        if (Time.time > nextSpike)
        {
            spawnSpike();
            nextSpike = Time.time + spikeRate;
        }

    }

    [ContextMenu("Spawn Tower")]
    public void spawnTower()
    {
        //spawn towers continously
        Instantiate(towers, new Vector2(-3.221583f, spawnPoint), Quaternion.identity);
    }

    [ContextMenu("Spawn Spike")]
    public void spawnSpike()
    {
        //spawn spikes randomly on the two sides of the tower
        float sp = -1.79f;
        float r=-90;
        int x;
        if (Random.Range(1, 3) == 1)
            x = 1;
        else
            x = -1;
        sp = sp * x;
        r = r * x;
        Instantiate(spikes, new Vector2(sp, 8), Quaternion.Euler(0,0,r));
    }

    public void gameOver()
    { 
        //gameover screen enables
    }

    public void increaseScore()
    {
        //increase scorepoints
        score++;
    }
}
