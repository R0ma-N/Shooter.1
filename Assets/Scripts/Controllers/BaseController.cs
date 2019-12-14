using UnityEngine;

namespace Shooter
{
    public class BaseController
    {
        public bool IsActive;

        public virtual void On()
        {
            IsActive = true;
        }

        public virtual void Off()
        {
            IsActive = false;
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
