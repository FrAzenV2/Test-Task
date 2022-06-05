using Configs;
using Entities;
using Interfaces.ComponentInterfaces;
using UnityEngine;

namespace Factories
{
    public class CockroachFactory : MonoBehaviour
    {
        [SerializeField] private CockroachConfig cockroachConfig;
        [SerializeField] private Cockroach cockroachPrefab;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private Transform cockroachesParent;

        public Cockroach CreateCockroach(ITarget target)
        {
            var newCockroach = Instantiate(cockroachPrefab, spawnPosition.position, Quaternion.identity, cockroachesParent);
            newCockroach.Init(cockroachConfig, target);
            return newCockroach;
        }
    }
}