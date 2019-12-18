using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class FlashLightController: BaseController , IOnInitialize, IOnUpdate
    {
        public FlashLightModel _flashLight = Object.FindObjectOfType<FlashLightModel>();
        public UIInterface UIInterface = new UIInterface();

        public void OnStart()
        {
            _flashLight.currentCharge = _flashLight.maxCharge;
            _flashLight.Light.enabled = false;
            UIInterface.BatteryCharge.UIBattery.enabled = false;
        }
        public void OnUpdate()
        {
            if (_flashLight.IsOn)
            {
                if (_flashLight.currentCharge > 0)
                {
                    DecreaseCharge();
                }
                else 
                {
                    Switch();
                }   
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
            UIInterface.BatteryCharge.UIBattery.enabled = true;
        }
        public override void Off()
        {
            base.Off();
            _flashLight.Light.enabled = false;
            _flashLight.IsOn = false;
            UIInterface.BatteryCharge.UIBattery.enabled = false;
        }
        private void Rotation()
        {
            //_flashLight.transform.position = _flashLight
        }


        private void DecreaseCharge()
        {
            _flashLight.currentCharge -= Time.deltaTime;

            if (_flashLight.currentCharge < _flashLight.maxCharge - _flashLight.maxCharge / 6)
            {
                UIInterface.BatteryCharge.UIBatteryDevisions[5].enabled = false;

                if (_flashLight.currentCharge < _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 2)
                {
                    UIInterface.BatteryCharge.UIBatteryDevisions[4].enabled = false;

                    if (_flashLight.currentCharge < _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 3)
                    {
                        UIInterface.BatteryCharge.UIBatteryDevisions[3].enabled = false;

                        for (int i = 0; i < 3; i++)
                        {
                            UIInterface.BatteryCharge.UIBatteryDevisions[i].color = new Color32(225, 112, 52, 255);
                        }

                        if (_flashLight.currentCharge < _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 4)
                        {
                            UIInterface.BatteryCharge.UIBatteryDevisions[2].enabled = false;

                            if (_flashLight.currentCharge < _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 5)
                            {
                                UIInterface.BatteryCharge.UIBatteryDevisions[1].enabled = false;
                                UIInterface.BatteryCharge.UIBatteryDevisions[0].color = Color.red;   
                            }
                        }
                    }
                }
            }
        }

        private void IncreaseCharge()
        {
            _flashLight.currentCharge += Time.deltaTime;
            if(_flashLight.currentCharge > _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 5)
            {
                UIInterface.BatteryCharge.UIBatteryDevisions[1].enabled = true;
                UIInterface.BatteryCharge.UIBatteryDevisions[0].color = new Color32(225, 112, 52, 255);

                if (_flashLight.currentCharge > _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 4)
                {
                    UIInterface.BatteryCharge.UIBatteryDevisions[2].enabled = true;

                    if (_flashLight.currentCharge > _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 3)
                    {
                        UIInterface.BatteryCharge.UIBatteryDevisions[3].enabled = true;
                        for (int i = 0; i < 3; i++)
                        {
                            UIInterface.BatteryCharge.UIBatteryDevisions[i].color = new Color32(0,147,17,255);
                        }

                        if (_flashLight.currentCharge < _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 2)
                        {
                            UIInterface.BatteryCharge.UIBatteryDevisions[4].enabled = true;

                            if (_flashLight.currentCharge < _flashLight.maxCharge - (_flashLight.maxCharge / 6) * 2)
                            {
                                UIInterface.BatteryCharge.UIBatteryDevisions[5].enabled = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
