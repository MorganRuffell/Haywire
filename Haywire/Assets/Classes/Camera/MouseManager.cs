//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using Haywire.Systems;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Haywire.UI
{
	[RequireComponent(typeof(CharacterCamera)), DisallowMultipleComponent]
	public class MouseManager : MonoBehaviour
	{
		[Header("Firing Location and Ammo Controller")]
		public GameObject FiringLocation;
		public AmmoRemainingScript ammoController;

		[Header("Target Textures")]
		public Texture2D BaseMouseTexture;
		public Texture2D ShootingReticleTexture;
		public Texture2D NoAmmoRemainingTexture;


		private PhysicsRaycaster PhysicsRaycaster;
		public LayerMask ClickableLayer;

		public Int32 CursorSizeInt = 16;

		[HideInInspector]
		public static bool _CanFire = false;

		// Update is called once per frame
		void Update()
		{
			_CanFire = false;

			RaycastHit raycastHit;

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 60, ClickableLayer.value))
			{
				if (raycastHit.collider.gameObject.tag == "Enemy")
				{
					Cursor.SetCursor(ShootingReticleTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);
					Debug.DrawLine(FiringLocation.transform.position, raycastHit.transform.position);
					Shooting();
				}

				else if (raycastHit.collider.gameObject.tag == "Environment")
				{
					Cursor.SetCursor(BaseMouseTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);
					Shooting();
				}

				else
				{
					Cursor.SetCursor(BaseMouseTexture, new Vector2 (CursorSizeInt, CursorSizeInt), CursorMode.Auto);
				}
			}
		}

		private void Shooting()
		{
			Cursor.SetCursor(ShootingReticleTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);

			if (ammoController.AmmoAmount <= 0)
			{
				Debug.Log("Out of Ammo");
				OutOfAmmo();
			}

			_CanFire = true;
		}

		private void OutOfAmmo()
		{
			Cursor.SetCursor(NoAmmoRemainingTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);	
		}

	}
}
