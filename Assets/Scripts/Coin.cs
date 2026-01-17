using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private int _points = 1;
    [SerializeField] private float _moveSpeed = 2.5f;

    private GameController _gameController;

    private void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _gameController.AddPoints(_points);
            Destroy(gameObject);
        }
    }

}
