using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Named { get; set; }
        public string Specialization { get; set; }
        public bool IsValid { get; set; }

        public Doctor(string named, string specialization)
        {
            this.Named = named;
            this.Specialization = specialization;
            this.IsValid = Addme.AddMe(new string[]{named, specialization});
        }
        public override string ToString()
        {
            return $"{this.Named}\n Especializado: {this.Specialization}\n";
        }
    }
}