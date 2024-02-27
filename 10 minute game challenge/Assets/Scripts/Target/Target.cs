using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    private const float MaxSpeed = 5f;
    private const float MinSpeed = 3f;
    private const float MaxPositionY = 3.7f;
    private const float MinPositionY = -3.7f;
    private const float InitialPositionX = 12f;
    private const float LeftBoundary = -6f;

    private float _targetSpeed;

    private void Start() => SetKnifeRandomPositionAndSpeed();
    private void Update() => TargetMove();

    private void SetKnifeRandomPositionAndSpeed()
    {
        transform.position = new Vector2(InitialPositionX, Random.Range(MinPositionY, MaxPositionY));
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