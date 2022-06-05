using Interfaces.ComponentInterfaces;
using UnityEngine;

namespace Components
{
    public class ScarableComponent : MonoBehaviour, IScarable
    {

        public Vector3 LastScareEpicenter { get; set; }
        public float ScareAmount { get; set; }

    }
}