using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _jumpForce = 8.0f;
    [SerializeField] private float _jump;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Rigidbody2D _rigidbody;

    private bool _isGrounded = true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;

            _rigidbody.velocity = new Vector2(
                _rigidbody.velocity.x,
                _jump
            );
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameobject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }



    
}