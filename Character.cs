using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    public float speed = 1;
    private bool onScreen;

    private Vector3 position;
    private float width;
    private float height;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }
   
    void OnCollisionEnter2D(Collision2D col)
    {
         GameObject lis = GameObject.FindGameObjectWithTag("GameListener");
         lis.SendMessage("Damage");
    }

    // Update is called once per frame
    float accelx, accely, accelz = 0;
    void Update()
    {
        Vector3 nextPosition;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            nextPosition = this.transform.right * this.speed * Time.deltaTime;
            this.transform.position += nextPosition;
        }
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            nextPosition = -this.transform.right * this.speed * Time.deltaTime;
            this.transform.position += nextPosition;
        }

        
 
        if(Input.GetMouseButton(0))
        {
            Vector3 next = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            next.z = 0;
            next.y = 0;
            transform.position = next;
        }

        Touch t = Input.GetTouch(0);
        if (TouchPhase.Moved == t.phase)
        {
            Vector3 next = Camera.main.ScreenToWorldPoint(t.position);
            next.z = 0;
            next.y = 0;
            transform.position = next;
        }
        
      
          
  
    }
}
