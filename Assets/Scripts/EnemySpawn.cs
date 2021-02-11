using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnRate = 0.5f;
    private Vector2 _screenBounds;
    public Enemy[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        InvokeRepeating(nameof(Spawn),0,spawnRate);
    }
    
    void Spawn()
    {
        var enemy = enemies[Random.Range(0,enemies.Length)];
        var objectWidth = enemy.transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        var objectHeigth = enemy.transform.GetComponent<SpriteRenderer>().bounds.extents.y;
        Instantiate(enemy, new Vector2(Random.Range(-_screenBounds.x + objectWidth, _screenBounds.x - objectWidth), _screenBounds.y + objectHeigth), transform.rotation);
    }
}
