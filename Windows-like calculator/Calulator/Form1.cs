using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    public partial class Form1 : Form
    {
        private double[] numbers = new double[15];
        int counter = 0;
        private String number = "0";
        int type = 0;
        private bool resultGiven = false;
        int insideCounter = 0;
        int lastType = 0;
        private bool dot = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultGiven = false;
            
            if (label1.Text != "0")
            {
                if (label1.Text.Length == 1)
                {
                    label1.Text = "0";
                    number = "0";
                }
                else
                {
                    number = number.Remove(number.Length - 1);
                    label1.Text = number;
                    if (label1.Text.Substring(0, 1) == "0")
                    {
                        label1.Text = label1.Text.Substring(1,label1.Text.Length-1);
                    }
                        
                }
                
            }
            
        }

        

        

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            

            if (number == "0" || label1.Text == "0")
                label1.Text = "";

            if (resultGiven)
            {
                label1.Text = "1";
                number = "1";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "1";
                number += "1";
            }
            
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
           
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "2";
                number = "2";
                resultGiven = false;
                
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "2";
                number += "2";
            }
        }
        

        private void button18_Click(object sender, EventArgs e)
        {
            
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "3";
                number = "3";
                resultGiven = false;
                if (results.Text != "" && results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "3";
                number += "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "4";
                number = "4";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "4";
                number += "4";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "5";
                number = "5";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "5";
                number += "5";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "6";
                number = "6";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "6";
                number += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "7";
                number = "7";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "7";
                number += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "8";
                number = "8";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "8";
                number += "8";
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "9";
                number = "9";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "9";
                number += "9";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
            
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven)
            {
                label1.Text = "0";
                number = "0";
                resultGiven = false;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else
            {
                label1.Text += "0";
                number += "0";
            }
        }
        
        private void button22_Click(object sender, EventArgs e)     //dodawanie przecinka
        {
            if (number == "0" || label1.Text == "0")
                label1.Text = "";
            
            if (resultGiven && dot == false)
            {
                label1.Text = "0,";
                number = "0,";
                resultGiven = false;
                dot = true;
                if (results.Text != "" && results.Text.Substring(results.Text.Length - 1) == "=")
                    results.Text = "";
            }
            else if(dot == false)
            {
                label1.Text += ",";
                number += ",";
                dot = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)      //clear all
        {
            number = "0";
            label1.Text = number;
            results.Text = "";
            counter = 0;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            number = "0";
            label1.Text = number;
        }
        

        private void button17_Click(object sender, EventArgs e)     //dodawanie
        {

            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);

                number = "";
                type = 1;
                @equals(type);
                if(counter > 0)
                    results.Text = results.Text.Remove(results.Text.Length - 1);
                
                results.Text += "+";
                if(counter < 1)
                    counter++;
            }
            else if (label1.Text == results.Text.Remove(results.Text.Length - 1))
                results.Text = results.Text.Remove(results.Text.Length - 1) + "+";
            
        }
        
        private void button13_Click(object sender, EventArgs e)     //odejmowanie
        {

            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);
                
                number = "";
                type = 2;
                @equals(type);
                if(counter > 0)
                    results.Text = results.Text.Remove(results.Text.Length - 1);
                
                results.Text += "-";
                if(counter < 1)
                    counter++;
            }
            else if (label1.Text == results.Text.Remove(results.Text.Length - 1))
                results.Text = results.Text.Remove(results.Text.Length - 1) + "-";
        }
        
        private void button9_Click(object sender, EventArgs e)      //mnożenie
        {
            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);

                number = "";
                type = 3;
                @equals(type);
                if(counter > 0)
                    results.Text = results.Text.Remove(results.Text.Length - 1);
                
                results.Text += "*";
                if(counter < 1)
                    counter++;
            }
            else if (label1.Text == results.Text.Remove(results.Text.Length - 1))
                results.Text = results.Text.Remove(results.Text.Length - 1) + "*";
        }
        
        private void button5_Click(object sender, EventArgs e)      //dzielenie
        {
            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);

                number = "";
                type = 4;
                @equals(type);
                if(counter > 0)
                    results.Text = results.Text.Remove(results.Text.Length - 1);
                
                results.Text += "/";
                if(counter < 1)
                    counter++;
            }
            
        }
        
        private void button7_Click(object sender, EventArgs e)      //potega kwadratowa
        {
            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);
                
                type = 5;
                @equals(type);
            }
        }
        
        private void button6_Click(object sender, EventArgs e)      //pierwiastek kwadratowy
        {
            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);
                
                type = 6;
                @equals(type);
            }
        }
        
        private void button8_Click(object sender, EventArgs e)      //jeden przez
        {
            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);
                
                type = 7;
                @equals(type);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)      //procent
        {
            if (number != "")
            {
                numbers[counter] = Convert.ToDouble(number);
                
                type = 8;
                @equals(type);
            }
        }
        
        private void button24_Click(object sender, EventArgs e) //Zmiana znaku na przeciwny
        {
            if (number.StartsWith("0"))
                number = number.Remove(0, 1);
            
            if (number != "" && number != "0")
            {
                if (number.StartsWith("-"))
                {
                    number = number.Remove(0, 1);
                    label1.Text = number;
                }
                else
                {
                    number = "-" + number;
                    label1.Text = number;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)     //końcowy wynik
        {
            double finalResult;
            if (number != "" && counter > 0)
            {
                double first, second;
                String operation = "";

                if (type == 5 || type == 6 || type == 7 || type == 8)
                {
                    if (results.Text.Contains("+"))
                        type = 1;
                    else if (results.Text.Contains("-"))
                        type = 2;
                    else if (results.Text.Contains("+"))
                        type = 3;
                    else if (results.Text.Contains("/"))
                        type = 4;
                }
                
                numbers[counter] = Convert.ToDouble(number);
                first = numbers[0];
                second = numbers[1];
                counter++;
                finalResult = @equals(type);
                label1.Text = Convert.ToString(finalResult);
                counter = 0;
                number = Convert.ToString(finalResult);
                resultGiven = true;

                if (type == 1)
                    operation = " + ";
                else if (type == 2)
                    operation = " - ";
                else if (type == 3)
                    operation = " * ";
                else if (type == 4)
                    operation = " / ";
                

                results.Text = first + operation + second + " =";
            }
            else if (number != "" && results.Text.Contains("sqr"))
            {
                results.Text += "=";
            }
            
            
        }
        
        public double equals(int type)  
        
        {
            double result;

            dot = false;
            
            if (counter > 0)
            {
                if (type != 5 && type != 6 && type != 7 && type != 8)
                {
                    if (results.Text.Substring(results.Text.Length - 1) == "+")
                        type = 1;
                    else if (results.Text.Substring(results.Text.Length - 1) == "-")
                        type = 2;
                    else if (results.Text.Substring(results.Text.Length - 1) == "*")
                        type = 3;
                    else if (results.Text.Substring(results.Text.Length - 1) == "/")
                        type = 4;
                }
                
            }
            
            if (counter < 1 && type == 1)
            {
                results.Text = numbers[0].ToString();
                resultGiven = true;
            }
            
            if (counter >= 1 && type == 1)
            {
                result = numbers[0] + numbers[1];
                numbers[0] = result;
                counter = 1;
                results.Text = result.ToString() + "+";
                label1.Text = result.ToString();
                resultGiven = true;
                return result;
            }
            
            if (counter < 1 && type == 2)
            {
                results.Text = numbers[0].ToString();
                resultGiven = true;
            }

            if (counter >= 1 && type == 2)
            {
                result = numbers[0] - numbers[1];
                numbers[0] = result;
                counter = 1;
                results.Text = result.ToString() + "-";
                label1.Text = result.ToString();
                resultGiven = true;
                return result;
            }
            
            if (counter < 1 && type == 3)
            {
                results.Text = numbers[0].ToString();
                resultGiven = true;
            }

            if (counter >= 1 && type == 3)
            {
                result = numbers[0] * numbers[1];
                numbers[0] = result;
                counter = 1;
                results.Text = result.ToString() + "*";
                label1.Text = result.ToString();
                resultGiven = true;
                return result;
            }
            
            if (counter < 1 && type == 4)
            {
                results.Text = numbers[0].ToString();
                resultGiven = true;
            }

            if (counter >= 1 && type == 4)
            {
                result = numbers[0] / numbers[1];
                numbers[0] = result;
                counter = 1;
                results.Text = result.ToString() + "/";
                label1.Text = result.ToString();
                resultGiven = true;
                return result;
            }

            if (type == 5)
            {
                if (results.Text.Contains("sqr") || results.Text.Contains("="))
                    results.Text = "";
                
                result = Convert.ToDouble(number) * Convert.ToDouble(number);
                label1.Text = result.ToString();
                results.Text += "sqr(" + numbers[counter] + ")";
                number = result.ToString();
                numbers[counter] = result;
                resultGiven = true;
                return result;
            }
            
            if (type == 6)
            {
                if (results.Text.Contains("√") || results.Text.Contains("="))
                    results.Text = "";
                
                result = Math.Sqrt(Convert.ToDouble(number));
                label1.Text = result.ToString();
                results.Text += "√(" + numbers[counter] + ")";
                number = result.ToString();
                numbers[counter] = result;
                resultGiven = true;
                return result;
            }
            
            if (type == 7)
            {
                if (results.Text.Contains("1/") || results.Text.Contains("="))
                    results.Text = "";
                
                result = 1/(Convert.ToDouble(number));
                label1.Text = result.ToString();
                results.Text += "1/(" + numbers[counter] + ")";
                number = result.ToString();
                numbers[counter] = result;
                resultGiven = true;
                return result;
            }
            
            if (type == 8)
            {
                if (counter > 0)
                {
                    result = numbers[0] * (Convert.ToDouble(number)/100);
                    label1.Text = result.ToString();
                    results.Text += result.ToString();
                    number = result.ToString();
                    numbers[counter] = result;
                    resultGiven = true;
                    return result;
                }
                else
                {
                    number = "0";
                    label1.Text = "0";
                    resultGiven = true;
                }
            }
            return 0;
        }


        
    }
}