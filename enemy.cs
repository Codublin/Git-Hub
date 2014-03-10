using UnityEngine;
using System.Collections;

public class enemy : 
{
	Public Vector3 force = Vector3.zero;
	Public Vector3 velocity = Vector3.zero;



		
		
		
		float maxSpeed = 20.0f
			float mass = 0.0f
				
				
				void update ()
			{
				force +=Seek (target)
				Vector3 acceleration = force/mass;
				velocity +=acceleration * Time.deltatime
				transform.position=velocity*Time.deltatime
				
				force=Vector3.zero
				if(velocity.magnitude> float.eplison);
			}
		{
			Transform.forward=velocity.normalize()
		}
		
	}
