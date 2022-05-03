using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo
{

    public PlayerInfo()
    {
        Setup();
    }

    private GameObject _PlayerObj;
    private GameObject _PlayerModel;


    Quaternion LookDirection
    {
        get
        {
            return _PlayerModel.transform.rotation;
        }
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
        if (_PlayerAmmo - AmmoUsed >= 0)
        {
            //Get rid of that ammo 
            _PlayerAmmo -= AmmoUsed;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Updates the players model to look at the mouse 
    /// </summary>
    /// <returns></returns>
    public void UpdateLookDirection()
    {

        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            Vector3 newPos = new Vector3(hitInfo.point.x, _PlayerModel.transform.position.y, hitInfo.point.z);
            _PlayerModel.transform.LookAt(newPos);

        }
    }

    private void Setup()
    {
        _PlayerObj = GameManager.Singleton.GetPlayerObject();
        _PlayerModel = _PlayerObj.transform.GetChild(1).gameObject;
    }
}
