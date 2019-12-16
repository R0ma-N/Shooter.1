using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class FlashLightController: BaseController , IOnInitialize, IOnUpdate
    {
        public FlashLightModel _flashLight = Object.FindObjectOfType<FlashLightModel>();
        
        public void OnStart()
        {
            _flashLight.currentCharge = _flashLight.maxCharge;
            _flashLight.Light.intensity = 0;
            IsActive = false;
        }
        public override void On()
        {
            Debug.Log("on");
            base.On();
            _flashLight.Light.intensity = 1;
        }
        public override void Off()
        {
            Debug.Log("off");
            base.Off();
            _flashLight.Light.intensity = 0;
        }

        private void Rotation()
        {
            //_flashLight.transform.position = _flashLight
        }

        public void OnUpdate()
        {
            if (IsActive && _flashLight.currentCharge > 0)
            {
                DecreaseCharge();
            }
            
            if (!IsActive && _flashLight.currentCharge < _flashLight.maxCharge)
            {
                IncreaseCharge();
            }
            Debug.Log(IsActive);
        }

        private void DecreaseCharge()
        {
            _flashLight.currentCharge -= Time.deltaTime;
        }

        private void IncreaseCharge()
        {
            _flashLight.currentCharge += Time.deltaTime;
        }
    }
}
