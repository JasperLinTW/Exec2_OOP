using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1._1A2Bgame
{
    public partial class Form1 : Form
    {
        private GuessNumber game;
        public Form1()
        {
            InitializeComponent();
            resultLable.Text = string.Empty;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            game = new GuessNumber();
            game.NewAnswer();
            resultLable.Text = game.Hint;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int[] guessNumber;
            try
            {
                guessNumber = GetGuessNumber();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            GuessResult result = game.CheckAnswer(guessNumber);
            if (result.isSuccess) 
            {
                MessageBox.Show("恭喜答對");
            }
            else
            {
                resultLable.Text = result.hint;
                MessageBox.Show("再接再厲");
                
            }
            
            

        }

        private int[] GetGuessNumber()
        {
            TextBox txt = this.guessTxtBox;
            string input = txt.Text;
            if(string.IsNullOrEmpty(input)) throw new Exception("您未輸入內容");
            bool isInt = int.TryParse(input, out int number);
            if (input.Length != 4 || !isInt) throw new Exception("您輸入的數字非4個整數");
           
            int[] guessNumber = new int[4];
            for (int i = 0; i < 4; i++)
            {
                guessNumber[i] = Convert.ToInt32(input[i].ToString());
            }
            return guessNumber;
            
        }
    }
    public class GuessNumber
    {
        private int[] answer;
        public string Hint;
        public void NewAnswer()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            int[] pool = new int[10];
            for (int i = 0; i < pool.Length; i++)
            {
                pool[i] = i;
            }
            for (int i = 0; i < pool.Length; i++)
            {
                int position = random.Next(1, 10);
                int temp;
                temp = pool[i];
                pool[i] = pool[position];
                pool[position] = temp;
            }
            answer = new int[4];
            Array.Copy(pool,answer,4);
            Hint = string.Join(" ", answer);
        }

        public GuessResult CheckAnswer(int[] input)
        {
            int a = 0;
            int b = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if(this.answer[i] == input[i]) a++;
                if(this.answer.Contains(input[i])) b++;
            }
            int[] result =new int[]{a, b-a};
            Hint = $"{result[0]}A{result[1]}B\r\n{string.Join(" ",answer)}";
            if (result[0] == 4)
            {
                return GuessResult.Success();
            }
            else
            {
                return GuessResult.Failded(this.Hint);
            }
            


        }
    }
    public class GuessResult
    {
        public bool isSuccess { get; set; }
        public string hint { get; set; }
        public static GuessResult Success()
        {
            return new GuessResult { isSuccess = true, hint = string.Empty };
        }
        public static GuessResult Failded(string errmessage)
        {
            return new GuessResult { isSuccess = false, hint = errmessage };
        }
    }
}
