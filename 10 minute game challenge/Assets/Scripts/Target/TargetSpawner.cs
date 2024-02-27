using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private Target _target;

    private void Start() => InvokeRepeating("SpawnTarget", 2f, 1f);

    private void SpawnTarget() => Instantiate(_target);
}