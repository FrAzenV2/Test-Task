using UnityEngine;

namespace Interfaces.ComponentInterfaces
{
    public interface IScarable
    {
        Transform Transform { get; }
        Vector3 LastScareEpicenter { get; set; }
        //ScareAmount = 1 - highest supposed
        float ScareAmount { get; set; }
    }
}