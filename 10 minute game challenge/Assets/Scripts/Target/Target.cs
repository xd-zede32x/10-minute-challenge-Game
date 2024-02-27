using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainTarget
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private float MaxSpeed = 5f;
        [SerializeField] private float MinSpeed = 3f;
        [SerializeField] private float _position = 3.7f;
        [SerializeField] private float InitialPositionX = 12f;
        [SerializeField] private float LeftBoundary = -6f;

        private float _targetSpeed;

        private void Start() => SetKnifeRandomPositionAndSpeed();
        private void Update() => TargetMove();

        private void SetKnifeRandomPositionAndSpeed()
        {
            transform.position = new Vector2(InitialPositionX, Random.Range(-_position, _position));
            _targetSpeed = Random.Range(MinSpeed, MaxSpeed);
        }

        private void TargetMove()
        {
            transform.Translate(-_targetSpeed * Time.deltaTime, 0f, 0f);

            if (transform.localPosition.x < LeftBoundary)
                RestartGame();
        }

        private void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}