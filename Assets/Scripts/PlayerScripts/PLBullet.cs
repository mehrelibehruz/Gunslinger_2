using UnityEngine;

public class PLBullet : MonoBehaviour
{    
    private void Update() {

        transform.Translate(Vector2.right * 2f * Time.deltaTime);
        Destroy(gameObject, 2f);    
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == Constants.Tags_Enemy){
            Destroy(other.gameObject);
        }
    }
}