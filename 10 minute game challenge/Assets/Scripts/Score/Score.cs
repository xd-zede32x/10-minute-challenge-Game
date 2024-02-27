using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private InputKnifeMove _inputKnifeMove;

    private TextMeshProUGUI _textScore;

    private void Start() => _textScore = GetComponent<TextMeshProUGUI>();
    private void Update() => _textScore.text = _score.ToString();

    public void AddScore(Collider2D other)
    {
        Destroy(other.gameObject);
        _inputKnifeMove.IsMoving = false;
        _score++;
    }
}