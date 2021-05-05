//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Singletons;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Haywire.Character
{
	[System.Serializable]
	public struct PlayerAnimations
	{
		//This is a struct that contains all instances of the animations that can be addded to the player.
		public const string PLAYER_IDLE = "Player_Idle";
		public const string PLAYER_RELOADING = "Player_Reload";
		public const string PLAYER_JUMP = "Player_Jump";	
	}

	[DisallowMultipleComponent, RequireComponent(typeof(CharacterMovementComponent))]
	public class CharacterControlComponent : MonoBehaviour, ISoundSystem, IAnimationSystem
	{
		[Header("Character Controller")]
		public GameManagerComponent GameManager;

		public Animator PlayerAnimator;

		[Tooltip("")]
		public Int16 AmmoReloadThreshold;

		[Header("Sounds")]
		public List<AudioSource> ReloadingSounds;

		[HideInInspector]
		public string currentState;


		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.R) && GameManager.AmmoAmount < AmmoReloadThreshold)
			{
				GameManager.AmmoAmount++;
				PlayGameSounds(ReloadingSounds);
			}

			if (Input.GetKey(KeyCode.Escape))
			{
				if (GameManager.IsGamePaused == true)
				{
					GameManager.ResumeGame();
				}
				else
				{
					GameManager.PauseGame();
				}
			}

			if (Input.GetMouseButtonUp(1))
			{
				PlayerAnimator.SetBool("IsIdle", true);
			}

			if (Input.GetMouseButton(1))
			{
				PlayerAnimator.SetBool("IsIdle", false);
			}

		}

		public void ChangeAnimationState(string NewState)
		{
			if (currentState == NewState) return;

			PlayerAnimator.Play(NewState);
		}

		public void PlayGameSounds(List<AudioSource> SoundList)
		{
			if (SoundList.Count > 0)
			{
				var random = new System.Random();
				int SoundIndex = random.Next(SoundList.Count);

				SoundList[SoundIndex].Play();
			}
			else
			{
				Debug.LogWarning("Sound List is empty. This will need elements to play sounds.");
				throw new Exception();
			}
		}

		public void PlayGameSounds(AudioSource Sound)
		{
			throw new NotImplementedException();
		}

		public void StopGameSounds(AudioSource Sound)
		{
			throw new NotImplementedException();
		}

		public void StopGameSounds(List<AudioSource> SoundList)
		{
			throw new NotImplementedException();
		}

	}
}
