using Assets.CodeBase.Services;
using UnityEngine;

namespace Assets.CodeBase.NPC
{
    public class BaseNPC : NPCService
    {
        protected override string playerMessage => _playerMessage;
        protected override string nightMessage => _nightMessage;
        protected override string idleMessage => _idleMessage;
        protected override string dayMessage => _dayMessage;

        protected override Transform idlePosition => _idlePosition;

        [SerializeField] private string _playerMessage;
        [SerializeField] private string _nightMessage;
        [SerializeField] private string _dayMessage;
        [SerializeField] private string _idleMessage;

        [SerializeField] private Transform _idlePosition;


        private void Start()
        {
            MoveToPlayer();
        }

        public void BasePlayerInteraction()
        {
            PlayerInteraction();
        }

        public override void PlayerInteraction()
        {
            base.PlayerInteraction();
            Debug.Log("Player");
        }
    }
}