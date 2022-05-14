using Lab6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6.Model
{
    class Words
    {
        public int returnResult(string text)
        {
            text = text.Trim(new char[] { ',', '.' });
            string[] textArray = text.Split(new char[] { ' ' });
            return textArray.Length;
        }

    }
}
