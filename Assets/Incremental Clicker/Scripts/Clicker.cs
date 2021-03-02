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

    [Header("Hair")]
    [SerializeField] List<Sprite> hair;
    [SerializeField] SpriteRenderer rendHair;
    [SerializeField] Text hairText;
    [SerializeField] int hairLv;
    [SerializeField] GameObject hairButton;


    [Header("Shield")] 
    [SerializeField] List<Sprite> shield;
    [SerializeField] SpriteRenderer rendShield;
    [SerializeField] Text shieldText;
    [SerializeField] int shieldLv;
    [SerializeField] GameObject shieldButton;


    [Header("Weapon")]
    [SerializeField] List<Sprite> weapon;
    [SerializeField] SpriteRenderer rendWeapon;
    [SerializeField] Text weaponText;
    [SerializeField] int weaponLv;
    [SerializeField] GameObject weaponButton;


    [Header("Pants")]
    [SerializeField] List<Sprite> pants;
    [SerializeField] SpriteRenderer rendPants;
    [SerializeField] Text pantsText;
    [SerializeField] int pantsLv;
    [SerializeField] GameObject pantsButton;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(chestLv >= 10)
        {
            hairButton.SetActive(true);
            upButton.SetActive(true);
        }
        if(chestLv >= 20 && hairLv >= 10)
        {
            shieldButton.SetActive(true);
            upButton.SetActive(true);
        }
        if (chestLv >= 30 && hairLv >= 20 && shieldLv >= 10)
        {
            weaponButton.SetActive(true);
            upButton.SetActive(true);
        }
        if (chestLv >= 40 && hairLv >= 30 && shieldLv >= 20 && weaponLv >= 10)
        {
            pantsButton.SetActive(true);
            upButton.SetActive(true);
        }
        if (chestLv >= 50 && hairLv >= 40 && shieldLv >= 30 && weaponLv >= 20 && pantsLv >= 10)
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
        int rand = Random.Range(0, chests.Count);
        rendChests.sprite = chests[rand];
        chestLv++;
        chestText.text = "LV : " + chestLv;
        getMoney = getMoney + 1;
    }

    public void HairUp()
    {
        int rand = Random.Range(0, hair.Count);
        rendHair.sprite = hair[rand];
        hairLv++;
        hairText.text = "LV : " + hairLv;
        getMoney = getMoney + 2;
    }

    public void ShieldUp()
    {
        int rand = Random.Range(0, shield.Count);
        rendShield.sprite = shield[rand];
        shieldLv++;
        shieldText.text = "LV : " + shieldLv;
        getMoney = getMoney + 3;
    }

    public void WeaponUp()
    {
        int rand = Random.Range(0, weapon.Count);
        rendWeapon.sprite = weapon[rand];
        weaponLv++;
        weaponText.text = "LV : " + weaponLv;
        getMoney = getMoney + 4;
    }

    public void PantsUp()
    {
        int rand = Random.Range(0, pants.Count);
        rendPants.sprite = pants[rand];
        pantsLv++;
        pantsText.text = "LV : " + pantsLv;
        getMoney = getMoney + 5;
    }
    public void Up()
    {
        playerLv++;
        getMoney = getMoney + (playerLv * 2);
        upButton.SetActive(false);
    }
}
