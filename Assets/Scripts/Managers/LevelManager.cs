using UnityEngine;

public class LevelManager : MonoBehaviour
{
    Player player;
    [SerializeField] Transform startPoint;
    public GameObject playerPrefab;

    public GameObject[] enemies;
    public int enemyCount;

    private void Start()
    {
        player = Object.FindObjectOfType<Player>();
        Instantiate(playerPrefab, startPoint.position, Quaternion.identity);
        enemyCount = enemies.Length;
    }
    private void Update()
    {        
        if (enemyCount == 0)
        {
            print("Player win");
        }
        // for (int i = 0; i < enemies.Length; i++)
        //         enemies.ElementAt(i).SetActive(false);         
        // {
        // }
    }
    public void Spawn(){
        Instantiate(playerPrefab, startPoint.position, Quaternion.identity);
    }
}