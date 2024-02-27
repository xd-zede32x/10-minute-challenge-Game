using UnityEngine;

public class InputKnifeMove : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private KnifeMove _knifeMove;
    [SerializeField] private KnifeLose _knifeLose;

    public bool IsMoving
    {
        get { return _isMoving; }
        set { _isMoving = value; }
    }

    private bool _isMoving;

    private void Update() => InputMove();

    public void InputMove()
    {
        if (Input.GetMouseButtonDown(0))
            _isMoving = true;

        _knifeMove.Move();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!_isMoving)
            _knifeLose.RestartGame();

        else
            _score.AddScore(other);
    }
}