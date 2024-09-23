using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actualScript : MonoBehaviour
{
    iPlayer _player1;
    iPlayer _player2;

    public actualScript (iPlayer player1, iPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public void mystart()
    {
        print(_player1.doSomething());
        print(_player2.doSomething());
    }
}
