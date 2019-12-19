using UnityEngine;

namespace Shooter
{
    public abstract class BaseController
    {
        public Inventory Inventory = new Inventory();
        public UIInterface UIInterface = new UIInterface();
        
        protected bool IsActive;

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
