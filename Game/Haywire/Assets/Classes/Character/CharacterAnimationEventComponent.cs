using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haywire.Character
{
	public class CharacterAnimationEventComponent : MonoBehaviour
	{
		[Header("Required Components that have animation events")]
		public CharacterMovementComponent characterMovementComponent;
		public CharacterControlComponent characterControlComponent;

		//Called when the players foot touches the ground
		public void Touch()
		{
			characterMovementComponent.PlayGameSounds(characterMovementComponent.MovementSounds);
		}

		public void Reload()
		{
			characterControlComponent.PlayGameSounds(characterControlComponent.ReloadingSounds);
		}
	}
}
