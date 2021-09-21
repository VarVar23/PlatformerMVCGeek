using UnityEngine;

namespace Platformer
{
    public class InputManager
    {
        private Constance _constance;

        public InputManager(Constance constance) =>
            _constance = constance;


        private float _horizontal;
        private float _jump;

        public float Horizontal { get => _horizontal; }
        public float Jump { get => _jump; }

        public void Update()
        {
            _horizontal = Input.GetAxis(_constance.HORIZONTAL);
            _jump = Input.GetAxis(_constance.JUMP);
        }
    }
}
