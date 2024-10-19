using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.CodeBase.Services
{
    public class MovementService : MonoBehaviour
    {
        public Transform _player;
        private NavMeshAgent _agent;

        void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        public void MoveToPlayer(Animator anim)
        {
            _agent.destination = _player.position;
            anim.Play("OneHand_Up_Walk_F_InPlace");

            if (_agent.destination == _player.position)
                anim.Play("Dialogue_3");
        }

        public void MoveToIdle(Transform goal, Animator anim)
        {
            anim.Play("OneHand_Up_Walk_F_InPlace");
            _agent.destination = goal.position;

            if (_agent.destination == goal.position)
                anim.Play("Dialogue_3");

        }


    }
}