using UnityEngine;

public class Logic : MonoBehaviour
{
    [SerializeField] private GameObject towers;
    [SerializeField] private float spawnPoint = 21.86f;

    [ContextMenu("Spawn Tower")]
    public void spawnTower()
    {
        Instantiate(towers, new Vector2(-3.221583f, spawnPoint), Quaternion.identity);
    }
}
