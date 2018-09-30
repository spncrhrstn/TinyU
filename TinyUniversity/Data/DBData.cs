﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyUniversity.Models;

namespace TinyUniversity.Data
{
    public class DBData
    {
        public static void Initialize()
        {
            var students = new Student[] {
                new Student{ Firstname = "Kaitlin", Lastname = "Gonzalez", EnrollmentDate = DateTime.Parse("2018-03-22")}, new Student{ Firstname = "Nolan", Lastname = "Harrington", EnrollmentDate = DateTime.Parse("2018-04-13")}, new Student{ Firstname = "Tarik", Lastname = "Valenzuela", EnrollmentDate = DateTime.Parse("2018-05-03")}, new Student{ Firstname = "Carlos", Lastname = "Moody", EnrollmentDate = DateTime.Parse("2018-06-09")}, new Student{ Firstname = "Robert", Lastname = "Preston", EnrollmentDate = DateTime.Parse("2018-03-23")}, new Student{ Firstname = "Grace", Lastname = "Holland", EnrollmentDate = DateTime.Parse("2018-07-29")}, new Student{ Firstname = "Sybil", Lastname = "Richards", EnrollmentDate = DateTime.Parse("2018-08-20")}, new Student{ Firstname = "Shelly", Lastname = "Dean", EnrollmentDate = DateTime.Parse("2018-04-09")}, new Student{ Firstname = "Declan", Lastname = "Tate", EnrollmentDate = DateTime.Parse("2017-10-22")}, new Student{ Firstname = "Melinda", Lastname = "Sawyer", EnrollmentDate = DateTime.Parse("2017-09-09")}, new Student{ Firstname = "Megan", Lastname = "Osborn", EnrollmentDate = DateTime.Parse("2018-05-14")}, new Student{ Firstname = "Holmes", Lastname = "Fleming", EnrollmentDate = DateTime.Parse("2017-11-27")}, new Student{ Firstname = "Yasir", Lastname = "Marshall", EnrollmentDate = DateTime.Parse("2017-09-23")}, new Student{ Firstname = "Jada", Lastname = "Merrill", EnrollmentDate = DateTime.Parse("2018-07-21")}, new Student{ Firstname = "Quamar", Lastname = "Jones", EnrollmentDate = DateTime.Parse("2017-09-12")}, new Student{ Firstname = "Yetta", Lastname = "Hogan", EnrollmentDate = DateTime.Parse("2018-08-24")}, new Student{ Firstname = "Stacy", Lastname = "Yang", EnrollmentDate = DateTime.Parse("2018-06-29")}, new Student{ Firstname = "Dieter", Lastname = "Gay", EnrollmentDate = DateTime.Parse("2017-10-18")}, new Student{ Firstname = "Judith", Lastname = "Rush", EnrollmentDate = DateTime.Parse("2017-11-13")}, new Student{ Firstname = "Ava", Lastname = "Stone", EnrollmentDate = DateTime.Parse("2017-11-12")}, new Student{ Firstname = "Echo", Lastname = "Hinton", EnrollmentDate = DateTime.Parse("2018-07-01")}, new Student{ Firstname = "Barry", Lastname = "Deleon", EnrollmentDate = DateTime.Parse("2018-02-15")}, new Student{ Firstname = "Cleo", Lastname = "Wilkerson", EnrollmentDate = DateTime.Parse("2018-05-16")}, new Student{ Firstname = "Kamal", Lastname = "Rodriquez", EnrollmentDate = DateTime.Parse("2018-01-08")}, new Student{ Firstname = "Nelle", Lastname = "Bennett", EnrollmentDate = DateTime.Parse("2017-12-23")}, new Student{ Firstname = "Alisa", Lastname = "Sandoval", EnrollmentDate = DateTime.Parse("2018-08-10")}, new Student{ Firstname = "Chandler", Lastname = "Pace", EnrollmentDate = DateTime.Parse("2017-09-16")}, new Student{ Firstname = "Ocean", Lastname = "Jones", EnrollmentDate = DateTime.Parse("2017-12-22")}, new Student{ Firstname = "Gray", Lastname = "Odom", EnrollmentDate = DateTime.Parse("2018-07-04")}, new Student{ Firstname = "Sylvester", Lastname = "Watkins", EnrollmentDate = DateTime.Parse("2018-01-01")}, new Student{ Firstname = "Catherine", Lastname = "Hutchinson", EnrollmentDate = DateTime.Parse("2018-06-08")}, new Student{ Firstname = "Kai", Lastname = "Woodward", EnrollmentDate = DateTime.Parse("2018-04-25")}, new Student{ Firstname = "Quemby", Lastname = "Alvarado", EnrollmentDate = DateTime.Parse("2017-12-04")}, new Student{ Firstname = "Montana", Lastname = "Morton", EnrollmentDate = DateTime.Parse("2018-07-18")}, new Student{ Firstname = "Orli", Lastname = "Nelson", EnrollmentDate = DateTime.Parse("2017-11-21")}, new Student{ Firstname = "Alexander", Lastname = "Cabrera", EnrollmentDate = DateTime.Parse("2018-02-09")}, new Student{ Firstname = "Kessie", Lastname = "Ayala", EnrollmentDate = DateTime.Parse("2018-08-28")}, new Student{ Firstname = "Athena", Lastname = "Lyons", EnrollmentDate = DateTime.Parse("2018-03-19")}, new Student{ Firstname = "Joelle", Lastname = "Blanchard", EnrollmentDate = DateTime.Parse("2018-03-11")}, new Student{ Firstname = "Brent", Lastname = "Lancaster", EnrollmentDate = DateTime.Parse("2018-03-26")}, new Student{ Firstname = "Lilah", Lastname = "Cardenas", EnrollmentDate = DateTime.Parse("2018-03-16")}, new Student{ Firstname = "Elton", Lastname = "Puckett", EnrollmentDate = DateTime.Parse("2017-11-14")}, new Student{ Firstname = "Shelley", Lastname = "Sharp", EnrollmentDate = DateTime.Parse("2018-03-16")}, new Student{ Firstname = "Reece", Lastname = "Langley", EnrollmentDate = DateTime.Parse("2018-08-26")}, new Student{ Firstname = "Fitzgerald", Lastname = "Knox", EnrollmentDate = DateTime.Parse("2018-08-28")}, new Student{ Firstname = "Hedy", Lastname = "Lloyd", EnrollmentDate = DateTime.Parse("2017-12-15")}, new Student{ Firstname = "Sloane", Lastname = "Pugh", EnrollmentDate = DateTime.Parse("2018-01-23")}, new Student{ Firstname = "Oliver", Lastname = "Blackwell", EnrollmentDate = DateTime.Parse("2017-10-24")}, new Student{ Firstname = "Dieter", Lastname = "Eaton", EnrollmentDate = DateTime.Parse("2017-12-09")}, new Student{ Firstname = "Fallon", Lastname = "Rice", EnrollmentDate = DateTime.Parse("2018-05-26")}, new Student{ Firstname = "Cullen", Lastname = "Pitts", EnrollmentDate = DateTime.Parse("2017-10-26")}, new Student{ Firstname = "Kaseem", Lastname = "Alvarez", EnrollmentDate = DateTime.Parse("2017-10-09")}, new Student{ Firstname = "Ginger", Lastname = "Mitchell", EnrollmentDate = DateTime.Parse("2017-09-20")}, new Student{ Firstname = "Nolan", Lastname = "Wooten", EnrollmentDate = DateTime.Parse("2018-02-16")}, new Student{ Firstname = "Ryan", Lastname = "Roy", EnrollmentDate = DateTime.Parse("2017-10-25")}, new Student{ Firstname = "Wyatt", Lastname = "Glass", EnrollmentDate = DateTime.Parse("2018-05-06")}, new Student{ Firstname = "Frances", Lastname = "Francis", EnrollmentDate = DateTime.Parse("2018-02-07")}, new Student{ Firstname = "Alice", Lastname = "Chambers", EnrollmentDate = DateTime.Parse("2018-05-28")}, new Student{ Firstname = "Paloma", Lastname = "Schroeder", EnrollmentDate = DateTime.Parse("2018-02-25")}, new Student{ Firstname = "Conan", Lastname = "Lambert", EnrollmentDate = DateTime.Parse("2017-10-05")}, new Student{ Firstname = "Timon", Lastname = "Huber", EnrollmentDate = DateTime.Parse("2018-07-23")}, new Student{ Firstname = "Jocelyn", Lastname = "Kirby", EnrollmentDate = DateTime.Parse("2018-01-09")}, new Student{ Firstname = "Aurelia", Lastname = "Hendrix", EnrollmentDate = DateTime.Parse("2017-11-14")}, new Student{ Firstname = "Kirestin", Lastname = "Shields", EnrollmentDate = DateTime.Parse("2018-05-28")}, new Student{ Firstname = "Karina", Lastname = "Tillman", EnrollmentDate = DateTime.Parse("2017-12-14")}, new Student{ Firstname = "Roth", Lastname = "Beach", EnrollmentDate = DateTime.Parse("2018-06-23")}, new Student{ Firstname = "Donna", Lastname = "Joyce", EnrollmentDate = DateTime.Parse("2018-04-13")}, new Student{ Firstname = "Brenden", Lastname = "Mckenzie", EnrollmentDate = DateTime.Parse("2017-12-04")}, new Student{ Firstname = "Anastasia", Lastname = "Hinton", EnrollmentDate = DateTime.Parse("2018-04-18")}, new Student{ Firstname = "Sigourney", Lastname = "Martinez", EnrollmentDate = DateTime.Parse("2018-07-12")}, new Student{ Firstname = "Nadine", Lastname = "Combs", EnrollmentDate = DateTime.Parse("2017-11-17")}, new Student{ Firstname = "Penelope", Lastname = "Holder", EnrollmentDate = DateTime.Parse("2018-07-05")}, new Student{ Firstname = "Iliana", Lastname = "Collier", EnrollmentDate = DateTime.Parse("2017-12-22")}, new Student{ Firstname = "Sage", Lastname = "Benjamin", EnrollmentDate = DateTime.Parse("2018-05-13")}, new Student{ Firstname = "Nigel", Lastname = "Calhoun", EnrollmentDate = DateTime.Parse("2018-04-24")}, new Student{ Firstname = "Leah", Lastname = "Colon", EnrollmentDate = DateTime.Parse("2017-10-20")}, new Student{ Firstname = "Ginger", Lastname = "Stout", EnrollmentDate = DateTime.Parse("2017-12-17")}, new Student{ Firstname = "Chava", Lastname = "Aguirre", EnrollmentDate = DateTime.Parse("2018-01-09")}, new Student{ Firstname = "Owen", Lastname = "Pruitt", EnrollmentDate = DateTime.Parse("2018-06-15")}, new Student{ Firstname = "Nehru", Lastname = "Duran", EnrollmentDate = DateTime.Parse("2018-08-13")}, new Student{ Firstname = "Garrett", Lastname = "Burris", EnrollmentDate = DateTime.Parse("2017-10-02")}, new Student{ Firstname = "Haviva", Lastname = "Cobb", EnrollmentDate = DateTime.Parse("2018-01-13")}, new Student{ Firstname = "Kimberly", Lastname = "Guzman", EnrollmentDate = DateTime.Parse("2018-03-23")}, new Student{ Firstname = "Alyssa", Lastname = "Sutton", EnrollmentDate = DateTime.Parse("2018-08-01")}, new Student{ Firstname = "Vladimir", Lastname = "Emerson", EnrollmentDate = DateTime.Parse("2018-05-15")}, new Student{ Firstname = "Neil", Lastname = "Suarez", EnrollmentDate = DateTime.Parse("2017-10-02")}, new Student{ Firstname = "Kaden", Lastname = "Morales", EnrollmentDate = DateTime.Parse("2017-11-17")}, new Student{ Firstname = "Irma", Lastname = "Avery", EnrollmentDate = DateTime.Parse("2018-03-03")}, new Student{ Firstname = "Dante", Lastname = "Pollard", EnrollmentDate = DateTime.Parse("2018-04-22")}, new Student{ Firstname = "Raymond", Lastname = "Leblanc", EnrollmentDate = DateTime.Parse("2017-10-11")}, new Student{ Firstname = "Tatyana", Lastname = "Madden", EnrollmentDate = DateTime.Parse("2018-01-05")}, new Student{ Firstname = "Honorato", Lastname = "Griffith", EnrollmentDate = DateTime.Parse("2018-04-13")}, new Student{ Firstname = "Griffith", Lastname = "French", EnrollmentDate = DateTime.Parse("2018-07-10")}, new Student{ Firstname = "Erin", Lastname = "Shannon", EnrollmentDate = DateTime.Parse("2017-11-01")}, new Student{ Firstname = "Rashad", Lastname = "Johns", EnrollmentDate = DateTime.Parse("2018-03-01")}, new Student{ Firstname = "Rigel", Lastname = "Wolf", EnrollmentDate = DateTime.Parse("2017-12-25")}, new Student{ Firstname = "Daquan", Lastname = "Burgess", EnrollmentDate = DateTime.Parse("2018-06-04")}, new Student{ Firstname = "Amery", Lastname = "Farmer", EnrollmentDate = DateTime.Parse("2018-03-19")}, new Student{ Firstname = "Preston", Lastname = "Rollins", EnrollmentDate = DateTime.Parse("2018-04-07")}, new Student{ Firstname = "Owen", Lastname = "Delacruz", EnrollmentDate = DateTime.Parse("2018-07-04") } };
        }
    }
}