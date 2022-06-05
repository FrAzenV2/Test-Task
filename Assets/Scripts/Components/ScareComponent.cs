using System;
using System.Collections.Generic;
using Interfaces.ComponentInterfaces;
using Unity.VisualScripting;
using UnityEngine;

namespace Components
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class ScareComponent : MonoBehaviour
    {
        [SerializeField] private float range = 2f;
        [Tooltip("Lower value = less radius")]
        [SerializeField, Range(0, 1)] private float maxScareRange = 0.1f;

        [SerializeField, HideInInspector] private CircleCollider2D collider;
        
        private List<IScarable> scarableComponentsInZone = new List<IScarable>();

        private void FixedUpdate()
        {
            Scare();
        }
        
        private void Scare()
        {
            foreach (var scarable in scarableComponentsInZone)
            {
                scarable.LastScareEpicenter = transform.position;
                
                var newScareAmount = CalculateScareAmount(scarable);

                if (newScareAmount > scarable.ScareAmount)
                    scarable.ScareAmount = newScareAmount;
            }
        }
        
        private float CalculateScareAmount(IScarable scarable)
        { 
            //Can be changed to high performance version if needed (work with 1000+ components)
            var distanceToScarable = Vector3.Distance(scarable.Transform.position, transform.position);

            if (distanceToScarable <= range * maxScareRange)
                return 1;

            distanceToScarable -= range * maxScareRange;
            return Mathf.InverseLerp(range - range * maxScareRange, 0, distanceToScarable);
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if(!other.TryGetComponent(out IScarable scarable)) return;
            
            scarableComponentsInZone.Add(scarable);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if(!other.TryGetComponent(out IScarable scarable)) return;
            
            scarableComponentsInZone.Remove(scarable);
        }
        
        private void OnValidate()
        {
            if (collider == null)
                collider = GetComponent<CircleCollider2D>();

            collider.radius = range;
            
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, range);
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, range * maxScareRange);
        }

    }
}