using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fire : MonoBehaviour
{
    public GameObject fireItem = null;
    public float BooletTTL = 5;
    public float fireRate = 1;
    public float fhireIndex = 0.000005f;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer < 1 / fireRate) return;

        fireRate += fhireIndex;
        GameObject created = Instantiate(fireItem, new Vector3(transform.position.x, transform.position.y), transform.rotation);
        Destroy(created, BooletTTL);


        _timer = 0;
    }
}
