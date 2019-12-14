using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class FlashLightModel : BaseObjectModel
    {
        public Light Light;
        public Transform GoFollow;
        public Vector3 VecOffset;
        protected override void Awake()
        {           
            Light = GetComponent<Light>();
            Light.intensity = 0;
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
