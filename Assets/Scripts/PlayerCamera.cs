using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    
    [SerializeField] private GameObject _player;

    private Vector3 _cameraPoint;

    private void Awake()
    {
       _cameraPoint = transform.position; 
    }
    void Start()
    {
        
    }


    private void LateUpdate()
    {
        transform.position = _player.transform.position + _cameraPoint;
    }
}
