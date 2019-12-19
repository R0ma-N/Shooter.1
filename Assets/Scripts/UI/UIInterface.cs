using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class UIInterface
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
