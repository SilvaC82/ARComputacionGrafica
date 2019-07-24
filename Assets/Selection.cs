using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    int selectOption;

    public int bottonPressed;

    private bool bobj1;
    private bool bobj2;
    private bool bobj3;
    private bool bobj4;
    private bool bobj5;
    private bool bobj6;


    public Transform obj1;
    public Transform obj2;
    public Transform obj3;
    public Transform obj4;
    public Transform obj5;
    public Transform obj6;

    public void setBottonPressed(int bottonPressed) {
        this.bottonPressed = bottonPressed;
    }

    // Start is called before the first frame update
    void Start()
    {
        selectOption = 1;

    }

    // Update is called once per frame
    void Update()
    {
        makeVisible(bottonPressed);
    }

    void makeVisible(int bottonPressed) {
        switch (bottonPressed)
        {

            case 0:
                
                obj1.gameObject.active = false;
                obj2.gameObject.active = false;
                obj3.gameObject.active = false;
                obj4.gameObject.active = false;
                obj6.gameObject.active = false;
                obj5.gameObject.active = false;
                //Console.WriteLine("Case 1");
                break;
            case 1:
                obj1.gameObject.active = true;
                obj2.gameObject.active = false;
                obj3.gameObject.active = false;
                obj4.gameObject.active = false;
                obj6.gameObject.active = false;
                obj5.gameObject.active = false;
                //Console.WriteLine("Case 1");
                break;
            case 2:
                obj1.gameObject.active = false;
                obj2.gameObject.active = true;
                obj3.gameObject.active = false;
                obj4.gameObject.active = false;
                obj6.gameObject.active = false;
                obj5.gameObject.active = false;
                //Console.WriteLine("Case 2");
                break;
            case 3:
                obj1.gameObject.active = false;
                obj2.gameObject.active = false;
                obj3.gameObject.active = true;
                obj4.gameObject.active = false;
                obj6.gameObject.active = false;
                obj5.gameObject.active = false;
                //Console.WriteLine("Case 2");
                break;
            case 4:
                obj1.gameObject.active = false;
                obj2.gameObject.active = false;
                obj3.gameObject.active = false;
                obj4.gameObject.active = true;
                obj5.gameObject.active = false;
                obj6.gameObject.active = false;
                //Console.WriteLine("Case 2");
                break;
            case 5:
                obj1.gameObject.active = false;
                obj2.gameObject.active = false;
                obj3.gameObject.active = false;
                obj4.gameObject.active = false;
                obj5.gameObject.active = true;
                obj6.gameObject.active = false;
                //Console.WriteLine("Case 2");
                break;
            case 6:
                obj1.gameObject.active = false;
                obj2.gameObject.active = false;
                obj3.gameObject.active = false;
                obj4.gameObject.active = false;
                obj5.gameObject.active = false;
                obj6.gameObject.active = true;
                //Console.WriteLine("Case 2");
                break;

            default:
                //Console.WriteLine("Default case");
                break;
        }



    }




}
