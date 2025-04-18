using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI attackText;
    [SerializeField] TextMeshProUGUI energyText;
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI defenseText;
    [SerializeField] TextMeshProUGUI criticalChanceText;
    [SerializeField] TextMeshProUGUI criticalMultiplierText;
    [SerializeField] TextMeshProUGUI accuracyText;
    [SerializeField] TextMeshProUGUI ability1Text;
    [SerializeField] TextMeshProUGUI ability2Text;

    [SerializeField] float health;
    [SerializeField] float attack;
    [SerializeField] float energy;
    [SerializeField] float speed;
    [SerializeField] float defense;
    [SerializeField] float criticalChance;
    [SerializeField] float criticalMultiplier;
    [SerializeField] float accuracy;

    public enum Abilities1
    {
        BoulderSmash,
        IncreaseAccuracy,
        LightningBolt,
        X2Damage,
        ShurikenThrow,
        WaterStream,
        LowerSpeed,
        HealAll,
        Fireball,
        ExtraTurn,
        OpponentsLoseTurn
    }

    public Abilities1 ability1;


    public enum Abilities2
    {
        IncreaseCriticalChance,
        Confuse2Opponents,
        ConfuseAnOpponent,
        IncreaseSpeed,
        HealSelf,
        AttackTeam,
        RegainEnergy,
        IncreaseCriticalDamage,
        HealTeammate,
        LoseATurn,
        Vortex
    }

    public Abilities2 ability2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCharacter(string charName)
    {
        switch (charName)
        {
           case "Dood":
                health = 75;
                attack = 80;
                energy = 8;
                speed = 45;
                defense = 85;
                criticalChance = 50;
                criticalMultiplier = 1;
                accuracy = 45;

                ability1 = Abilities1.BoulderSmash;
                ability2 = Abilities2.IncreaseCriticalChance;
                break;

            case "Faedor":
                health = 50;
                attack = 55;
                energy = 6;
                speed = 60;
                defense = 70;
                criticalChance = 45;
                criticalMultiplier = 1.25f;
                accuracy = 60;

                ability1 = Abilities1.IncreaseAccuracy;
                ability2 = Abilities2.Confuse2Opponents;
                break;

            case "Inirt":
                health = 65;
                attack = 50;
                energy = 6;
                speed = 55;
                defense = 45;
                criticalChance = 40;
                criticalMultiplier = 1.25f;
                accuracy = 60;

                ability1 = Abilities1.LightningBolt;
                ability2 = Abilities2.ConfuseAnOpponent;
                break;

            case "Kcaz":
                health = 80;
                attack = 60;
                energy = 5;
                speed = 90;
                defense = 45;
                criticalChance = 25;
                criticalMultiplier = 1.5f;
                accuracy = 75;

                ability1 = Abilities1.X2Damage;
                ability2 = Abilities2.IncreaseSpeed;
                break;

            case "Kim":
                health = 95;
                attack = 75;
                energy = 9;
                speed = 80;
                defense = 65;
                criticalChance = 20;
                criticalMultiplier = 2;
                accuracy = 85;

                ability1 = Abilities1.ShurikenThrow;
                ability2 = Abilities2.HealSelf;
                break;

            case "Leio":
                health = 60;
                attack = 60;
                energy = 6;
                speed = 65;
                defense = 70;
                criticalChance = 70;
                criticalMultiplier = .75f;
                accuracy = 60;

                ability1 = Abilities1.WaterStream;
                ability2 = Abilities2.AttackTeam;
                break;

            case "Mikeul":
                health = 50;
                attack = 55;
                energy = 7;
                speed = 45;
                defense = 65;
                criticalChance = 30;
                criticalMultiplier = 1.25f;
                accuracy = 80; 

                ability1 = Abilities1.LowerSpeed;
                ability2 = Abilities2.RegainEnergy;
                break;

            case "Prince":
                health = 70;
                attack = 85;
                energy = 8;
                speed = 55;
                defense = 80;
                criticalChance = 10;
                criticalMultiplier = 2;
                accuracy = 35;

                ability1 = Abilities1.HealAll;
                ability2 = Abilities2.IncreaseCriticalDamage;
                break;

            case "Sonja":
                health = 90;
                attack = 65;
                energy = 7;
                speed = 40;
                defense = 50;
                criticalChance = 50;
                criticalMultiplier = 1.15f;
                accuracy = 50;

                ability1 = Abilities1.Fireball;
                ability2 = Abilities2.HealTeammate;
                break;

            case "Tomay":
                health = 85;
                attack = 70;
                energy = 5;
                speed = 60;
                defense = 60;
                criticalChance = 20;
                criticalMultiplier = 1.75f;
                accuracy = 65;

                ability1 = Abilities1.ExtraTurn;
                ability2 = Abilities2.LoseATurn;
                break;

            case "Viewtl":
                health = 45;
                attack = 35;
                energy = 7;
                speed = 71;
                defense = 100;
                criticalChance = 85;
                criticalMultiplier = 1.75f;
                accuracy = 65;

                ability1 = Abilities1.OpponentsLoseTurn;
                ability2 = Abilities2.Vortex;
                break;
        }



        healthText.text = "Health: " + health;
        attackText.text = "Attack: " + attack;
        energyText.text = "Energy: " + energy;
        speedText.text = "Speed: " + speed;
        defenseText.text = "Defense: " + defense;
        criticalChanceText.text = "Critical Chance: " + criticalChance;
        criticalMultiplierText.text = "Critical Multiplier: " + criticalMultiplier;
        accuracyText.text = "Accuracy: " + accuracy;

        ability1Text.text = ability1.ToString();
        ability2Text.text = ability2.ToString();

    }
}
