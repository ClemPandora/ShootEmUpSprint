using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;
    private Vector2 _startPos;
    private void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    { 
        transform.position =new Vector2(_startPos.x + Mathf.Sin(Time.time * horizontalSpeed) * amplitude, transform.position.y - verticalSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit");
        }
    }
}
