using UnityEngine;

public class CameraSytem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        
   [SerializeField] private GameObject _playerMovementComponent;

    private Vector3 offset;


    private void Start()
    {
        offset = transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _playerMovementComponent.transform.position + offset;
    }
}
