using System;
using Entities;
using Interfaces.ComponentInterfaces;
using Systems;
using UnityEngine;

namespace Components
{
    public class FinishComponent : MonoBehaviour, ITarget
    {
        public Transform Transform => transform;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(!other.TryGetComponent(out Cockroach cockroach)) return;
            
            GameManager.Instance.EndGame();
        }
    }
}