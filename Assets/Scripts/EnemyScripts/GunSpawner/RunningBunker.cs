using Unity.Mathematics;
using UnityEngine;

public class RunningBunker : MonoBehaviour //, IInteractable
{
    private static int health = 3;
    private static int speed = 5;

    [SerializeField] Transform startPosition, endPosition;
    Rigidbody2D rb;

    [SerializeField] private GameObject gun;
    [SerializeField] private Transform firePoint;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private bool isRight = false;

    // public Rigidbody2D GetPlayerRigidbody()
    // {
    //     return rb;
    // }
    private void Start()
    {
        InvokeRepeating("Fire", 1f, 2f);
    }
    private void Update()
    {
        if (!isRight)
        {
             transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            // firePoint.localScale = new Vector3(firePoint.localScale.x, firePoint.localScale.y, firePoint.localScale.z);
            if (transform.position.x <= startPosition.position.x) { isRight = true; }
        }
        else
        {
             transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            // firePoint.localScale = new Vector3(-firePoint.localScale.x, firePoint.localScale.y, firePoint.localScale.z);
            if (transform.position.x >= endPosition.position.x) { isRight = false; }
        }
    }
    private void Fire()
    {
        var gunObject = Instantiate(gun, firePoint.position, Quaternion.identity);

        // gunObject.transform.localScale = new Vector3(firePoint.localScale.x, gun.transform.localScale.y, gun.transform.localScale.z);
        float angle = transform.localScale.x == 1f ? 180f : 0f;
        gunObject.transform.Rotate(0, angle, 0);
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }
}
