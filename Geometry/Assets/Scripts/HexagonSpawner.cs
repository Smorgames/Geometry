using UnityEngine;

public class HexagonSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _hexagon;
    [SerializeField] private float _spawnRate;

    private float _counter;

    private void Start()
    {
        InitializeFields();
    }

    private void InitializeFields()
    {
        _spawnRate = 1f;
        _counter = 0.0f;
    }

    void Update()
    {
        Countdown();

        if (CounterCountedDownSpawnTime())
        {
            SpawnHexagon();
            _counter = 0f;
        }
    }

    private void Countdown()
    {
        _counter += Time.deltaTime;
    }

    private bool CounterCountedDownSpawnTime()
    {
        return _counter >= _spawnRate;
    }

    private GameObject SpawnHexagon()
    {
        return (GameObject)Instantiate(_hexagon, transform.position, Quaternion.identity);
    }
}