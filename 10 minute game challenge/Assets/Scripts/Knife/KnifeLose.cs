using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeLose : MonoBehaviour
{
    private const float RightBoundary = 5.0f;

    private void Update()
    {
        if (transform.position.x > RightBoundary)
            RestartGame();
    }

    public void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}