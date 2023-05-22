using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
    // Class representing a patient
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
    }

    // Class representing an appointment
    class Appointment
    {
        public DateTime Date { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
    }

    // Main program class
    class Program
    {
        // List to store patients
        static List<Patient> patients = new List<Patient>();

        // List to store appointments
        static List<Appointment> appointments = new List<Appointment>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hospital Management System");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Schedule Appointment");
                Console.WriteLine("3. View Appointments");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        ScheduleAppointment();
                        break;
                    case "3":
                        ViewAppointments();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddPatient()
        {
            Console.WriteLine("Add Patient");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Patient patient = new Patient
            {
                Name = name,
                Age = age,
                Gender = gender,
                PhoneNumber = phoneNumber
            };

            patients.Add(patient);

            Console.WriteLine("Patient added successfully!");
        }

        static void ScheduleAppointment()
        {
            Console.WriteLine("Schedule Appointment");

            Console.Write("Patient Name: ");
            string patientName = Console.ReadLine();

            Console.Write("Doctor Name: ");
            string doctorName = Console.ReadLine();

            Console.Write("Date (yyyy-MM-dd HH:mm): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);

            Appointment appointment = new Appointment
            {
                Date = date,
                PatientName = patientName,
                DoctorName = doctorName
            };

            appointments.Add(appointment);

            Console.WriteLine("Appointment scheduled successfully!");
        }

        static void ViewAppointments()
        {
            Console.WriteLine("View Appointments");

            Console.Write("Enter patient name: ");
            string patientName = Console.ReadLine();

            Console.WriteLine("Appointments for " + patientName + ":");

            foreach (var appointment in appointments)
            {
                if (appointment.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Doctor: " + appointment.DoctorName);
                    Console.WriteLine("Date: " + appointment.Date.ToString("yyyy-MM-dd HH:mm"));
                    Console.WriteLine();
                }
            }
        }
    }
}
