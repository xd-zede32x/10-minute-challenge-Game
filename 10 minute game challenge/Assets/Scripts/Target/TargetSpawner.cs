using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _initialDelay;
    [SerializeField] private float _repeatRate;

    private void Start() => StartCoroutine(SpawnTargetRepeatedly());

    private IEnumerator SpawnTargetRepeatedly()
    {
        yield return new WaitForSeconds(_initialDelay);

        while (true)
        {
            Instantiate(_target, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(_repeatRate);
        }
    }
}