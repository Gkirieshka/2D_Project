using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedMovement = 5;
    [SerializeField] private float _jumpForce = 10;
    [SerializeField] private float _raycastGroundDistance = 1f;

    [SerializeField] private float _raycastEnemyDistance = 1f;
    [SerializeField] private LayerMask _enemyLayerMask;


    [SerializeField] private LayerMask _groundLayerMask;
    [SerializeField] private Transform _raycastPosition;

    private Rigidbody2D _rg;
    private Vector2 _movement;
    private Vector2 _raycastStart;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
        _raycastStart = _raycastPosition.position;
    }
    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = 0;

        if (Input.GetButton("Jump") && IsGrounded())
        {
            _rg.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump x1");
        }

        if (Input.GetButton("Fire2") && IsEnemy())
        {
            Debug.Log($"You hit Enemy");
        }
    }
    private void FixedUpdate()
    {
        _rg.linearVelocity = new Vector2(_movement.x * _speedMovement, _rg.linearVelocity.y);   
    }
    private bool IsGrounded()
    {
        RaycastHit2D _hit = Physics2D.Raycast(transform.position, Vector2.down, _raycastGroundDistance, _groundLayerMask);

        if (_hit.collider)
        {
            return true;
        }
        return false;
    }

    private bool IsEnemy()
    {
        RaycastHit2D _check = Physics2D.Raycast(transform.position, _movement, _raycastEnemyDistance, _enemyLayerMask);
        if (_check.collider)
        {
            return true;
        }
        return false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * _raycastGroundDistance);

      //  Gizmos.DrawLine(transform.position, transform.position + (Vector3)_movement * _raycastEnemyDistance);
    }

    

}
