using Assets.CodeBase.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.CodeBase.UI
{
    [RequireComponent(typeof(Button))]
    public class SummonNPCButton : MonoBehaviour
    {
        private Button _button;
        [SerializeField] private NPCService _npcService;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Summon);
        }

        private void Summon()
        {
            _npcService.MoveToPlayer();
        }

    }
}