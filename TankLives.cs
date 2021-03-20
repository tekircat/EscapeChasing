using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankLives : MonoBehaviour
{

    public ParticleSystem EksiLive;
    public AudioSource EksiCan;
    public ParticleSystem End;

    public GameObject bulletPrefab;
    public Transform firePoint;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionİnfo)
    {
        if (collisionİnfo.collider.tag == "Enemy")
        {
            PlayerStats.Lives--;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();
            FindObjectOfType<CameraShake>().ShakeIt();
            EksiLive.Play();
            EksiCan.Play();
            End.Play();

        }
        if (collisionİnfo.collider.tag == "Yıldız")
        {
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();            
        }
    }
}