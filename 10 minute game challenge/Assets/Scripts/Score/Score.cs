using InputMove;
using TMPro;
using UnityEngine;

namespace AddScore
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private int _score;
        [SerializeField] private InputKnifeMove _inputKnifeMove;
        [SerializeField] private TextMeshProUGUI _scoreText;

        private void Update() => _scoreText.text = _score.ToString();

        public void AddScore() => _score++;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (_inputKnifeMove.IsMoving)
            {
                Destroy(collision.gameObject);
                AddScore();
            }
        }
    }
}