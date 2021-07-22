using UnityEngine;

public class Hexagon : MonoBehaviour
{
    private float _shrinkSpeed;
    private Rigidbody2D _rigidBody;

    private Vector3 _startScale;

    private float _minHexagonScaleSize;

    private void Start()
    {
        InitializeFields();
        SetStartTransformParameters();
    }

    private void InitializeFields()
    {
        _shrinkSpeed = 4f;
        _rigidBody = GetComponent<Rigidbody2D>();
        _startScale = new Vector3(10f, 10f, 1f);
        _minHexagonScaleSize = 0.2f;
    }

    private void SetStartTransformParameters()
    {
        _rigidBody.rotation = Random.Range(0f, 360f);
        transform.localScale = _startScale;
    }

    private void Update()
    {
        ShrinkHexagon();

        if (HexagonTooShrinked())
            DestroyHexagon();
    }

    private void ShrinkHexagon()
    {
        transform.localScale -= Vector3.one * _shrinkSpeed * Time.deltaTime;
    }

    private bool HexagonTooShrinked()
    {
        return transform.localScale.x <= _minHexagonScaleSize;
    }

    private void DestroyHexagon()
    {
        Destroy(gameObject);
    }

    public void SetShrinkSpeed(float shrinkSpeed)
    {
        _shrinkSpeed = shrinkSpeed;
    }
}