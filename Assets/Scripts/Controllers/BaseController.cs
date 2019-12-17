using UnityEngine;

namespace Shooter
{
    public abstract class BaseController
    {
        protected bool IsActive;

        public virtual void On()
        {
            IsActive = true;
            Debug.Log(IsActive);
        }

        public virtual void Off()
        {
            IsActive = false;
            Debug.Log(IsActive);
        }

        public void Switch()
        {
            Debug.Log("Switch");
            if (IsActive)
            {
                Off();
            }
            else
            {
                On();
            }
        }
    }
}
