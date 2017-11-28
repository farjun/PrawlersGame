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

        public bool wantsToMoveRight()
        {
            return Input.GetKeyDown(_right);
        } 
        public bool wantsToMoveLeft()
        {
            return Input.GetKeyDown(_left);
        } 
        public bool wantsToMoveUp()
        {
            return Input.GetKeyDown(_up);
        } 
        public bool wantsToMoveDown()
        {
            return Input.GetKeyDown(_down);
        } 
        
        
    }
}