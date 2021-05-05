//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using Haywire.Systems;
using Haywire.Singletons;
using Haywire.Character;
using Haywire.AI;

namespace Haywire.UI
{
	[RequireComponent(typeof(CharacterCamera)), DisallowMultipleComponent]
	public class MouseManager : MonoBehaviour
	{
		[Header("Game Manager Component")]
		public GameManagerComponent GameManager;

		[Header("Player Animation Controller")]
		public Animator PlayerAnimator;

		[Header("Player Firing Controller")]
		public CharacterFiringController characterFiringController;

		[Header("Firing Location and Ammo Controller")]
		public GameObject FiringLocation;
		public AmmoRemainingScript ammoController;

		[Header("Target Textures")]
		public Texture2D BaseMouseTexture;
		public Texture2D ShootingReticleTexture;
		public Texture2D NoAmmoRemainingTexture;

		private PhysicsRaycaster PhysicsRaycaster;
		public LayerMask ClickableLayer;

		public Int32 CursorSizeInt = 64;

		[HideInInspector, SerializeField]
		public static bool _CanFire = false;

		private RaycastHit raycastHit;

		private void Awake()
		{

		}

		// Update is called once per frame
		void Update()
		{
			//_CanFire = false;
		}
		private void FixedUpdate()
		{
			UISwap();
		}

		private void UISwap()
		{

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 600, ClickableLayer.value))
			{
				if (raycastHit.collider.gameObject.tag == "Enemy")
				{
					CursorSwap(ShootingReticleTexture, CursorSizeInt, true, false);
					Debug.DrawLine(FiringLocation.transform.position, raycastHit.transform.position);
					Shooting();
				}

				else if (raycastHit.collider.gameObject.tag == "Environment" || raycastHit.collider.gameObject.tag == "Untagged")
				{
					CursorSwap(BaseMouseTexture, CursorSizeInt);
					NonTargetShooting();
				}

				else
				{
					CursorSwap(BaseMouseTexture, CursorSizeInt, false, true);
				}
			}
		}

		private void CursorSwap(Texture2D CursorTexture, int CursorDimension, bool CanFire, bool IsIdle)
		{
			Cursor.SetCursor(CursorTexture, new Vector2(CursorDimension, CursorDimension), CursorMode.Auto);
			PlayerAnimator.SetBool("CanFire", CanFire);
			PlayerAnimator.SetBool("IsIdle", IsIdle);
		}

		private void CursorSwap(Texture2D CursorTexture, int CursorDimension)
		{
			Cursor.SetCursor(CursorTexture, new Vector2(CursorDimension, CursorDimension), CursorMode.Auto);
		}

		private void Shooting()
		{
			Cursor.SetCursor(ShootingReticleTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);

			if (GameManager.GetComponent<GameManagerComponent>().AmmoAmount <= 0)
			{
				Debug.Log("Out of Ammo");
				CursorSwap(NoAmmoRemainingTexture, CursorSizeInt);
				return;
			}

			PlayerAnimator.SetBool("CanFire", true);
			_CanFire = true;

			characterFiringController.MuzzleFlash.intensity = characterFiringController.MuzzleFlashLightShootingIntensity;

			raycastHit.collider.gameObject.GetComponent<EnemyHealthComponent>().TakeDamage(characterFiringController.Damage);
		}

		//Method used for when you're not aiming at an enemy
		private void NonTargetShooting()
		{
			if (GameManager.GetComponent<GameManagerComponent>().AmmoAmount <= 0)
			{
				Debug.Log("Out of Ammo");
				CursorSwap(NoAmmoRemainingTexture, CursorSizeInt);
			}

			PlayerAnimator.SetBool("CanFire", true);
			_CanFire = true;
		}


	}
}
