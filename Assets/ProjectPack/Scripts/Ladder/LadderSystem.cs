using Player;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LadderSystem : MonoBehaviour
{
    // [SerializeField] GameObject _gameObject;
    [SerializeField] private TilemapCollider2D _tilemapCollider2D;
    private PlayerMovementComponent player;


    private Vector2 _position;
    private bool _visibleColliders = true;

    
    void Start()
    {
        player = GetComponent<PlayerMovementComponent>();
        _position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetButton("Jump"));
        {
            Debug.Log("Up");
          //player.transform.position.y += 0.5f;
        }
       
    }
}
