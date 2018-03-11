using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAbilityController : MonoBehaviour {

    Animator anim;
    public GameObject[] abilitiesObjects;
    private Ability[] abilities ;

    private void Start()
    {
        abilities = new Ability[abilitiesObjects.Length];
        for (int i = 0; i < abilitiesObjects.Length; i++)
            abilities[i] = abilitiesObjects[i].GetComponent<Ability>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        for (int i = 0; i < abilities.Length; i++)
        {
            if (Input.GetKeyDown((i+1).ToString()))
            {
                if (!abilities[i].cast())
                    Debug.Log(abilities[i].abilityName + " FAILED");
                //ability animation
            }
        }
        for (int i = 0; i < abilities.Length; i++)
            abilities[i].updateCooldown();
    }
}
