using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private int _points = 1;
    [SerializeField] private float _moveSpeed = 2.5f;

    public GameController gameController;

    private void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            if (gameController != null)
            {
                gameController.AddPoints(1);
            }

            Destroy(gameObject);
        }

    }

}
