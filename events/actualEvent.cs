using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class actualEvent : MonoBehaviour
{
    public int hp = 100;
    public GameEvent whenToDo;
    public static event Action actualSomethingHappens;
    // Start is called before the first frame update
    
    public void doSomething(int amount)
    {
        hp -= amount;

        actualSomethingHappens?.Invoke();

        if (hp < 0)
        {
            // example: death
            whenToDo.TriggerEvent();
        }

    }

    private void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
            doSomething(10);
            print("You clicked and this comes from main object called " + gameObject.name);
        }
    }
}
