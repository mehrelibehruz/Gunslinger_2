using UnityEngine;

public class Health : MonoBehaviour
{
	private int maxHealth = 100;
	private int currentHealth;

    private void Start() {
        currentHealth = maxHealth;
    }

}
