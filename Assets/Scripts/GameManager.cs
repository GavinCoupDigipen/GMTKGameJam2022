//------------------------------------------------------------------------------
//
// File Name:	GameManager.cs
// Author(s):	Gavin Cooper (gavin.cooper)
// Project:	    GMTK GameJam 2022
//
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManger : MonoBehaviour
{
    // The player
    public static GameObject player;

    // Weapons
    public static UnityEvent WeaponUpdate = new UnityEvent();
    private static GameObject _primaryWeapon;
    public static GameObject primaryWeapon
    {
        get
        {
            return _primaryWeapon;
        }
        set
        {
            _primaryWeapon = value;
            WeaponUpdate.Invoke();
        }
    }
    public static GameObject secondaryWeapon;

    // Health
    public static int maxHealth = 6;
    public static UnityEvent CurrentHealthUpdate = new UnityEvent();
    private static int _currentHealth = 6;
    public static int currentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            CurrentHealthUpdate.Invoke();
        }
    }
}
