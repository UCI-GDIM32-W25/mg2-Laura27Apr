using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
   
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private Transform _spawnPoint;

    private float _spawnTimer = 0f;
    private float _spawnInterval;
    private int _points = 0;

    private void Start()
    {
        _spawnInterval = Random.Range(0.5f, 1.5f);
        UpdateUI();
    }

    private void Update()
    {
        _spawnTimer += Time.deltaTime;

        if (_spawnTimer >= _spawnInterval)
        {
            SpawnCoin();
            _spawnTimer = 0f;
            _spawnInterval = Random.Range(0.5f, 1.5f);
        }
    }

    private void SpawnCoin()
    {
        Instantiate(_coinPrefab, _spawnPoint.position, _coinPrefab.transform.rotation);
    }

   private void UpdateUI()
   {
        _pointsText.text = "points: " + _points;
   }

    public void AddPoints(int amount)
   {
        _points += amount;
        UpdateUI();
   }

}