using Move;
using UnityEngine;

namespace InputMove
{
    public class InputKnifeMove : MonoBehaviour
    {
        public bool IsMoving => _isMoving;

        private bool _isMoving;

        private void Update() => InputMove();

        public void InputMove()
        {
            if (Input.GetMouseButtonDown(0))
                _isMoving = true;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (_isMoving)
                _isMoving = false;
        }
    }
}