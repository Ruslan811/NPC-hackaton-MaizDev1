using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.CodeBase.Services
{
    [RequireComponent(typeof(MovementService))]
    public abstract class NPCService : MonoBehaviour
    {
        [SerializeField] private TextMeshPro _text;
        [SerializeField] private Animator _anim;

        private MovementService _movementService;

        protected virtual string playerMessage { get; }
        protected virtual string nightMessage { get; }
        protected virtual string dayMessage { get; }
        protected virtual string idleMessage { get; }
        protected virtual string baseMessage { get; }

        protected virtual Transform idlePosition { get; }


        private void Awake()
        {
            _movementService = GetComponent<MovementService>();
        }

        public void MoveToPlayer()
        {
            _movementService.MoveToPlayer(_anim);
        }

        protected void MoveToNPC(Transform npc)
        {
            _movementService.MoveToIdle(npc, _anim);
            TextOutput(baseMessage);
        }

        public virtual void OtherNPCInteraction()
        {
            TextOutput(baseMessage);
        }

        public virtual void NightInteraction()
        {
            TextOutput(nightMessage);
        }

        public virtual void DayInteraction()
        {
            TextOutput(dayMessage);
        }


        public virtual void IdleInteraction()
        {
            TextOutput(idleMessage);
            _movementService.MoveToIdle(idlePosition, _anim);

        }

        public virtual void PlayerInteraction()
        {
            TextOutput(playerMessage);

        }

        private void TextOutput(string message)
        {
            _text.text = message;
        }
    }
}