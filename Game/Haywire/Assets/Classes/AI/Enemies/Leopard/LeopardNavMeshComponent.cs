using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Haywire.AI
{
	public class LeopardNavMeshComponent : MonoBehaviour
	{
		public NavMeshAgent NavMeshComponent;

		[Tooltip("The gameObject to follow")]
		public Transform target;

		[Tooltip("The Unity tag of the thing that we are chasing, this is normally the player.")]
		public string targetTag;


		private void Awake()
		{
			NavMeshComponent = GetComponent<NavMeshAgent>();
			target = GameObject.Find("Player").transform;

			if (!target)
			{
				target = GameObject.FindGameObjectWithTag(targetTag).transform;
			}
		}

		void Update()
		{
			NavMeshComponent.SetDestination(target.position);
		}
	}
}
