using TMPro;
using InputMove;
using UnityEngine;

namespace AddScore
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private int _scoreValue;
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private InputKnifeMove _inputKnifeMove;

        private void Update() => _scoreText.text = _scoreValue.ToString();

        public void AddScore() => _scoreValue++;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (_inputKnifeMove != null &&   _inputKnifeMove.IsMoving)
            {
                Destroy(collision.gameObject);
                AddScore();
            }
        }
    }
}