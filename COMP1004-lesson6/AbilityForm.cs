using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_lesson6
{
    public partial class AbilityForm : Form
    {

        private Random _random;

        //Initialize variables in the constructor



        public AbilityForm()
        {
            InitializeComponent();
            this._initilize();
        }

        private void _initilize()
        {
            this._random = new Random(); // instantiate object of the type Random
        }

        private void RollAbiltiesButton_Click(object sender, EventArgs e)
        {
            //Call the roll abilities method
            RollAbilities();

        }

        /// <summary>
        /// This methods generates 6 abilities for the character sheet
        /// </summary>
        private void RollAbilities()
        {

            Program.character.Strength = Roll4D6();
            StrengthTextBox.Text = Program.character.Strength.ToString();

            Program.character.Dexterity = Roll4D6();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();

            Program.character.Inteligence = Roll4D6();
            InteligenceTextBox.Text = Program.character.Inteligence.ToString();

            Program.character.Charisma = Roll4D6();
            CharismaTextBox.Text = Program.character.Charisma.ToString();

            Program.character.Wisdom = Roll4D6();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();

            Program.character.Constitution = Roll4D6();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
        }
        /// <summary>
        /// This method rolls 4D6 and returns the highest 3 dice
        /// </summary>
        private int Roll4D6()
        {
            List<int> dice = new List<int>(); //Instantiates an empty integer list
            int result = 0;

            for (int count = 0; count < 4; count++)
            {
                dice.Add(this._random.Next(6) + 1);

            }

            dice.Sort();

            dice.Remove(0);

            result = dice.Sum();



            return result;
        }
    }
}
