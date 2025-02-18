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

    public void spawnSpike()
    {
        float sp = -1.79f;
        if (Random.Range(1, 3) == 1)
            sp = sp * 1;
        else 
            sp = sp * -1;
        Instantiate(spikes, new Vector2(sp, 8), Quaternion.identity);
    }
}
