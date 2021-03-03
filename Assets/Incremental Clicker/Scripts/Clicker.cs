using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [Header("Money")]
    [SerializeField] Text text;
    [SerializeField] int currentPoint = 10;
    [SerializeField] int getMoney = 1;

    [Header("Player")]
    [SerializeField] Text playerText;
    [SerializeField] int playerLv = 1;
    [SerializeField] GameObject upButton;

    [Header("Chest")]
    [SerializeField] List<Sprite> chests;
    [SerializeField] SpriteRenderer rendChests;
    [SerializeField] Text chestText;
    [SerializeField] int chestLv;
    [SerializeField] int chestCost;

    [Header("Hair")]
    [SerializeField] List<Sprite> hair;
    [SerializeField] SpriteRenderer rendHair;
    [SerializeField] Text hairText;
    [SerializeField] int hairLv;
    [SerializeField] GameObject hairButton;
    [SerializeField] int hairCost;

    [Header("Shield")] 
    [SerializeField] List<Sprite> shield;
    [SerializeField] SpriteRenderer rendShield;
    [SerializeField] Text shieldText;
    [SerializeField] int shieldLv;
    [SerializeField] GameObject shieldButton;
    [SerializeField] int shieldCost;

    [Header("Weapon")]
    [SerializeField] List<Sprite> weapon;
    [SerializeField] SpriteRenderer rendWeapon;
    [SerializeField] Text weaponText;
    [SerializeField] int weaponLv;
    [SerializeField] GameObject weaponButton;
    [SerializeField] int weaponCost;

    [Header("Pants")]
    [SerializeField] List<Sprite> pants;
    [SerializeField] SpriteRenderer rendPants;
    [SerializeField] Text pantsText;
    [SerializeField] int pantsLv;
    [SerializeField] GameObject pantsButton;
    [SerializeField] int pantsCost;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(chestLv >= 10 && playerLv == 1)
        {
            hairButton.SetActive(true);
            upButton.SetActive(true);
        }
        if(chestLv >= 20 && hairLv >= 10 && playerLv == 2)
        {
            shieldButton.SetActive(true);
            upButton.SetActive(true);
        }
        if (chestLv >= 30 && hairLv >= 20 && shieldLv >= 10 && playerLv == 3)
        {
            weaponButton.SetActive(true);
            upButton.SetActive(true);
        }
        if (chestLv >= 40 && hairLv >= 30 && shieldLv >= 20 && weaponLv >= 10 && playerLv == 4)
        {
            pantsButton.SetActive(true);
            upButton.SetActive(true);
        }
        if (chestLv >= 50 && hairLv >= 40 && shieldLv >= 30 && weaponLv >= 20 && pantsLv >= 10 && playerLv == 5)
        {
            upButton.SetActive(true);
        }
        playerText.text = "LV : " + playerLv;
        text.text = "$ " + currentPoint;
    }


    public void GetMoney()
    {
        currentPoint = currentPoint + getMoney;
    }

    public void ChestUp()
    {
        if (currentPoint >= chestCost)
        {
            int rand = Random.Range(0, chests.Count);
            rendChests.sprite = chests[rand];
            chestLv++;
            chestText.text = "LV : " + chestLv;
            getMoney = getMoney + 1;
            currentPoint = currentPoint - chestCost;
            chestCost = chestCost * 2;
        }
    }

    public void HairUp()
    {
        if (currentPoint >= hairCost)
        {
            int rand = Random.Range(0, hair.Count);
            rendHair.sprite = hair[rand];
            hairLv++;
            hairText.text = "LV : " + hairLv;
            getMoney = getMoney + 2;
            currentPoint = currentPoint - hairCost;
            hairCost = hairCost * 2;
        }
    }

    public void ShieldUp()
    {
        if (currentPoint >= shieldCost)
        {
            int rand = Random.Range(0, shield.Count);
            rendShield.sprite = shield[rand];
            shieldLv++;
            shieldText.text = "LV : " + shieldLv;
            getMoney = getMoney + 3;
            currentPoint = currentPoint - shieldCost;
            shieldCost = shieldCost * 2;
        }
    }

    public void WeaponUp()
    {
        if (currentPoint >= weaponCost)
        {
            int rand = Random.Range(0, weapon.Count);
            rendWeapon.sprite = weapon[rand];
            weaponLv++;
            weaponText.text = "LV : " + weaponLv;
            getMoney = getMoney + 4;
            currentPoint = currentPoint - weaponCost;
            weaponCost = weaponCost * 2;
        }
    }

    public void PantsUp()
    {
        if (currentPoint >= pantsCost)
        {
            int rand = Random.Range(0, pants.Count);
            rendPants.sprite = pants[rand];
            pantsLv++;
            pantsText.text = "LV : " + pantsLv;
            getMoney = getMoney + 5;
            currentPoint = currentPoint - pantsCost;
            pantsCost = pantsCost * 2;
        }
    }
    public void Up()
    {
        playerLv++;
        getMoney = getMoney + (playerLv * 2);
        upButton.SetActive(false);
    }
}
