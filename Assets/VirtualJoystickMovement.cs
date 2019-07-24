using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoystickMovement : MonoBehaviour
{
    private Image bgImg;
    private Image joystickImg;
    private Vector3 inputVector;
    public Transform obj1;
    public Transform obj2;
    public Transform obj3;
    public Transform obj4;
    public Transform obj5;
    public Transform obj6;

    public int speed = 100;

    //Para el resize
    float x1, x2, x3, x4, x5, x6;
    float y1, y2, y3, y4, y5, y6;
    float z1, z2, z3, z4, z5, z6;
    Vector3 newSize;


    private void Start()
    {

        x1 = obj1.localScale.x; y1 = obj1.localScale.y; z1 = obj1.localScale.z;
        x2 = obj2.localScale.x; y2 = obj2.localScale.y; z2 = obj2.localScale.z;
        x3 = obj3.localScale.x; y3 = obj3.localScale.y; z3 = obj3.localScale.z;
        x4 = obj4.localScale.x; y4 = obj4.localScale.y; z4 = obj4.localScale.z;
        x5 = obj5.localScale.x; y5 = obj5.localScale.y; z5 = obj5.localScale.z;
        x6 = obj6.localScale.x; y6 = obj6.localScale.y; z6 = obj6.localScale.z;

        bgImg = GetComponent<Image>();
        joystickImg = transform.GetChild(0).GetComponent<Image>();
        //player2.gameObject.active = false;

    }

    void Update()
    {


        //Debug.Log(inputVector);
        moveCharacter(inputVector * (-1));

    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            //Debug.Log("Hola Mundo");



            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

            inputVector = new Vector3(pos.x * 2 + 1, 0, pos.y * 2 - 1);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;
            //Move Joystick

            joystickImg.rectTransform.anchoredPosition = new Vector3(inputVector.x * (bgImg.rectTransform.sizeDelta.x / 3), inputVector.z * (bgImg.rectTransform.sizeDelta.y / 3));


            Debug.Log(inputVector);


        }

    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);

    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        joystickImg.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float Horizontal()
    {
        if (inputVector.x != 0)
        {
            return inputVector.x;
        }
        else
        {
            return Input.GetAxis("Horizontal");
        }
    }
    public float Vertical()
    {
        if (inputVector.z != 0)
        {
            return inputVector.z;
        }
        else
        {
            return Input.GetAxis("Vertical");
        }
    }
    void moveCharacter(Vector3 direction)
    {


        if (direction.x > 0 & direction.z > 0)
        {
            x1 += 10 * Time.deltaTime;
            x2 += 0.1f * Time.deltaTime;
            x3 += 1 * Time.deltaTime;
            x4 += 0.1f * Time.deltaTime;
            x5 += 25 * Time.deltaTime;
            x6 += 25 * Time.deltaTime;

        }
        if (direction.x < 0 & direction.z < 0)
        {
            x1 -= 10 * Time.deltaTime;
            x2 -= 0.1f * Time.deltaTime;
            x3 -= 1 * Time.deltaTime;
            x4 -= 0.1f * Time.deltaTime;
            x5 -= 25 * Time.deltaTime;
            x6 -= 25 * Time.deltaTime;

        }
        if (direction.x > 0 & direction.z < 0)
        {
            z1 += 10 * Time.deltaTime;
            z2 += 0.1f * Time.deltaTime;
            z3 += 1 * Time.deltaTime;
            z4 += 0.1f * Time.deltaTime;
            z5 += 25 * Time.deltaTime;
            z6 += 25 * Time.deltaTime;

        }
        if (direction.x < 0 & direction.z > 0)
        {
            z1 -= 10 * Time.deltaTime;
            z2 -= 0.1f * Time.deltaTime;
            z3 -= 1 * Time.deltaTime;
            z4 -= 0.1f * Time.deltaTime;
            z5 -= 25 * Time.deltaTime;
            z6 -= 25 * Time.deltaTime;

        }

        obj1.localScale = new Vector3(x1, y1, z1);
        obj2.localScale = new Vector3(x2, y2, z2);
        obj3.localScale = new Vector3(x3, y3, z3);
        obj4.localScale = new Vector3(x4, y4, z4);
        obj5.localScale = new Vector3(x5, y5, z5);
        obj6.localScale = new Vector3(x6, y6, z6);


    }


}
