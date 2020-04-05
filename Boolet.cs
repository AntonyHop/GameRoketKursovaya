using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour
{
    public float BooletSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, BooletSpeed * Time.deltaTime));
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("ПУЛЯ ПОПАЛА");
        Destroy(gameObject);
    }
}
