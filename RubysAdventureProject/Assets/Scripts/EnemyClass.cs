using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class was generated by me. This was not apart of the tutorial.

public class EnemyClass // this class demonstrates operator overloading
{
    private int damage = -1;
    
    private float speed;

    // In C++, an initialization list would appear as
    // EnemyClass() : damage(0), speed(0.0), vertical(false) {}
    // This would represent a parameterless constructor that sets the variables to default values
    
    // This constructor is a parameterless constructor,
    // which lets objects be created without parameters.
    // It sets the members to default values defined in the constructor.
    public EnemyClass() { 
        damage = -1;
        speed = 1.0f;
    }

    // This constructor has parameters, so when parameters are entered when creating an object,
    // this constructor is used.
    // This sets the variables equal to what was entered when the object was created,
    // but has default values in case all of the parameters are not entered.
    // This constructor will only be called if a parameter is entered at object creation.
    public EnemyClass(int d = -2, float s = 0.0f)
    {
        if (d < 0)
            damage = d;
        else
            damage = -d;
        speed = s;
    }

    // Get functions that allow me to access the private members of this class.
    public int GetDamage() { return damage; }
    public float GetSpeed() { return speed; }
}
