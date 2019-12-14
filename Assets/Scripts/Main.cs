using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class Main : MonoBehaviour
    {
        private PlayerController _playerController;
        private InputController _inputController;
        private FlashLightController _flashLightController;
        private IOnUpdate[] _controllersUpdate;
        private IOnInitialize[] _controllersInit;

        private void Awake()
        {
            _playerController = new PlayerController();
            _inputController = new InputController();
            _flashLightController = new FlashLightController();
            _controllersUpdate = new IOnUpdate[2];
            _controllersInit = new IOnInitialize[1];
            _controllersUpdate[0] = _playerController;
            _controllersUpdate[1] = _inputController;
            _controllersInit[0] = _flashLightController;
        }
        void Start()
        {
            for (int i = 0; i < _controllersInit.Length; i++)
            {
                var controller = _controllersInit[i];
                controller.OnStart();
            }
        }

        void Update()
        {
            for (int i = 0; i < _controllersUpdate.Length; i++)
            {
                var controller = _controllersUpdate[i];
                controller.OnUpdate();
            }
        }
    }
}
