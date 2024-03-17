using UnityEngine;
namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] public PlayerInteract playerInteract;
        [SerializeField] public PlayerMovement playerMovement;
        [SerializeField] public PlayerHealth playerHealth;

        public static Player instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}