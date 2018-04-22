<<<<<<< HEAD
using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
>>>>>>> 8459d98a5a0ef532ea6f483556e0488ececaf920
