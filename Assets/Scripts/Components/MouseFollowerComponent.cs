using Interfaces.ComponentInterfaces;
using UnityEngine;

namespace Components
{
    public class MouseFollowerComponent : MonoBehaviour, ITarget
    {
        private Camera mainCamera;
        private Vector3 currentPos;
        
        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            CalculateCurrentPosition();
            MoveToCurrentPos();
        }
        
        private void MoveToCurrentPos()
        {
            transform.position = currentPos;
        }
        
        private void CalculateCurrentPosition()
        {
            currentPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            currentPos.z = 0;
        }

        public Transform Transform => transform;
    }
}