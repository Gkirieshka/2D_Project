using UnityEngine;
using UnityEngine.Tilemaps;

public class LadderSystem : MonoBehaviour
{
    // [SerializeField] GameObject _gameObject;
    [SerializeField] private TilemapCollider2D _tilemapCollider2D;
    private PlayerMovementComponent _movementComponent;


    private Vector2 _position;
    private bool _visibleColliders = true;

    
    void Start()
    {
        _movementComponent = GetComponent<PlayerMovementComponent>();
        _position = _movementComponent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetButton("Jump"))
        {
            Debug.Log("Up");
           
        }
       
    }
}
