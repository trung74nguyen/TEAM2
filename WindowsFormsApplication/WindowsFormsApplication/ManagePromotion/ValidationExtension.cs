﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication.ManagePromotion
{
    class ValidationExtension
    {
        public bool Required(TextBox t)
        {
            string a = t.Text.ToString();
            if (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsNumber(TextBox t)
        {
            string a = t.Text.ToString();
            int n = -1;
            try
            {
                n = int.Parse(a);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }
        
    }
}