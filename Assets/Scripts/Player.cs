using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedMovement = 5;
    [SerializeField] private float _jumpForce = 10;

    private Rigidbody2D _rg;
    private bool _isGrounded;
    private Vector2 _movement;
    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = 0;

        if (Input.GetButton("Jump") && _isGrounded)
        {
            _rg.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            Debug.Log("Hump x1");
        }

    }

    private void FixedUpdate()
    {
        _rg.linearVelocity = new Vector2(_movement.x * _speedMovement, _rg.linearVelocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }


}
