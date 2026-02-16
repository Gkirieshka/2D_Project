using UnityEditor.VersionControl;
using UnityEngine;


namespace Player
{
    public class PlayerAnimation : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        [SerializeField] private PlayerMovementComponent _player;

        private Animator _animatror;
        void Start()
        {
            _player = GetComponent<PlayerMovementComponent>();
            _animatror = GetComponent<Animator>();
        }

        // Update is called once per frame
        private void Update()
        {
            _animatror.SetFloat("Run", Mathf.Abs(_player._movement.x));


        }

        internal void AMJumpTrue()
        {
            Debug.Log($"True");
            _animatror.SetBool("bIsJump", true);

        }
        internal void AMJumpFalse()
        {
            Debug.Log($"False");


            _animatror.SetBool("bIsJump", false);

        }

    }
}

