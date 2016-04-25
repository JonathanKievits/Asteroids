using UnityEngine;
using System.Collections;

public class Player2Shooting2_2 : MonoBehaviour {

    public GameObject CannonBall;
    public Transform muzzle2_1_1;
    public Transform muzzle2_1_2;
    public Transform muzzle2_2_1;
    public Transform muzzle2_2_2;
    public float BallSpeed;
    public float fireRate = 0.1F;
    public float nextFire = 0.5F;

    void Update()
    {
        if (Input.GetKey(KeyCode.J) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootLeft2();
        }
        if (Input.GetKey(KeyCode.H) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootRight2();
        }
    }
    private void ShootRight2()
    {
        Projectile newProjectileR2 = Instantiate(
            CannonBall,
            muzzle2_2_2.position,
            muzzle2_2_2.rotation) as Projectile;
        newProjectileR2.SetSpeed(BallSpeed);
    }
    private void ShootLeft2()
    {
        Projectile newProjectileL2 = Instantiate(
            CannonBall,
            muzzle2_1_2.position,
            muzzle2_1_2.rotation) as Projectile;
        newProjectileL2.SetSpeed(BallSpeed);
    }
}
