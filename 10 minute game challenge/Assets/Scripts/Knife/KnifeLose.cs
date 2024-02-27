using InputMove;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeLose : MonoBehaviour
{
    [SerializeField] private InputKnifeMove _inputKnifeMove;

    private const float RightBoundary = 5.0f;

    private void Update()
    {
        if (transform.position.x > RightBoundary)
            RestartGame();
    }

    public void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_inputKnifeMove.IsMoving)
            RestartGame();
    }
}