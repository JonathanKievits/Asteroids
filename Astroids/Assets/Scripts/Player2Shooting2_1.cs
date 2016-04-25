using UnityEngine;
using System.Collections;

public class Player2Shooting2_1 : MonoBehaviour {

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

            ShootLeft1();
        }
        if (Input.GetKey(KeyCode.H) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootRight1();
        }
    }

    private void ShootRight1()
    {
        Projectile newProjectileR1 = Instantiate(
            CannonBall,
            muzzle2_2_1.position,
            muzzle2_2_1.rotation) as Projectile;
        newProjectileR1.SetSpeed(BallSpeed);
    }
    private void ShootLeft1()
    {
        Projectile newProjectileL1 = Instantiate(
            CannonBall,
            muzzle2_1_1.position,
            muzzle2_1_1.rotation) as Projectile;
        newProjectileL1.SetSpeed(BallSpeed);
    }
}
