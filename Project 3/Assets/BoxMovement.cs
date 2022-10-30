using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public float rotateSpeed;



    [SerializeField]
    Transform rotationCenter;

    [SerializeField]
    float rotationRadius = 2f;

    float posX, posY, angle = 0f;
    private void Update()
    {
        
        
        //angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f)
            angle = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
            posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
            gameObject.transform.Rotate(0f, 0f, 10f * Time.deltaTime * rotateSpeed);
            transform.position = new Vector2(posX, posY);
            angle = angle + Time.deltaTime * rotateSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
            posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
            gameObject.transform.Rotate(0f, 0f, -10f * Time.deltaTime * rotateSpeed);
            transform.position = new Vector2(posX, posY);
            angle = angle - Time.deltaTime * rotateSpeed;
        }
    }
}
