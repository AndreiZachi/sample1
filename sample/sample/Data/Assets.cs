using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace sample.Data
{
    public class Assets
    {
        public string Img { get; set; }

        public string Link { get; set; }

        public override string ToString()
        {
            return Img;
        }


    }
}
