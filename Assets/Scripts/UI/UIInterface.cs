using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class UIInterface : MonoBehaviour
    {
        private BatteryCharge _batteryCharge;

        public BatteryCharge BatteryCharge
        {
            get
            {
                if (!_batteryCharge)
                {
                    _batteryCharge = GameObject.FindObjectOfType<BatteryCharge>();
                }

                return _batteryCharge;
            }

            set
            {
                _batteryCharge = value;
            }

        }
    }
}
