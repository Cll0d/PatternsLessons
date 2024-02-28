using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun : Gun
{
    public override void Shoot()
    {
        Bullet bullet = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
    }
}
