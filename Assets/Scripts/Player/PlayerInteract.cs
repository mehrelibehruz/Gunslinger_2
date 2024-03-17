using Helper;
using UnityEngine;

namespace Player
{
    public class PlayerInteract : MonoBehaviour
    {
        [SerializeField] Transform _feetPosition;
        [SerializeField] float _radius;
        [SerializeField] LayerMask platformMask;

        public bool CheckPlatform()
        {
            return Physics2D.OverlapCircle(_feetPosition.position, _radius, platformMask);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(Constants.TAG_DEATH_ZONE))
            {
                Debug.Log("Player is dead");
                Destroy(gameObject);
            }
            if (collision.CompareTag(Constants.TAG_ENEMY))
            {
                Player.instance.playerHealth.Damage(10);
            }
        }
    }
}