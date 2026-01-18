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
        _spawnInterval = Random.Range(0.2f, 1.5f);
        UpdateUI();
    }

    private void Update()
    {
        _spawnTimer += Time.deltaTime;

        if (_spawnTimer >= _spawnInterval)
        {
            SpawnCoin();
            _spawnTimer = 0f;
            _spawnInterval = Random.Range(0.2f, 1.5f);
        }
    }

    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(_coinPrefab, _spawnPoint.position, _coinPrefab.transform.rotation);

        Coin coinScript = newCoin.GetComponent<Coin>();

        if (coinScript != null)
        {
            coinScript.gameController = this;
        }
    }

   private void UpdateUI()
   {
        _pointsText.text = "Points: " + _points;
   }

    public void AddPoints(int amount)
   {
        _points += amount;
        UpdateUI();
   }

}