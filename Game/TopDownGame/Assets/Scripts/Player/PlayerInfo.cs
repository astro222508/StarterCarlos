using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo 
{

    public PlayerInfo()
    {

    }


    /// <summary>
    /// Actual player health
    /// </summary>
    private int _PlayerHealth = 5;


    /// <summary>
    /// Amount of ammmo player has 
    /// </summary>
    private int _PlayerAmmo = 3; 


    /// <summary>
    /// Check if the player can fire a sword forward
    /// </summary>
    /// <param name="AmmoUsed"></param>
    /// <returns></returns>
    public bool CheckAmmoSupply(int AmmoUsed = 1)
    {
        //Check if player can use that ammo
        if(_PlayerAmmo - AmmoUsed >= 0)
        {
            //Get rid of that ammo 
            _PlayerAmmo -= AmmoUsed;
            return true;
        }

        return false;
    }

}
