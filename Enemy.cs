using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Heath = 100;
    public GameObject Explode;
    bool diraction = false;
    int zDir;
    int rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = Random.Range(-4, 4);
        Heath = Random.Range(3, 7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed));
    }

    void OnTriggerEnter2D()
    {
        if(Heath > 0)
        {
            Heath--;
        } else
        {
            Instantiate(Explode, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            Destroy(gameObject);
            GameObject lis = GameObject.FindGameObjectWithTag("GameListener");
            lis.SendMessage("AddScore");
        }
    }
}
