using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField][Range(0, 50)] float _speed = 10f, _jumpPower = 10f;
    public bool doMove = true;

    IInputReader _input;
    Vector2 _moveDirection;

    Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _input = new OldInputReader();
    }

    int direction = 1;
    private void Update()
    {
        if (!doMove)
            return;

        _moveDirection = _input.MoveDirection;
        _rb.velocity = new Vector3(_moveDirection.x * _speed, _rb.velocity.y, 0f);

        if (_rb.velocity.x > 0f)
        {
            transform.localScale = new Vector3(direction, transform.localScale.y, transform.localScale.z);
        }
        else if(_rb.velocity.x < 0f){
            transform.localScale = new Vector3(-direction, transform.localScale.y, transform.localScale.z);
        }        

        bool isPlatform = Physics2D.OverlapCircle(Player.Instance.feetPosition.position, 0.3f, Player.Instance.layerMask);
        if (isPlatform && _input.KeyDown(Player.Instance.player_MoveCode[1]))
        {
            _rb.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
        }

        Camera.main.transform.position = new Vector3(transform.position.x, /*Mathf.Clamp(transform.position.y, -2f, 2f)*/ transform.position.y, -10f);
    }
    // TODO: Fixed Update
}