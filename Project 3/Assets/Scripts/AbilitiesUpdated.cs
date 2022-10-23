using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Ability {
    public Image abilityImage1;
    public float cooldown;
    public bool isCooldown = false;
    public KeyCode ability;
    public int id;
    public GameObject wall1;
}

public enum wallSkill
{
    Wall1,
    Wall2,
    Wall3,
    Wall4
}

public class AbilitiesUpdated : MonoBehaviour
{
   

    Vector2 mousePos = Vector2.zero;
    public Vector2 targetGeneratePos;
    public float generateDist;

    public GameObject wall1;
    public Transform player;

    public Ability[] allAbs;
    void Start()
    {
        foreach (Ability a in allAbs) {
            a.abilityImage1.fillAmount = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CalculateTargetPos();
        CheckAbility();
    }

    void CalculateTargetPos() {
        Vector2 startPos = new Vector2(player.position.x, player.position.y);
        Vector2 directVec = (startPos - mousePos).normalized;
        targetGeneratePos = startPos - generateDist * directVec;
    }

    void CheckAbility() {
        foreach (Ability a in allAbs) {
            if (Input.GetKey(a.ability) && a.isCooldown == false) {
                a.isCooldown = true;
                a.abilityImage1.fillAmount = 0;
                if(a.id == 3) 
                {
                Instantiate(a.wall1, player.position, player.rotation);
                }
                else
                {
                 Instantiate(a.wall1, targetGeneratePos, player.rotation);
                }

                AstarPath.active.Scan();
            } 

            if (a.isCooldown)
            {
                a.abilityImage1.fillAmount += 1 / a.cooldown * Time.deltaTime; 

                if(a.abilityImage1.fillAmount >= 1)
                {
                    a.abilityImage1.fillAmount = 1;
                    a.isCooldown = false;
                }
            }
        }
    }
}
