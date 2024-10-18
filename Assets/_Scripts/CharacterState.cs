using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour
{
    public CharacterStates currentState = CharacterStates.IDLE;

    public void SetState(CharacterStates state)
    {
        currentState = state;
    }
}
public enum CharacterStates
{
    IDLE, WALK, RUN, JUMP, STANDUP,
    PUNCH, KICK, JUMPKICK, GROUNDKICK,
    ATTACK, DEFEND, HIT, DEATH, GROUNDHIT, KNOCKDOWN,
    THROW, PICKUPITEM,
}
