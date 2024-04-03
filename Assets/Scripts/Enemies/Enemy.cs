using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    bool directionRight = false;
    static byte health = 2;
    BoxCollider2D enemy_Collider2D;
    LevelManager levelManager;
    private void Start()
    {
        levelManager = Object.FindObjectOfType<LevelManager>();
        enemy_Collider2D = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (health == 0) print("Enemy is dead");
        if (transform.position.x <= startPoint.position.x)
        {
            directionRight = true;
        }
        if (transform.position.x >= endPoint.position.x)
        {
            directionRight = false;
        }

        if (directionRight)
        {
            transform.Translate(Vector2.right * 5f * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * 5f * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == Constants.Tags_Enemy) enemy_Collider2D.isTrigger = true;
        if (other.collider.tag == Constants.Tags_Player)
        {
            enemy_Collider2D.isTrigger = false;
            // --health;
            levelManager.enemyCount -= 1;
            gameObject.SetActive(false);
        }
    }    
}