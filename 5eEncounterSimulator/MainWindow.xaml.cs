using _5eEncounterSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5eEncounterSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Random rnd;

        public MainWindow()
        {
            InitializeComponent();

            rnd = new Random();
        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            //Creature goblin = new Creature("Goblin", "Humanoid", "LE", 15, 7, 1, 30, 0, 10, 10, 10, 10, 10, 10, null, null, null, null, null, .25, null);
            Console.WriteLine(DiceRoll(-5,12));
            
        }

        public bool RollToHit(int modifier, int armorClass)
        {
            return armorClass <= DiceRoll(1, 20, modifier);
        }




        public int DiceRoll(int number, int sides, int modifier = 0)
        {
            int total = 0;
            for (int i = 0; i < number; i++)
            {
                total += rnd.Next(1, sides + 1);
            }

            return total + modifier;
        }

        public Creature TwoCreatureCombat (Creature creatureOne, Creature creatureTwo)
        {
            //Initiative
            int creatureOneInit = DiceRoll(1, 20, creatureOne.DexMod);
            int creatureTwoInit = DiceRoll(1, 20, creatureTwo.DexMod);
            Creature first;
            Creature second;
            if(creatureOneInit > creatureTwoInit)
            {
                first = creatureOne;
                second = creatureTwo;
            }
            else if (creatureOneInit < creatureTwoInit)
            {
                first = creatureTwo;
                second = creatureOne;
            }
            else
            {
                if(creatureOne.Dex > creatureTwo.Dex)
                {
                    first = creatureOne;
                    second = creatureTwo;
                }
                else if(creatureOne.Dex < creatureTwo.Dex)
                {
                    first = creatureTwo;
                    second = creatureOne;
                }
                else
                {
                    int random = DiceRoll(1,2);
                    if(random == 1)
                    {
                        first = creatureOne;
                        second = creatureTwo;
                    }
                    else
                    {
                        first = creatureTwo;
                        second = creatureOne;
                    }
                }
            }

            //Begin combat
            while(first.CurrentHitPoints > 0 && second.CurrentHitPoints > 0)
            {
                foreach(Attack attack in first.Attacks )
                {
                    if(DiceRoll(1,20,attack.ToHitMod) >= second.ArmorClass)
                    {
                        second.CurrentHitPoints -= DiceRoll(attack.DiceNumber, attack.DamageDice, attack.DamageModifier);
                    }
                }
                if(second.CurrentHitPoints <= 0)
                {
                    break;
                }
                foreach(Attack attack in second.Attacks)
                {
                    if (DiceRoll(1, 20, attack.ToHitMod) >= first.ArmorClass)
                    {
                        first.CurrentHitPoints -= DiceRoll(attack.DiceNumber, attack.DamageDice, attack.DamageModifier);
                    }
                }
                if (first.CurrentHitPoints <= 0)
                {
                    break;
                }
            }
            if (first.CurrentHitPoints > 0)
                return first;
            else
                return second;
        }

    }
}
