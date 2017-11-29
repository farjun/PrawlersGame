using UnityEngine;

namespace Prawlers
{
    [CreateAssetMenu(menuName = "Tiger Controller/Keyboard")]
    public class TigerController : ScriptableObject
    {
        [SerializeField] KeyCode _right;
        [SerializeField] KeyCode _left;
        [SerializeField] KeyCode _up;
        [SerializeField] KeyCode _down;

        private bool _isUp;
        private bool _isDown;
        private bool _isRight;
        private bool _isLeft;
        
        public bool wantsToMoveRight()
        {
            if (Input.GetKeyDown(_right))
                _isRight = true;
            else if (Input.GetKeyUp(_right))
                _isRight = false;
            return _isRight;

        } 
        public bool wantsToMoveLeft()
        {
            if (Input.GetKeyDown(_left))
                _isLeft = true;
            else if (Input.GetKeyUp(_left))
                _isLeft = false;
            return _isLeft;
        } 
        public bool wantsToMoveUp()
        {
            if (Input.GetKeyDown(_up))
                _isUp = true;
            else if (Input.GetKeyUp(_up))
                _isUp = false;
            return _isUp;
        } 
        public bool wantsToMoveDown()
        {
            if (Input.GetKeyDown(_down))
                _isDown = true;
            else if (Input.GetKeyUp(_down))
                _isDown = false;
            return _isDown;
        } 
        
        
    }
}