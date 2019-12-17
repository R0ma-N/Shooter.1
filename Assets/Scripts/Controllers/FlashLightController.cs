using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class FlashLightController: BaseController , IOnInitialize, IOnUpdate
    {
        public FlashLightModel _flashLight = Object.FindObjectOfType<FlashLightModel>();
        private BatteryCharge _batteryCharge;
        
        public void OnStart()
        {
            _batteryCharge = new BatteryCharge();
            _flashLight.currentCharge = _flashLight.maxCharge;
            _flashLight.Light.enabled = false;
        }
        public void OnUpdate()
        {
            if (_flashLight.IsOn && _flashLight.currentCharge > 0)
            {
                DecreaseCharge();
            }

            if (!_flashLight.IsOn && _flashLight.currentCharge < _flashLight.maxCharge)
            {
                IncreaseCharge();
            }
        }
        public override void On()
        {
            base.On();
            _flashLight.Light.enabled = true;
            _flashLight.IsOn = true;
            _batteryCharge._char6[0].enabled = false;
        }
        public override void Off()
        {
            Debug.Log("off");
            base.Off();
            _flashLight.Light.enabled = false;
            _flashLight.IsOn = false;
        }

        private void Rotation()
        {
            //_flashLight.transform.position = _flashLight
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
