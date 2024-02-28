using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected Bullet Bullet;
    [SerializeField] protected Transform BulletSpawnPoint;
    [SerializeField] protected float ReloadTime;
    protected float CurrentReloadTime;
    [SerializeField] protected float Magazine;
    protected float CurrentMagazine;

    private void Awake()
    {
        CurrentMagazine = Magazine;
    }

    private void Update()
    {
        if (CurrentReloadTime > 0)
        {
            CurrentReloadTime -= Time.deltaTime;
        }
    }

    public virtual void Shoot()
    {
        if (CurrentReloadTime <= 0 && CurrentMagazine > 0)
        {
            Bullet bullet = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            CurrentMagazine--;
        }
        else if (CurrentMagazine == 0)
        {
            CurrentReloadTime = ReloadTime;
            CurrentMagazine = Magazine;
        }
    }
}
