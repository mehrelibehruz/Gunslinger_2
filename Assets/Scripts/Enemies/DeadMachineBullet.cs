using UnityEngine;

public class DeadMachineBullet : MonoBehaviour
{
    LevelManager levelManager;
    private void Start()
    {
        levelManager = Object.FindObjectOfType<LevelManager>();
    }
    private void Update()
    {
        transform.Translate(Vector2.left * 2f * Time.deltaTime);
        Destroy(gameObject, 2f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == Constants.Tags_Player)
        {
            Player.Instance.health.health--;
            levelManager.Spawn();
            Destroy(other.gameObject);
        }
    }
}