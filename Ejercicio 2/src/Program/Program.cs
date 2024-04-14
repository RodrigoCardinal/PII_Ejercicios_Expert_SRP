using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */
            
            Doctor doctor1 = new Doctor("Armand", "Oculista");
            Patient patient1 = new Patient("Steven Jhonson", "5555-555-555", "986782342", 22);
            Appointment appointment1 = new Appointment("1A", "Wall Street", DateTime.Now, patient1, doctor1);


            Doctor doctor2 = new Doctor("","Otorrino");
            Patient patient2 = new Patient("Ralf Manson","", "5555-555-555", 20);
            Appointment appointment2 = new Appointment("2A", "Queen Street", DateTime.Now, patient2, doctor2);

            Console.WriteLine(appointment1);
            Console.WriteLine(appointment2);
        }
    }
}