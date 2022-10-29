using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        private PlayGame game; 
        public Form1()
        {
            InitializeComponent();
			game = new PlayGame();
			resultLable.Text = string.Empty;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {              
            answerTxtBox.Text = game.NewGame();
            resultLable.Text = game.CalcPoint();
        }
    }
    public class PlayGame
    {
        public int[] points { get; set; }
        public int sumCouple { get; set; }

        public string NewGame()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            int[] numbers = new int[4];
            bool isValid = false;
            int sum = 0;
			while (isValid == false)
            {
                for (int i = 0; i < 4; i++)
                {
                    numbers[i] = random.Next(1, 7);
                }
                Array.Sort(numbers);
                
                for (int i = 0; i < 4; i++)
                {
                    for (int j = i+1; j < 4; j++)
                    {
                        if (numbers[i] == numbers[j]) 
                        {
							isValid = true;
							sum = numbers[i] + numbers[j];
                            i = 5;
                            j = 5;
						}                        
                    }
                }
            }
			points = numbers;
            sumCouple = sum;
            return string.Join("、", points);
	}
        public string CalcPoint()
        {
            int total = 0;
            foreach (var point in points)
            {
                total += point;
            }
            int result = total-sumCouple;
            string msg = $"您得到的點數是{result}";
            return msg;
        }
    }
    
}
