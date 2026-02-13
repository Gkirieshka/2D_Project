using UnityEngine;

public class PlayerRaycastSystem : MonoBehaviour
{
    [SerializeField] private float _raycastDistance;
    [SerializeField] private LayerMask _getLayerMask;

    private Vector2 _raycastStart;
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
