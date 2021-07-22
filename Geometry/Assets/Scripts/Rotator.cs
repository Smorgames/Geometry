using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 30f;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * _speed);
    }
}