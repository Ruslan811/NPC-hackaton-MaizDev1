using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.CodeBase.UI
{
    public class TextMovement : MonoBehaviour
    {
        [SerializeField] private Transform _npc;

        private void Update()
        {
            transform.position = new Vector3(_npc.position.x, 0, _npc.position.z);
        }
    }
}