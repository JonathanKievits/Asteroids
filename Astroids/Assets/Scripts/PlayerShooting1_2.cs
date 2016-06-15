using UnityEngine;
using System.Collections;

public class PlayerShooting1_2 : MonoBehaviour
{

    public GameObject CannonBall;
    public Transform muzzle1_1_1;
    public Transform muzzle1_1_2;
    public Transform muzzle1_2_1;
    public Transform muzzle1_2_2;
    public float BallSpeed;
    public float fireRate = 0.1F;
    public float nextFire = 0.5F;
    public ParticleSystem particles1;
    public ParticleSystem particles2;
    public ParticleSystem particles3;
    public ParticleSystem particles4;
    public AudioSource audio;
    public AudioClip ShotSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles1.Play();
            particles2.Play();
            audio.PlayOneShot(ShotSound);
            ShootLeft1();
        }
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles3.Play();
            particles4.Play();
            audio.PlayOneShot(ShotSound);
            ShootRight1();
        }
        if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles1.Play();
            particles2.Play();
            audio.PlayOneShot(ShotSound);
            ShootLeft1();
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles3.Play();
            particles4.Play();
            audio.PlayOneShot(ShotSound);
            ShootRight1();
        }
    }

    private void ShootRight1()
    {
        Projectile newProjectileR1 = Instantiate(
            CannonBall,
            muzzle1_2_2.position,
            muzzle1_2_2.rotation) as Projectile;
        newProjectileR1.SetSpeed(BallSpeed);
    }
    private void ShootLeft1()
    {
        Projectile newProjectileL1 = Instantiate(
            CannonBall,
            muzzle1_1_2.position,
            muzzle1_1_2.rotation) as Projectile;
        newProjectileL1.SetSpeed(BallSpeed);
    }
}