using Assets.CodeBase.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.CodeBase.NPC
{
    public class OldNPC : NPCService
    {
        protected override string playerMessage => _playerMessage;
        protected override string nightMessage => _nightMessage;
        protected override string idleMessage => _idleMessage;
        protected override string dayMessage => _dayMessage;
        protected override string baseMessage => _baseMessage;

        protected override Transform idlePosition => _idlePosition;

        [SerializeField] private string _playerMessage;
        [SerializeField] private string _nightMessage;
        [SerializeField] private string _dayMessage;
        [SerializeField] private string _idleMessage;
        [SerializeField] private string _baseMessage;

        [SerializeField] private Transform _idlePosition;

    }
}