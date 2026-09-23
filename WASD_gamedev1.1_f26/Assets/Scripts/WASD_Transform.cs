using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_Transform : MonoBehaviour
{
    //variables
    public float speed;

    private Vector2 position;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //finding where we are located every frame and adding it to the vector we made
        position = transform.position;

        //if i press w I go up
        if(Input.GetKey(KeyCode.W))
        {
            position.y += speed * Time.deltaTime;
        }
        //if i press s I go down
        if (Input.GetKey(KeyCode.S))
        {
            position.y -= speed * Time.deltaTime;
        }
        //if I press a I go left
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= speed * Time.deltaTime;
        }
        //if I press d I go right
        if (Input.GetKey(KeyCode.D))
        {
            position.x -= speed * Time.deltaTime;
        }
        transform.position = position;
    }
}
