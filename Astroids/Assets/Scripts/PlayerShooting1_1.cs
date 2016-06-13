using UnityEngine;
using System.Collections;

public class PlayerShooting1_1 : MonoBehaviour
{

    public GameObject CannonBall;
    public Transform muzzle1_1_1;
    public Transform muzzle1_1_2;
    public Transform muzzle1_2_1;
    public Transform muzzle1_2_2;
    public float BallSpeed;
    public float fireRate = 0.1F;
    public float nextFire = 0.2F;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootLeft1(); 
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootRight1();
        }
        if (Input.GetKey(KeyCode.Mouse1) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootLeft1();
        }
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            ShootRight1();
        }
    }

    private void ShootRight1()
    {
        Projectile newProjectileR1 = Instantiate(
            CannonBall,
            muzzle1_2_1.position,
            muzzle1_2_1.rotation) as Projectile;
        newProjectileR1.SetSpeed(BallSpeed);
    }
    private void ShootLeft1()
    {
        Projectile newProjectileL1 = Instantiate(
            CannonBall,
            muzzle1_1_1.position,
            muzzle1_1_1.rotation) as Projectile;
        newProjectileL1.SetSpeed(BallSpeed);
    }
}