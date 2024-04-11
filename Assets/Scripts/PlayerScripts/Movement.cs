using UnityEngine;

public class Movement : MonoBehaviour //, IInteractable
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpPower = 10f;
    private Vector2 _input;    

    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // Debug.Log(this.name);
        // Debug.Log(this.GetComponent<Movement>().name);
        // Debug.Log(this.gameObject.name);
    }

    [SerializeField] private string axesName;
    [SerializeField] private KeyCode jumpKeyCode;

    private bool isJumping = true;
    private void Update()
    {
        _input.x = Input.GetAxis(axesName);
        rb.velocity = new Vector2(_input.x * _speed, rb.velocity.y);

        if (Input.GetKeyDown(jumpKeyCode) && rb.velocity.y <= 0)
        {
            if (isJumping)
            {
                rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
                isJumping = false;
            }
        }
        isJumping = true;

        // if(Input.GetKeyDown(KeyCode.Mouse0)){            
        //     Instantiate(null, null);
        //     transform.position = new Vector3(transform.position.x -3, 0, 0);
        // }

        // Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
    }
    // public Rigidbody2D GetPlayerRigidbody(){
    //     return rb;
    // }

    public GameObject GetGameObject(){
        return gameObject;
    }
}