using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    public void SwitchGun(Gun gun)
    {
        _gun = gun;
    }

    public void Shoot()
    {
        _gun.Shoot();
    }
}
