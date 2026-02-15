using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject _player;
   
    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = _player.transform.position;
    }
}
