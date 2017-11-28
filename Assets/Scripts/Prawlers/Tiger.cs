using UnityEditor;
using UnityEngine;

namespace Prawlers
{
    public class Tiger : MonoBehaviour
    {
        private Rigidbody2D body;
        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            throw new System.NotImplementedException();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            throw new System.NotImplementedException();
        }

        private void OnDestroy()
        {
            throw new System.NotImplementedException();
        }

        private void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}