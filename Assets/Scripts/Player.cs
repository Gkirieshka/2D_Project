using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedMovement = 5;
    [SerializeField] private float _jumpForce = 10;
    [SerializeField] private float _raycastDistance;

    [SerializeField] private LayerMask _getLayerMask;
    [SerializeField] private Transform _raycastPosition;

    private Rigidbody2D _rg;
    private Vector2 _movement;
    private Vector2 _raycastStart;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        _raycastStart = _raycastPosition.position;
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = 0;
        IsGrounded();
        if (Input.GetButton("Jump") && IsGrounded())
        {
            _rg.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump x1");
        }
    }
    private void FixedUpdate()
    {
        _rg.linearVelocity = new Vector2(_movement.x * _speedMovement, _rg.linearVelocity.y);   
    }
    private bool IsGrounded()
    {
        RaycastHit2D _hit = Physics2D.Raycast(_raycastStart, Vector2.down, _raycastDistance, _getLayerMask);

        if (_hit.collider)
        {
            Debug.Log("Test");
            return true;
        }
        return false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_raycastStart, _raycastStart + Vector2.down * _raycastDistance);
    }


}
