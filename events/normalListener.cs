using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class print : MonoBehaviour
{
    private void OnEnable()
    {
        actualEvent.actualSomethingHappens += clicked;
    }

    private void OnDisable()
    {
        actualEvent.actualSomethingHappens -= clicked;
    }


    public void death()
    {
        print("you died, comming from  " + gameObject.name);
    }
    public void clicked()
    {
        print("lost 10 hp, comming from " + gameObject.name);
    }

}
