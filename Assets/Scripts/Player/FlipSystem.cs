using UnityEngine;

public class FlipSystem : MonoBehaviour
{
    [SerializeField] private PlayerMovementComponent player;
    private bool bIsFlipped = true;
    private SpriteRenderer _spriteRender;

    private void Awake()
    {
        _spriteRender = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
       
     
    }

    internal bool Flip()
    {
        if(player._movement.x > 0)
        {
            bIsFlipped = !bIsFlipped;
        }
        else if (player._movement.x < 0)
        {
            bIsFlipped = !bIsFlipped;
        }
        return bIsFlipped;
    }
}
