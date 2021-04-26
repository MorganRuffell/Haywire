using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Haywire.Gameplay
{
    public class DirectionalLightController : MonoBehaviour
    {
        [Header("Components")]
        public Light lightComponent;
        public Transform LightGameObjectTransform;

        [Header("Target RotationValues")]
        public float xIncrement = 0.001f;
        private float yIncrement = 0.0f;
        private float zIncrement = 0.0f;

        public float RotationXTarget = -170; 
        public float RotationYTarget;
        public float RotationZTarget;

        private float RotationXBase;


        [Header("Target Intensity Values")]
        public float TimeExponent;

        public float TargetIntensity;
        private float BaseIntensity;

        public float RealtimeShadowIntensity;
        private float BaseRealitimeShadowIntensity;

        // Start is called before the first frame update
        void Start()
        {
            RotationXBase = this.transform.rotation.x;
            BaseIntensity = lightComponent.intensity;
            BaseRealitimeShadowIntensity = lightComponent.shadowStrength;
        }

        // Update is called once per frame
        void Update()
        {
            if (lightComponent.intensity != TargetIntensity)
            {
                DarkerOverTime();
            }

            if(this.transform.rotation.x == RotationXTarget)
            {
                RotateLight();
			}
        }
        
        private void RotateLight()
        {
            this.transform.Rotate(xIncrement, yIncrement, zIncrement, Space.Self);
		}

		private void DarkerOverTime()
		{
            //Creating a double called intensity, C# will do this for us with var
            //this is called delta because it is the space between values, the delta of them.
            var delta = TargetIntensity - lightComponent.intensity;

            delta *= Time.deltaTime / TimeExponent;

            lightComponent.intensity += delta;
		}
	}
}
