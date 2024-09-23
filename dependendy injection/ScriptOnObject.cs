using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptOnObject : MonoBehaviour
{


    private void Start()
    {
    actualScript script = new actualScript(new realPlayer(), new computer_player());

        script.mystart();
    }

}
