using UnityEngine;

namespace Prawlers
{
    public class Antilope : MonoBehaviour
    {

        private Rigidbody2D _body;


        
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
            throw new System.NotImplementedException();

        }

        private void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}