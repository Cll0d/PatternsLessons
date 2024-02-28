using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun
{
    public override void Shoot()
    {
        if (CurrentReloadTime <= 0 && CurrentMagazine > 0)
        {
            //Я тоже не знаю как нормально реализовать мультишот
            //Думал попробовать дробь сделать через рандом но скилла не хватает додуматься 
            for (int i = -1; i < 2; i++)
            {
                Bullet bullet = Instantiate(Bullet, BulletSpawnPoint.position + Vector3.right * i, Quaternion.identity);
            }
            CurrentMagazine--;
        }
        else if (CurrentMagazine == 0)
        {
            CurrentReloadTime = ReloadTime;
            CurrentMagazine = Magazine;
        }
    }
}
