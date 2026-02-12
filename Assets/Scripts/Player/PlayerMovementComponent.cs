using UnityEngine;

public class PlayerMovementComponent : MonoBehaviour
{
    [SerializeField] private float _speedMovement = 5;
    [SerializeField] private float _jumpForce = 10;
    

    private Rigidbody2D _rg;
    private Vector2 _movement;
    private PlayerRaycastSystem _playerRaycastSystem;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
        _playerRaycastSystem = GetComponentInChildren<PlayerRaycastSystem>();

    }
    void Update()
    {
       
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = 0;

        Jump();
    }
    private void FixedUpdate()
    {
        _rg.linearVelocity = new Vector2(_movement.x * _speedMovement, _rg.linearVelocity.y);
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && _playerRaycastSystem)
        {
            _rg.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump x1");
        }
    }




}
