using UnityEngine;

namespace Interfaces.ComponentInterfaces
{
    public interface IScarable
    {
        Vector3 LastScareEpicenter { get; set; }
        float ScareAmount { get; set; }
    }
}