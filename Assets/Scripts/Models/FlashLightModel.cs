using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public sealed class FlashLightModel : BaseObjectModel
    {
        public Light Light { get; private set; }
        public float maxCharge = 10;
        public float currentCharge;
        public Transform GoFollow;
        public Vector3 VecOffset;
        protected override void Awake()
        {           
            Light = GetComponent<Light>();
            if (Light)
            {
                Debug.Log("got the light");
            }

            Debug.Log(VecOffset);
            GoFollow = Camera.main.transform;
            transform.position = Camera.main.transform.position;
            VecOffset = transform.position - GoFollow.position;
        }

        private void Update()
        {
            //Debug.Log(GoFollow);
            //Debug.Log(VecOffset);
        }
    }
}
