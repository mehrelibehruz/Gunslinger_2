using UnityEngine;

public class Gun : MonoBehaviour
{
    Weapon weapon;
    private void Awake() {
        weapon = Object.FindObjectOfType<Weapon>();
    }
    private void Update()
    {
        transform.Translate(Vector2.right * weapon.gunSpeed * Time.deltaTime); 
        Destroy(this.gameObject, weapon.lifeTime);
    }
}