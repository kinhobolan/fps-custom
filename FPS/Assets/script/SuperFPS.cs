using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SuperFPS : FirstPersonController{

   
    private void Update () {
        if (Input.GetKeyDown(KeyCode.E) ){

            m_GravityMultiplier = 0;
        }
        if (Input.GetKeyUp (KeyCode.E)) {

            m_GravityMultiplier = 3;
        }

        base.Update ();
    }

}
