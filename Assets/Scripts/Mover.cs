using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverHorizontalmente();
    }

    private void MoverHorizontalmente()
    {
        float x = 0.0f;
        float y = 0.0f;

        //move the object to the right if the right arrow key is pressed
        if (Input.GetKey(KeyCode.RightArrow))
            x = speed;

        //move the object to the left if the left arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
            x = -speed;

        //move the object down if the down arrow key is pressed
        if (Input.GetKey(KeyCode.DownArrow))
            y = -speed;

        //move the object up if the up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow))
            y = speed;

        transform.Translate(x, y, 0);
    }
}
