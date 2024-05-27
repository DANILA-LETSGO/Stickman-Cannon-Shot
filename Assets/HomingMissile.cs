using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissile : MonoBehaviour
{
	// цель для ракеты
	public Transform target;
	// префаб взрыва
	public GameObject explosionPrefab;
	// скорость ракеты
	public float speed = 10;
	// скорость поворота ракеты
	public float turnSpeed = 100;
	// время до взрыва
	public float explosionTime = 5;


	public void Update()
	{
		// уменьшаем таймер
		explosionTime -= Time.deltaTime;

		// если время таймера истекло, то взрываем ракету
		if (explosionTime <= 0)
		{
			Explode();
			return;
		}


		// величина движения вперед
		Vector3 movement = transform.forward * speed * Time.deltaTime;

		// если указана цель
		if (target != null)
		{
			// направление на цель
			Vector3 direction = target.position - transform.position;

			// максимальный угол поворота в текущий кадр
			float maxAngle = turnSpeed * Time.deltaTime;

			// угол между направлением на цель и направлением ракеты
			float angle = Vector3.Angle(transform.forward, direction);

			if (angle <= maxAngle)
			{
				// угол меньше максимального, значит поворачиваем на цель
				transform.forward = direction.normalized;
			}
			else
			{
				//сферическая интерполяция направления с использованием максимального угла поворота
				transform.forward = Vector3.Slerp(transform.forward, direction.normalized, maxAngle / angle);
			}

			// расстояние до цели
			float distanceToTarget = direction.magnitude;

			// если расстояние мало, то создаем взрыв
			if (distanceToTarget < movement.magnitude)
			{
				Explode();
				return;
			}
		}

		// двигамет ракету вперед
		transform.position += movement;
	}

	public void Explode()
	{
		if (explosionPrefab != null)
		{
			Instantiate(explosionPrefab, transform.position, transform.rotation);
		}
		// уничтожаем ракету
		Destroy(gameObject);
	}

	// взрываем при коллизии
	public void OnCollisionEnter()
	{
		Explode();
	}
}  