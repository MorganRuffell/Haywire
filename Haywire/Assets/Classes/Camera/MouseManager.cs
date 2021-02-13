using Haywire.Camera;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Haywire.UI
{
	[RequireComponent(typeof(CharacterCamera))]
	public class MouseManager : MonoBehaviour
	{
		AmmoRemainingScript ammoController;

		[Header("Target Textures")]
		public Texture2D BaseMouseTexture;
		public Texture2D ShootingReticleTexture;
		public Texture2D NoAmmoRemainingTexture;

		private PhysicsRaycaster PhysicsRaycaster;
		public LayerMask ClickableLayer;

		public int CursorSizeInt = 16;

		[Tooltip("Do not touch, key code element")]
		public float YieldReturnTime = 0.5f;


		[HideInInspector]
		public static bool _CanFire = false;

		// Update is called once per frame
		void Update()
		{
			_CanFire = false;

			RaycastHit raycastHit;

			if (Physics.Raycast(UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 50, ClickableLayer.value))
			{
				if (raycastHit.collider.gameObject.tag == "Enemy")
				{
					Cursor.SetCursor(ShootingReticleTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);
					StartCoroutine(Shooting());
				}

				if (raycastHit.collider.gameObject.tag == "Environment")
				{
					Cursor.SetCursor(BaseMouseTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);
					StartCoroutine(Shooting());
				}

				else
				{
					Cursor.SetCursor(BaseMouseTexture, new Vector2 (CursorSizeInt, CursorSizeInt), CursorMode.Auto);
				}
			}
		}

		private IEnumerator Shooting()
		{
			Cursor.SetCursor(ShootingReticleTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);

			if (ammoController.AmmoAmount >= 1)
			{
				_CanFire = true;
			}
			else
			{
				Debug.Log("Out of Ammo");
				OutOfAmmo();
			}
			
			yield return new WaitForSeconds(YieldReturnTime);
		}
		
		private void OutOfAmmo()
		{
			Cursor.SetCursor(NoAmmoRemainingTexture, new Vector2(CursorSizeInt, CursorSizeInt), CursorMode.Auto);	
		}

	}
}
