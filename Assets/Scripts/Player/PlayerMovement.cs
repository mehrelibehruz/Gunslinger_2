using Helper;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector2 _input;
        private Rigidbody2D _rb;
        [SerializeField] float _speed;
        [SerializeField] float _jumpPower;


        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _input.x = Input.GetAxis(Constants.INPUT_HORIZONTAL);
            DoJump();
        }
        private void FixedUpdate()
        {
            _rb.velocity = new Vector2(_input.x * _speed, _rb.velocity.y);
        }

        void DoJump()
        {
            if (Input.GetButtonDown(Constants.INPUT_Jump) && Player.instance.playerInteract.CheckPlatform())
            {
                _rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
            }
        }
    }
}