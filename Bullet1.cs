using UnityEngine;

public class Bullet1 : MonoBehaviour
{
	private Transform target;
	public float speed = 5f;
	public int damage = 50;
	public float explosionRadius = 0f;
	public GameObject impactEffect;

	void Update()
	{
		Destroy(gameObject, 8);
	}

	void OnCollisionEnter(Collision collisionİnfo)
	{
		if (collisionİnfo.collider.tag == "Enemy")
			HitTarget();
			
		if (collisionİnfo.collider.tag == "Yıldız")
			HitTarget();
	}

	void HitTarget()
	{
		GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(effectIns, 5f);

		if (explosionRadius > 0f)
			Explode();

		Destroy(gameObject);
	}

	void Explode()
	{
		Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
		foreach (Collider collider in colliders)
		{
			if (collider.tag == "Enemy")
				Damage(collider.transform);

			if (collider.tag == "Yıldız")
				Damage(collider.transform);
		}
	}

	void Damage(Transform enemy)
	{
		Enemy e = enemy.GetComponent<Enemy>();

		if (e != null)
			e.TakeDamage(damage);
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, explosionRadius);
	}
}
