using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _jumpForce = 8.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _coinPrefab;

    private void Start()
    {
        _playerTransform = transform;

    }

    private void Update()
    {
        

    }
}