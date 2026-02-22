using Player;
using UnityEngine;

public class PressurePlate : MonoBehaviour
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            _playerMovementComponent._jumpForce = 20;
            Debug.Log("123");
        }
    }
  
}
