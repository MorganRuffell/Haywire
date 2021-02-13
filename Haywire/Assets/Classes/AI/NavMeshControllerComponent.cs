//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////     
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Haywire.AI
{
	[RequireComponent(typeof(EnemyDamageComponent))]
	[RequireComponent(typeof(NavMeshAgent))]
	public class NavMeshControllerComponent : MonoBehaviour
	{
		public float patrolTime = 15;
		public float aggroRange = 10;
		public Transform[] waypoints;

		int index;
		float speed, agentSpeed;
		Transform Player;

		Animator EnemyAnimator;
		NavMeshAgent NavMesh;

		private void Awake()
		{
			EnemyAnimator = GetComponent<Animator>();
			NavMesh = GetComponent<NavMeshAgent>();

			if (NavMesh)
			{
				agentSpeed = NavMesh.speed;
			}
			else
			{
				try
				{
					throw new NotImplementedException();
				}
				catch (System.NotImplementedException)
				{
					Debug.LogWarning("There is no NavMesh component on this controller");
					Debug.Break();
				}
			}

			Player = GameObject.FindGameObjectWithTag("Player").transform;
			index = UnityEngine.Random.Range(0, waypoints.Length);

			if (waypoints.Length > 0)
			{
				InvokeRepeating("Patrol", 0, patrolTime);
			}
		}

		void Patrol()
		{
			index = index == waypoints.Length - 1 ? 0 : index + 1;
		}

		private void Update()
		{
			NavMesh.destination = waypoints[index].position;
			NavMesh.speed = agentSpeed;

			if (Player && Vector3.Distance(transform.position, Player.position) < aggroRange)
			{
				NavMesh.destination = Player.position;
				NavMesh.speed = agentSpeed;
			}
		}
	}
}
