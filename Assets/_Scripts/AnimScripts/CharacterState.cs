using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour
{
    public CHARACTERSTATES currentState = CHARACTERSTATES.IDLE;

    public void SetState(CHARACTERSTATES state)
    {
        currentState = state;
    }

}
public enum CHARACTERSTATES
{
    IDLE,
    WALK,
    RUN,
    JUMPING,
    JUMP,
    LAND,
    JUMPKICK,
    PUNCH,
    KICK,
    ATTACK,
    DEFEND,
    HIT,
    DEATH,
    THROW,
    PICKUPITEM,
    KNOCKDOWN,
    KNOCKDOWNGROUNDED,
    GROUNDPUNCH,
    GROUNDKICK,
    GROUNDHIT,
    STANDUP,
    USEWEAPON,

};
