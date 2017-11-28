using System.Security.AccessControl;
using UnityEditor;
using UnityEngine;

namespace Prawlers
{
    
    public class Tiger : MonoBehaviour
    {
        //constants

        private const float XSpeed = 100.0f;
        private const float YSpeed = 100.0f;

        private Rigidbody2D _body;

        [SerializeField] private TigerController _controller;
        
        // controlls
        private bool _moveUp;
        private bool _moveRight;
        private bool _moveLeft;
        private bool _moveDown;
        
        private void Awake()
        {
            _body = GetComponent<Rigidbody2D>();
        }

    
//
//        private void OnCollisionEnter2D(Collision2D other)
//        {
//            throw new System.NotImplementedException();
//        }
//
//        private void OnDestroy()
//        {
//            throw new System.NotImplementedException();
//        }
        
        private void FixedUpdate()
        {
            var velocity = _body.velocity;
            velocity = Vector2.zero;
            
            if (_moveUp)
                velocity.y += YSpeed;
       
            if(_moveDown)
                velocity.y -= YSpeed;
            
            if (_moveRight)
                velocity.x +=XSpeed;
       
            if(_moveLeft)
                velocity.x -= XSpeed;

            _body.velocity = velocity;
        }

        private void Update()
        {
            _moveUp = _controller.wantsToMoveUp();
            _moveLeft = _controller.wantsToMoveLeft();
            _moveRight = _controller.wantsToMoveRight();
            _moveDown = _controller.wantsToMoveDown();
            
        }
    }
}