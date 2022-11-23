using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
    public GameObject left_Arm_Attack_Point, right_Arm_Attack_Point, left_Leg_Attack_Point, right_Leg_Attack_Point;
    public float stand_Up_Timer = 2f;

    private CharacterAnimation animationScript;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        animationScript = GetComponent<CharacterAnimation>();
    }

    void Left_Arm_Attack_On()
    {
        left_Arm_Attack_Point.SetActive(true);
    }
    void Left_Arm_Attack_Off()
    {
        if (left_Arm_Attack_Point)
        {
            left_Arm_Attack_Point.SetActive(false);
        }
    }

    void Right_Arm_Attack_On()
    {
        right_Arm_Attack_Point.SetActive(true);
    }
    void Right_Arm_Attack_Off()
    {
        if (left_Arm_Attack_Point)
        {
            right_Arm_Attack_Point.SetActive(false);
        }
    }


    void Left_Leg_Attack_On()
    {
        left_Leg_Attack_Point.SetActive(true);
    }

    void Left_Leg_Attack_Off()
    {
        if (left_Leg_Attack_Point)
        {
            left_Leg_Attack_Point.SetActive(false);
        }
    }


    void Right_Leg_Attack_On()
    {

        right_Leg_Attack_Point.SetActive(true);

    }
    void Right_Leg_Attack_Off()
    {
        if (left_Leg_Attack_Point)
        {
            right_Leg_Attack_Point.SetActive(false);
        }
    }

    void TagLef_Arm()
    {
        left_Arm_Attack_Point.tag = Tags.LEFT_ARM_TAG;
    }

    void UnTagLef_Arm()
    {
        left_Arm_Attack_Point.tag = Tags.UNTAGGED_TAG;
    }
    void TagLef_Leg()
    {
        left_Leg_Attack_Point.tag = Tags.LEFT_LEG_TAG;
    }

    void UnTagLef_Leg()
    {
        left_Leg_Attack_Point.tag = Tags.UNTAGGED_TAG;
    }

    void EnemyStandUp()
    {
        StartCoroutine(StandUpAfterTime());
    }

    IEnumerator StandUpAfterTime()
    {
        yield return new WaitForSeconds(stand_Up_Timer);
        animationScript.StandUp();
    }
}//class
