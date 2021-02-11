using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;
    private Vector2 _startPos;
    private float _delay;
    private Vector2 _screenBounds;
    private float _objectHeight;
    private void Start()
    {
        _startPos = transform.position;
        _delay = Random.Range(0f, 10f);
        _screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    void Update()
    { 
        transform.position = new Vector2(_startPos.x + Mathf.Sin(Time.time * horizontalSpeed + _delay) * amplitude, transform.position.y - verticalSpeed * Time.deltaTime);
        if (transform.position.y < -_screenBounds.y - _objectHeight)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHealth>() != null)
        {
            other.GetComponent<PlayerHealth>().TakeDamage(1);
            Destroy(gameObject);
        }
    }

    public void Damage()
    {
        Destroy(gameObject);
    }
}
