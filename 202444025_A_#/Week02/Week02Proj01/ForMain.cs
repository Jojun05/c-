﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class ForMain: Form
    {
        public ForMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked; //true or false

            if (isToggle)
            {
                string data1 = tbxInput1.Text;
                string data2 = tbxInput2.Text;
                string result = data1 + data2; //문자열 연결 연산자(1+2 = 12) 이런게 문자열
                lblResult.Text = result;
            }
            else
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; // 산술 연산자 (문자열이였다가 숫자로 바꾼거)
                lblResult.Text = result.ToString();
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if(chkToggle.Checked == false)
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술연산자 
                lblResult.Text = "더하기:"+ result.ToString();
            }
            else
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result =  data1 - data2; //산술연산자 
                lblResult.Text = "빼기:" + result; //문자열 + 술자 => 문자열 연결 연산자로 동작
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                int result = data1 + data2; //산술연산자 
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                int result = data1 - data2; //산술연산자 
                lblResult.Text = $"빼기: {result}"; //문자열 보간법
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInput1.Text);
            double data2 = double.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                double result = data1 + data2; //산술연산자 
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                double result = data1 - data2; //산술연산자 
                lblResult.Text = $"빼기: {result}"; //문자열 보간법
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine; // "\r\n"
            //lblResult.Text = Environment.NewLine; //문자열
            lblResult.Text += tbxInput1.Text.GetType();
            //lblResult.Text = tbxInput1.Text.GetType(); //문자열이 아님
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInput1.Text[0]; //chat (문자)
            //lblResult.Text = tbxInput1.Text[0];
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];
            // C언어 char 1바이트 (ascii)
            // C# char 2바이트 (unicode)
            byte result1 = (byte)test1;   //1바이트 정수형
            sbyte result4 = (sbyte)test1; //1바이트 부호지원 정수형
            short result2 = (short)test1; //2바이트 부호지원 정수형
            ushort result3 = test1;       //2바이트 부호미지원 정수형
            // int , uint, long, ulong (8)
            lblResult.Text += $"{test1},{result1},{result2},{result3},";
        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            //정수 -> 실수 : OK 
            //실수 -> 정수 : 처리 필요
            //작은 숫자 -> 큰 숫자 : OK
            //큰  숫지 -> 작은 숫자 : 처리 필요 
            int data1 = short.Parse(tbxInput1.Text);
            float data2 = (float)double.Parse(tbxInput2.Text);
            long data3 = long.Parse(tbxInput3.Text);
            int data4 = (int)data3;

            double result = data1 + data2 + data3 + data4;
            lblResult.Text = result.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)1.9 + (int)1.6 => 2
            long result2 = data1 +(long)data2 + data3 + data4;
            lblResult.Text += result.ToString();


            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)(1.9 + 1.6) => 3
            long result3 = (long)(data1 + data2 + data3 + data4);
            lblResult.Text += result.ToString();
        }
    }
}
