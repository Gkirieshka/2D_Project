using UnityEngine;

namespace Player
{
    public class PlayerMovementComponent : MonoBehaviour
    {
        [SerializeField] private float _speedMovement = 5;
        [SerializeField] internal float _jumpForce = 10;


        private Rigidbody2D _rg;
        internal Vector2 _movement;
        private PlayerRaycastSystem _playerRaycastSystem;
        private PlayerAnimation _playerAnimation;

        private FlipSystem _flipSystem;

        private void Awake()
        {
            _rg = GetComponent<Rigidbody2D>();
            _playerRaycastSystem = GetComponentInChildren<PlayerRaycastSystem>();
            _flipSystem = GetComponentInChildren<FlipSystem>();
            _playerAnimation = GetComponent<PlayerAnimation>();

        }
        void Update()
        {

            _movement.x = Input.GetAxis("Horizontal");
            _movement.y = 0;
            _flipSystem.Flip();
            Jump();

        }
        private void FixedUpdate()
        {
            _rg.linearVelocity = new Vector2(_movement.x * _speedMovement, _rg.linearVelocity.y);
        }

        private void Jump()
        {
            if (Input.GetButtonDown("Jump") && _playerRaycastSystem.IsGrounded())
            {
                _rg.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
                _playerAnimation.AMJumpTrue();
                return;
            }
            if (_playerRaycastSystem.IsGrounded())
            {
                _playerAnimation.AMJumpFalse();
            }
        }
    }

}
