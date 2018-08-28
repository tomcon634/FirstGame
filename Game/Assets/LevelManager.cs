using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private int level;
    public Transform res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14, res15, res16;
    public Transform selectSpawn;
    private int levelsUnlocked;

	// Use this for initialization
	void Start () {
        level = PlayerPrefs.GetInt("level");

        switch (level)
        {
            case 1:
                transform.position = res1.position;
                break;
            case 2:
                transform.position = res2.position;
                break;
            case 3:
                transform.position = res3.position;
                break;
            case 4:
                transform.position = res4.position;
                break;
            case 5:
                transform.position = res5.position;
                break;
            case 6:
                transform.position = res6.position;
                break;
            case 7:
                transform.position = res7.position;
                break;
            case 8:
                transform.position = res8.position;
                break;
            case 9:
                transform.position = res9.position;
                break;
            case 10:
                transform.position = res10.position;
                break;
            case 11:
                transform.position = res11.position;
                break;
            case 12:
                transform.position = res12.position;
                break;
            case 13:
                transform.position = res13.position;
                break;
            case 14:
                transform.position = res14.position;
                break;
            case 15:
                transform.position = res15.position;
                break;
            case 16:
                transform.position = res16.position;
                break;
            default:
                transform.position = res1.position;
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
        level = PlayerPrefs.GetInt("level");
        levelsUnlocked = PlayerPrefs.GetInt("unlocked");

        if (Input.GetKey("return"))
            transform.position = selectSpawn.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.name)
        {
            case "floor1":
                PlayerPrefs.SetInt("level", 1);
                if (levelsUnlocked < 1)
                    PlayerPrefs.SetInt("unlocked", 1);
                break;
            case "floor2":
                PlayerPrefs.SetInt("level", 2);
                if (levelsUnlocked < 2)
                    PlayerPrefs.SetInt("unlocked", 2);
                break;
            case "floor3":
                PlayerPrefs.SetInt("level", 3);
                if (levelsUnlocked < 3)
                    PlayerPrefs.SetInt("unlocked", 3);
                break;
            case "floor4":
                PlayerPrefs.SetInt("level", 4);
                if (levelsUnlocked < 4)
                    PlayerPrefs.SetInt("unlocked", 4);
                break;
            case "floor5":
                PlayerPrefs.SetInt("level", 5);
                if (levelsUnlocked < 5)
                    PlayerPrefs.SetInt("unlocked", 5);
                break;
            case "floor6":
                PlayerPrefs.SetInt("level", 6);
                if (levelsUnlocked < 6)
                    PlayerPrefs.SetInt("unlocked", 6);
                break;
            case "floor7":
                PlayerPrefs.SetInt("level", 7);
                if (levelsUnlocked < 7)
                    PlayerPrefs.SetInt("unlocked", 7);
                break;
            case "floor8":
                PlayerPrefs.SetInt("level", 8);
                if (levelsUnlocked < 8)
                    PlayerPrefs.SetInt("unlocked", 8);
                break;
            case "floor9":
                PlayerPrefs.SetInt("level", 9);
                if (levelsUnlocked < 9)
                    PlayerPrefs.SetInt("unlocked", 9);
                break;
            case "floor10":
                PlayerPrefs.SetInt("level", 10);
                if (levelsUnlocked < 10)
                    PlayerPrefs.SetInt("unlocked", 10);
                break;
            case "floor11":
                PlayerPrefs.SetInt("level", 11);
                if (levelsUnlocked < 11)
                    PlayerPrefs.SetInt("unlocked", 11);
                break;
            case "floor12":
                PlayerPrefs.SetInt("level", 12);
                if (levelsUnlocked < 12)
                    PlayerPrefs.SetInt("unlocked", 12);
                break;
            case "floor13":
                PlayerPrefs.SetInt("level", 13);
                if (levelsUnlocked < 13)
                    PlayerPrefs.SetInt("unlocked", 13);
                break;
            case "floor14":
                PlayerPrefs.SetInt("level", 14);
                if (levelsUnlocked < 14)
                    PlayerPrefs.SetInt("unlocked", 14);
                break;
            case "floor15":
                PlayerPrefs.SetInt("level", 15);
                if (levelsUnlocked < 15)
                    PlayerPrefs.SetInt("unlocked", 15);
                break;
            case "Terrain":
                PlayerPrefs.SetInt("level", 16);
                if (levelsUnlocked < 16)
                    PlayerPrefs.SetInt("unlocked", 16);
                break;
        }

        levelSelect(collision);
    }

    private void levelSelect(Collision col)
    {
        switch (col.collider.name)
        {
            case "door1":
                if (levelsUnlocked >= 1)
                    transform.position = res1.position;
                break;
            case "door2":
                if (levelsUnlocked >= 2)
                    transform.position = res2.position;
                break;
            case "door3":
                if (levelsUnlocked >= 3)
                    transform.position = res3.position;
                break;
            case "door4":
                if (levelsUnlocked >= 4)
                    transform.position = res4.position;
                break;
            case "door5":
                if (levelsUnlocked >= 5)
                    transform.position = res5.position;
                break;
            case "door6":
                if (levelsUnlocked >= 6)
                    transform.position = res6.position;
                break;
            case "door7":
                if (levelsUnlocked >= 7)
                    transform.position = res7.position;
                break;
            case "door8":
                if (levelsUnlocked >= 8)
                    transform.position = res8.position;
                break;
            case "door9":
                if (levelsUnlocked >= 9)
                    transform.position = res9.position;
                break;
            case "door10":
                if (levelsUnlocked >= 10)
                    transform.position = res10.position;
                break;
            case "door11":
                if (levelsUnlocked >= 11)
                    transform.position = res11.position;
                break;
            case "door12":
                if (levelsUnlocked >= 12)
                    transform.position = res12.position;
                break;
            case "door13":
                if (levelsUnlocked >= 13)
                    transform.position = res13.position;
                break;
            case "door14":
                if (levelsUnlocked >= 14)
                    transform.position = res14.position;
                break;
            case "door15":
                if (levelsUnlocked >= 15)
                    transform.position = res15.position;
                break;
            case "door16":
                if (levelsUnlocked >= 16)
                    transform.position = res16.position;
                break;
        }
    }
}
