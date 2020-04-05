using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBuilder : MonoBehaviour
{

    public GameObject Prefub = null;

    public int size;
    public float EnemyTTL = 5.2f;
    public float fireRate = 1;
    private float _timer;
    public float randomStart = -4;
    public float randomEnd = 4;
    public float massIndex = 0.0005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer < 1 / fireRate) return;

        Vector3 currentPos = this.transform.position;

        currentPos.x = currentPos.x + Random.Range(randomStart, randomEnd);

        GameObject enemy = Instantiate(Prefub, currentPos, transform.rotation);
        var phisycs = enemy.GetComponent<Rigidbody2D>();
        phisycs.mass += massIndex;
        Destroy(enemy, EnemyTTL);
        _timer = 0;
        massIndex += massIndex;
    }
}
