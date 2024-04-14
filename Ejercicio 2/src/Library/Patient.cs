using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public bool IsValid { get; set; }

        public Patient (string name, string id, string phonenumber, int age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phonenumber;
            this.Age = age;
            this.IsValid = Addme.AddMe(new string[]{name, id, phonenumber});
        }

        public override string ToString()
        {
            return $"\n Nombre del paciente:{this.Name}\n Cédula: {this.Id}\n Edad: {this.Age}\n Número de teléfono: {this.PhoneNumber}";
        }
    }
}