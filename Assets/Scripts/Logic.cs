using UnityEngine;

public class Logic : MonoBehaviour
{
    [SerializeField] private GameObject towers;
    [SerializeField] private GameObject spikes;
    [SerializeField] private float spawnPoint = 21.86f;

    [ContextMenu("Spawn Tower")]
    public void spawnTower()
    {
        Instantiate(towers, new Vector2(-3.221583f, spawnPoint), Quaternion.identity);
    }

    [ContextMenu("Spawn Spike")]
    public void spawnSpike()
    {
        float sp = -1.79f;
        float r=90;
        if (Random.Range(1, 3) == 1)
        {
            sp = sp * 1;
            r = r * 1;
        }
        else
        {
            sp = sp * -1;
            r = r * -1;
        }
        Instantiate(spikes, new Vector2(sp, 8), Quaternion.Euler(0,0,r));
    }
}
