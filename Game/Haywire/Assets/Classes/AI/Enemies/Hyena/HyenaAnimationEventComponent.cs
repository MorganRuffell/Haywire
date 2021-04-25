using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Haywire.AI;

namespace Haywire.AI
{
	public class HyenaAnimationEventComponent : EnemyAnimationEventComponent
	{
		public override void Touch()
		{
			base.Attack();
		}

		public override void Attack()
		{
			base.Attack();
		}

		public override void TakeDamage()
		{
			base.TakeDamage();	
		}

		public override void OnDeath()
		{
			base.OnDeath();
		}
	}
}



