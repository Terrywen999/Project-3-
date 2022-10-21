using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    private enum wallSkill
    {
        Wall1,
        Wall2,
        Wall3,
        Wall4
    }

    Vector2 mousePos = Vector2.zero;
    public GameObject wall1;
    public Transform player;
    
    [Header("Ability1")]
    public Image abilityImage1;
    public float cooldown1;
    bool isCooldown1 = false;
    public KeyCode ability1;

    [Header("Ability2")]
    public Image abilityImage2;
    public float cooldown2;
    bool isCooldown2 = false;
    public KeyCode ability2;

    [Header("Ability3")]
    public Image abilityImage3;
    public float cooldown3;
    bool isCooldown3 = false;
    public KeyCode ability3;

    [Header("Ability4")]
    public Image abilityImage4;
    public float cooldown4;
    bool isCooldown4 = false;
    public KeyCode ability4;
    void Start()
    {
        abilityImage1.fillAmount = 0;
        abilityImage2.fillAmount = 0;
        abilityImage3.fillAmount = 0;
        abilityImage4.fillAmount = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
        Ability4();
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void Ability1()
    {
        if(Input.GetKey(ability1)&& isCooldown1 == false)
        {
            isCooldown1 = true;
            abilityImage1.fillAmount = 1;
            Instantiate(wall1, new Vector3(0,0 ,0), Quaternion.identity);
        }
        if (isCooldown1)
        {
            abilityImage1.fillAmount -= 1 / cooldown1 * Time.deltaTime; 

            if(abilityImage1.fillAmount <= 0)
            {
                abilityImage1.fillAmount = 1;
                isCooldown1 = false;
            }
        }

    }

    void Ability2()
    {
        if (Input.GetKey(ability2) && isCooldown2 == false)
        {
            isCooldown2 = true;
            abilityImage2.fillAmount = 1;
        }
        if (isCooldown2)
        {
            abilityImage2.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if (abilityImage2.fillAmount <= 0)
            {
                abilityImage2.fillAmount = 1;
                isCooldown2 = false;
            }
        }
    }

    void Ability3()
    {
        if (Input.GetKey(ability3) && isCooldown3 == false)
        {
            isCooldown3 = true;
            abilityImage3.fillAmount = 1;
        }
        if (isCooldown3)
        {
            abilityImage3.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if (abilityImage3.fillAmount <= 0)
            {
                abilityImage3.fillAmount = 1;
                isCooldown3 = false;
            }
        }
    }

    void Ability4()
    {
        if (Input.GetKey(ability4) && isCooldown4 == false)
        {
            isCooldown4 = true;
            abilityImage4.fillAmount = 1;
        }
        if (isCooldown4)
        {
            abilityImage4.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if (abilityImage4.fillAmount <= 0)
            {
                abilityImage4.fillAmount = 1;
                isCooldown4 = false;
            }
        }
    }
}
