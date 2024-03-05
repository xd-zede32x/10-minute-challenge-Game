using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainTarget
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _minSpeed;
        [SerializeField] private float _position;
        [SerializeField] private float _leftBoundary;
        [SerializeField] private float _initialPositionX;

        private float _targetSpeed;

        private void Start() => SetKnifeRandomPositionAndSpeed();
        private void Update() => MoveTarget();

        private void SetKnifeRandomPositionAndSpeed()
        {
            transform.position = new Vector2(_initialPositionX, Random.Range(-_position, _position));
            _targetSpeed = Random.Range(_minSpeed, _maxSpeed);
        }

        private void MoveTarget()
        {
            transform.Translate(-_targetSpeed * Time.deltaTime, 0f, 0f);

            if (transform.localPosition.x < _leftBoundary)
                RestartGame();
        }

        private void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}