using UnityEngine;

namespace Interfaces.ComponentInterfaces
{
    public interface IScarable
    {
        Vector3 ScareEpicenter { get; set; }
        float ScareAmount { get; set; }
    }
}