using UnityEngine;

namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        private int _maxHealth = 100;
        private int _currentHealth;

        private void Start()
        {
            _currentHealth = _maxHealth;
        }        

        public void Damage(int damage)
        {
            if (_currentHealth != 0)
            {
                _currentHealth -= damage;
                print("Current health: " + _currentHealth);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}