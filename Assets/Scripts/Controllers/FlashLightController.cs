using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class FlashLightController: BaseController, IOnInitialize
    {
        private Inventory _inventory = new Inventory();
        
        public void OnStart()
        {
            Debug.Log("onstart");
        }
        public override void On()
        {
            base.On();
            _inventory.FlashLight.Light.intensity = 1;
        }
        public override void Off()
        {
            base.Off();
            _inventory.FlashLight.Light.intensity = 0;
        }
        private void Rotation()
        {
            //_flashLight.transform.position = _flashLight
        }
    }
}
