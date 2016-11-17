using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Battle : MonoBehaviour
{
    //creates a list for characters and 2 lists for the teams
    private List<Classes> Characters = new List<Classes>();
    private List<Classes> Team1 = new List<Classes>();
    private List<Classes> Team2 = new List<Classes>();
    public static List<string> NameList = new List<string>();

    //Int to keep track of rounds
    public int RoundCount = 1;

    public void AddName()
    {
        //Adds names to the characters
        NameList.Add("Soldier");
        NameList.Add("Theif");
        NameList.Add("Rouge");
        NameList.Add("Mage");
        NameList.Add("Wizard");
        NameList.Add("Warlock");
        NameList.Add("Shaman");
        NameList.Add("Warrior");
        NameList.Add("Fighter");
        NameList.Add("Cheiftain");

        Classes classes = new Classes();

        //Adds 10 characters to the character list
        for (int i = 0; i < 10; i++)
        {
            Characters.Add(new Classes());
        }

        PickCharacter();

    }

	void Start () 
    {
        AddName();
	}

    void PickCharacter()
    {
        //Creates a random number which represents the picks for each team
        int RandomCharacterPick1 = UnityEngine.Random.Range(0, 9);
        int RandomCharacterPick2 = UnityEngine.Random.Range(0, 8);
        int RandomCharacterPick3 = UnityEngine.Random.Range(0, 7);
        int RandomCharacterPick4 = UnityEngine.Random.Range(0, 6);
        int RandomCharacterPick5 = UnityEngine.Random.Range(0, 5);
        int RandomCharacterPick6 = UnityEngine.Random.Range(0, 4);

        //The teams takes turns picking character and then removes that character from the character list
        var Character1Team1 = Characters[RandomCharacterPick1];
        Team1.Add(Character1Team1);
        Characters.Remove(Characters[RandomCharacterPick1]);
        
        var Character1Team2 = Characters[RandomCharacterPick2];
        Team2.Add(Character1Team2);
        Characters.Remove(Characters[RandomCharacterPick2]);

        var Character2Team1 = Characters[RandomCharacterPick3];
        Team1.Add(Character2Team1);
        Characters.Remove(Characters[RandomCharacterPick3]);

        var Character2Team2 = Characters[RandomCharacterPick4];
        Team2.Add(Character2Team2);
        Characters.Remove(Characters[RandomCharacterPick4]);

        var Character3Team1 = Characters[RandomCharacterPick5];
        Team1.Add(Character3Team1);
        Characters.Remove(Characters[RandomCharacterPick5]);

        var Character3Team2 = Characters[RandomCharacterPick6];
        Team2.Add(Character3Team2);
        Characters.Remove(Characters[RandomCharacterPick6]);

        Fight();
    }

    void Fight()
    {

        //While both teams have atleast 1 character remaining the fight continues
        while (Team1.Count >= 1 && Team2.Count >= 1)
        {

            //creates a random number and then checks if dodgechance is less than it
            //if thats the case then check run crit chance function
            int Dodge = UnityEngine.Random.Range(1, 100);
            int Crit = UnityEngine.Random.Range(1, 100);

            if (Team1.Count >= 1)
            {
                if (Team2[0].DodgeChance < Dodge)
                {
                    //Creates a random number and if critchance is higher or above multiply the damage by two
                   //Then remove the crit bonus
                    //If crit chance is lower than deal normal damage
                    //Display information
                    if (Team1[0].CritChance >= Crit)
                    {

                        Team2[0].Health = Team2[0].Health - (Team1[0].Damage * 2);
                        Debug.Log(Team1[0]._ClassName + " Dealt " + (Team1[0].Damage * 2) + " to " + Team2[0]._ClassName + " HP: " + Team1[0].Health);
                    }
                    else
                    {
                        Team2[0].Health = Team2[0].Health - Team1[0].Damage;
                        Debug.Log(Team1[0]._ClassName + " Dealt " + Team1[0].Damage + " to " + Team2[0]._ClassName + " HP: " + Team1[0].Health);
                    }

                    //checks if the character in the front has a Health value equal to 0
                    //if thats the case remove that character from the list
                }
                else
                {
                    Debug.Log("Dodged");
                }
            }

            if (Team2[0].Health <= 0)
            {
                Team2.Remove(Team2[0]);
            }

            if (Team2.Count >= 1)
            {
                //same process as the one above
                if (Team1[0].DodgeChance < Dodge)
                {
                    if (Team2[0].CritChance >= Crit)
                    {

                        Team1[0].Health = Team1[0].Health - (Team2[0].Damage * 2);
                        Debug.Log(Team2[0]._ClassName + " Dealt " + (Team2[0].Damage * 2) + " to " + Team1[0]._ClassName + " HP: " + Team1[0].Health);
                    }
                    else
                    {
                        Team1[0].Health = Team1[0].Health - Team2[0].Damage;
                        Debug.Log(Team2[0]._ClassName + " Dealt " + Team2[0].Damage + " to " + Team1[0]._ClassName + " HP: " + Team1[0].Health);
                    }
                }
                else
                {
                    Debug.Log("Dodged");

                }
            }

            if (Team1[0].Health <= 0)
            {
                Team1.Remove(Team1[0]);
            }

            Debug.Log("Round" + RoundCount);
            ++RoundCount;
        }

        //Checks if either team has less than or equal to 0 characters in the list
        //Then display a message depending on what team is victorious
        if (Team1.Count <= 0)
        {
            Debug.Log("Team2 is victorious");
        }
        else if (Team2.Count <= 0)
        {
            Debug.Log("Team1 is victorious");
        }
    }

}