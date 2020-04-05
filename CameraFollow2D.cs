using UnityEngine;
using System.Collections;

public class CameraFollow2D : MonoBehaviour
{
    private Transform player;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 2);

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player)
        {
           Vector3 vec = Vector3.Lerp(
                new Vector3(0, transform.position.y, -1),
                player.position + offset,
                Time.deltaTime * smooth);
            vec.z = -1;
            vec.x = 0;

            transform.position = vec;
        }
    }
}