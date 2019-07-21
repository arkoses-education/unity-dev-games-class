using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField]
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody2D = transform.GetComponent<Rigidbody2D>();
        Debug.Log("Metodo de inicio");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        movement();
    }

    public void movement(){
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.speed * Input.GetAxis("Horizontal"),0);
    }
}
