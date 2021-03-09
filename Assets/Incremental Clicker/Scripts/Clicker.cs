using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [Header("Money")]
    [SerializeField] Text text;
    [SerializeField] float gameTime;
    [SerializeField] int currentPoint = 10;
    [SerializeField] int getMoney = 1;

    [Header("Player")]
    [SerializeField] GameObject upButton;
    [SerializeField] Text playerText;
    [SerializeField] int playerLv = 1;

    [Header("Chest")]
    [SerializeField] SpriteRenderer rendChests;
    [SerializeField] List<Sprite> chests;
    [SerializeField] Text chestText;
    [SerializeField] Text chestCostText;
    [SerializeField] int chestLv = 1;
    [SerializeField] int chestCost = 50;

    [Header("Hair")]
    [SerializeField] SpriteRenderer rendHair;
    [SerializeField] List<Sprite> hair;
    [SerializeField] GameObject hairButton;
    [SerializeField] GameObject hairUnlock;
    [SerializeField] Text hairText;
    [SerializeField] Text hairCostText;
    [SerializeField] int hairLv = 1;
    [SerializeField] int hairCost = 100;

    [Header("Shield")] 
    [SerializeField] SpriteRenderer rendShield;
    [SerializeField] List<Sprite> shield;
    [SerializeField] GameObject shieldButton;
    [SerializeField] GameObject shieldUnlock;
    [SerializeField] Text shieldText;
    [SerializeField] Text shieldCostText;
    [SerializeField] int shieldLv = 1;
    [SerializeField] int shieldCost = 150;

    [Header("Weapon")]
    [SerializeField] SpriteRenderer rendWeapon;
    [SerializeField] List<Sprite> weapon;
    [SerializeField] GameObject weaponButton;
    [SerializeField] GameObject weaponUnlock;
    [SerializeField] Text weaponText;
    [SerializeField] Text weaponCostText;
    [SerializeField] int weaponLv = 1;
    [SerializeField] int weaponCost = 200;

    [Header("Pants")]
    [SerializeField] SpriteRenderer rendPants;
    [SerializeField] List<Sprite> pants;
    [SerializeField] GameObject pantsButton;
    [SerializeField] GameObject pantsUnlock;
    [SerializeField] Text pantsText;
    [SerializeField] Text pantsCostText;
    [SerializeField] int pantsLv = 1;
    [SerializeField] int pantsCost = 250;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        if(gameTime >= 1f && playerLv == 1)
        {
            currentPoint = currentPoint + chestLv + playerLv;
            gameTime--;
        }
        if(gameTime >= 1f && playerLv == 2)
        {
            currentPoint = currentPoint + chestLv + hairLv + playerLv;
            gameTime--;
        }
        if (gameTime >= 1f && playerLv == 3)
        {
            currentPoint = currentPoint + chestLv + hairLv + shieldLv + playerLv;
            gameTime--;
        }
        if (gameTime >= 1f && playerLv == 4)
        {
            currentPoint = currentPoint + chestLv + hairLv + shieldLv + weaponLv + playerLv;
            gameTime--;
        }
        if (gameTime >= 1f && playerLv == 5)
        {
            currentPoint = currentPoint + chestLv + hairLv + shieldLv + weaponLv + pantsLv + playerLv;
            gameTime--;
        }
        if (gameTime >= 1f && playerLv == 6)
        {
            currentPoint = currentPoint + ((chestLv + hairLv + shieldLv + weaponLv + pantsLv + playerLv) * 2);
            gameTime--;
        }
        if (chestLv >= 10 && playerLv == 1)
        {
            hairButton.SetActive(true);
            hairUnlock.SetActive(false);
            upButton.SetActive(true);
        }
        if(chestLv >= 20 && hairLv >= 10 && playerLv == 2)
        {
            shieldButton.SetActive(true);
            shieldUnlock.SetActive(false);
            upButton.SetActive(true);
        }
        if (chestLv >= 30 && hairLv >= 20 && shieldLv >= 10 && playerLv == 3)
        {
            weaponButton.SetActive(true);
            weaponUnlock.SetActive(false);
            upButton.SetActive(true);
        }
        if (chestLv >= 40 && hairLv >= 30 && shieldLv >= 20 && weaponLv >= 10 && playerLv == 4)
        {
            pantsButton.SetActive(true);
            pantsUnlock.SetActive(false);
            upButton.SetActive(true);
        }
        if (chestLv >= 50 && hairLv >= 40 && shieldLv >= 30 && weaponLv >= 20 && pantsLv >= 10 && playerLv == 5)
        {
            upButton.SetActive(true);
        }
        playerText.text = "LV : " + playerLv;
        text.text = "$ " + currentPoint;
        chestCostText.text = "$ " + chestCost;
        hairCostText.text = "$ " + hairCost;
        shieldCostText.text = "$ " + shieldCost;
        weaponCostText.text = "$ " + weaponCost;
        pantsCostText.text = "$ " + pantsCost;
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
