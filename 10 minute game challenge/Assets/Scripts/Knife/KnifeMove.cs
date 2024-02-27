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

        public void Update()
        {
            if (_inputKnifeMove.IsMoving)
                transform.Translate(Time.deltaTime * _speed, 0f, 0f, Space.World);

            else
                transform.position = new Vector2(_startPositionX, Mathf.Sin(Time.time * SinMultiplier) * AmplitudeOscillations);
        }
    }
}