using Player;
using Unity.VisualScripting;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private PlayerMovementComponent _playerMovementComponent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plate"))
        {
            Debug.Log("123");
            _playerMovementComponent._jumpForce = 12;
        }
    }
}
