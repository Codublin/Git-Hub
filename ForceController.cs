using UnityEngine;
using System.Collections;

public class ForceController : MonoBehaviour {
	{

		Vector3 force = Vector3.zero;
		Vector3 velocity = Vector3.zero;

		float maxSpeed = 20.0f
		float mass =1.0f

			void start ()
			{

			}

		void Update () {

			force += Seek (enemy);
			Vector3 acc = force / mass;

			velcoity += acc* Time.deltatime;
			transform.position += velocity*Time.deltatime;

			force = Vector3.zero;



		}

		Vector3 Seek(GameObject enemy)
		{
			Vector3 desiredVelocity = enemy.transform.position - transform.position;
			dseiredVelocity.Normalize();
			desiredVelocity*=maxSpeed;


		}


}
