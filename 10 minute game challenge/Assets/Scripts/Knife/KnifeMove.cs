using InputMove;
using UnityEngine;

namespace Move
{
    public class KnifeMove : MonoBehaviour
    {
        private const float SinMultiplier = 3f;
        private const float AmplitudeOscillations = 4f;

        [SerializeField] private float _speed;
        [SerializeField] private InputKnifeMove _inputKnifeMove;

        private float _startPositionX;

        private void Start() => _startPositionX = transform.position.x;

        private void Update()
        {
            if (_inputKnifeMove != null && _inputKnifeMove.IsMoving)
                MoveInMovingState();

            else
                OscillateInRestState();
        }

        private void MoveInMovingState()
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime, Space.World);
        }

        private void OscillateInRestState()
        {
            float oscillationValue = Mathf.Sin(Time.time * SinMultiplier) * AmplitudeOscillations;
            transform.position = new Vector2(_startPositionX, oscillationValue);
        }
    }
}