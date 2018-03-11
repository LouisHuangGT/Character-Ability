using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distrub : Ability {

    public GameObject pebble;

    public Vector3 force;

    public override bool cast()
    {
        if (_isInCooldown) return false;

        caster = GameObject.FindGameObjectWithTag("righthand");
        setCastPositon();
        if (pebble == null) return false;
        GameObject ThrowingPebble = Instantiate<GameObject>(pebble, castPosition, castRotation);
        ThrowingPebble.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);

        _isInCooldown = true;
        setCooldownTimer();

        return true;
    }

}
