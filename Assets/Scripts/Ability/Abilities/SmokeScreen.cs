using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeScreen : Ability {

    public GameObject smokeScreen;

    public override bool cast()
    {
        if (_isInCooldown) return false;
        caster = GameObject.FindGameObjectWithTag("character");
        setCastPositon();
        if (smokeScreen == null) return false;

        GameObject Screen = Instantiate<GameObject>(smokeScreen, castPosition, castRotation);

        _isInCooldown = true;
        setCooldownTimer();
        return true;
    }

   
}
