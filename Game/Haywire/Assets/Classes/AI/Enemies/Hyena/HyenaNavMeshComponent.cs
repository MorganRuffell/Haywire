//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.Jobs;

namespace Haywire.AI
{
	//Lets have a crack at multithreading?

	[RequireComponent(typeof(NavMeshAgent))]
	public class HyenaNavMeshComponent : MonoBehaviour
	{
		public NavMeshAgent NavMeshComponent;

		[Tooltip("The gameObject to follow")]
		public Transform target;

		[Tooltip("The Unity tag of the thing that we are chasing, this is normally the player.")]
		public string targetTag;


		private void Awake()
		{
			NavMeshComponent = GetComponent<NavMeshAgent>();
			target = GameObject.FindGameObjectWithTag("Player").transform;

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


