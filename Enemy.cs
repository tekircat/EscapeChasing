using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 50f;
    public float startHealth = 100;
    private float health;
    public int worth = 50;
    private static float elmas;
    public int elmassayý;
    public GameObject deathEffect;
    [Header("Unity Stuff")]
    public Image healthBar;
    private bool isDead = false;

    void Start()
    {
        health = startHealth;

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
            Die();
    }

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * -speed);
        elmas = PlayerPrefs.GetFloat("elmas");
    }

    public void Die()
    {
        isDead = true;

        PlayerStats.Money += worth;

        elmas += elmassayý;
        PlayerPrefs.SetFloat("elmas", elmas);

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}