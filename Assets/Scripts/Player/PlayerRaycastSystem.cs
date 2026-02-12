using UnityEngine;

public class PlayerRaycastSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float _raycastDistance;
    [SerializeField] private LayerMask _getLayerMask;

    private Vector2 _raycastStart;
    private void Awake()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        _raycastStart = transform.position;
        IsGrounded();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_raycastStart, _raycastStart + Vector2.down * _raycastDistance);
    }

    public bool IsGrounded()
    {
        RaycastHit2D _hit = Physics2D.Raycast(_raycastStart, Vector2.down, _raycastDistance, _getLayerMask);

        if (_hit.collider)
        {
            return true;
        }
        return false;
    }
}
