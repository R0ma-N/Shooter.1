using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class BaseObjectModel : MonoBehaviour
    {
        [HideInInspector] public Rigidbody Rigidbody;
        protected virtual void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }
    }
}
