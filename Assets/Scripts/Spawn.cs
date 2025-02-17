using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject towers;
    [SerializeField] private float spawnPoint = 21.86f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Spawn Tower")]
    public void spawnTower()
    {
        Instantiate(towers, new Vector2(-3.221583f, spawnPoint), Quaternion.identity);
    }
}
