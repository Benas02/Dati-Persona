using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dati_persona
{
    public class Person {
        #region "Proprietà"
        // -------------------- Proprietà --------------------
        public string firstName;
        public string secondName;
        public string gender;
        public string birthCity;
        public string birthCityCode;
        public string birthDate;
        #endregion

        #region "Costruttore"
        // -------------------- Costruttore Vuoto --------------------
        public Person() : this("", "", "", "", "", "") { }

        // -------------------- Costruttore con Parametri --------------------
        public Person(string firstName, string secondName) : this(firstName, secondName, "", "", "", "") { }

        // -------------------- Costruttore con Parametri --------------------
        public Person(string firstName, string secondName, string gender) : this(firstName, secondName, gender, "", "", "") { }

        // -------------------- Costruttore con Parametri --------------------
        /// <summary>
        /// Costruttore della Classe Person
        /// </summary>
        /// <param name="firstName">First Name of the Person</param>
        /// <param name="secondName">Second Name of the Personparam>
        /// <param name="gender">Gender of the Person</param>
        /// <param name="birthCity">Birth City of the Person</param>
        /// <param name="birthCityCode">Birth City Code of the Person</param>
        /// <param name="birthDate">Birth Date of the Person</param>
        public Person(string firstName, string secondName, string gender, string birthCity, string birthCityCode, string birthDate) { 
            this.firstName = firstName;
            this.secondName = secondName;
            this.gender = gender;
            this.birthCity = birthCity;
            this.birthCityCode = birthCityCode;
            this.birthDate = birthDate;
        }
        #endregion

        #region "First Name - Second Name"
        // -------------------- Metodo che Setta il Nome --------------------
        /// <summary>
        /// Prompts the User to input their First Name and returns it as a string.
        /// </summary>
        /// <returns>The First Name entered by the User.</returns>
        public string setFirstName()
        {
            string firstName;

            // Prompt the user to enter their first name
            Console.Write("\nFirst Name: ");

            // Read the input from the console and store it in the firstName variable
            firstName = Console.ReadLine();

            return firstName;
        }

        // -------------------- Metodo che Setta il Cognome --------------------
        /// <summary>
        /// Prompts the User to input their Second Name and returns it as a string.
        /// </summary>
        /// <returns>The Second Name entered by the User.</returns>
        public string setSecondName() {
            string secondName;

            // Prompt the user to enter their second name
            Console.Write("Second Name: ");

            // Read the input from the console and store it in the secondName variable
            secondName = Console.ReadLine();

            return secondName;
        }
        #endregion

        #region "Gender"
        // -------------------- Metodo che Setta il Gender --------------------
        /// <summary>
        /// Prompts the User to input their Gender (M/F) and returns it as a string.
        /// </summary>
        /// <returns>The Gender ("M" or "F") entered by the User.</returns>
        public string setGender()
        {
            string gender;

            do {
                // Prompt the user to enter their gender and convert the input to uppercase
                Console.Write("Gender (M/F): ");

                // Read the input from the console and store it in the gender variable
                gender = Console.ReadLine();
                gender = gender.ToUpper();
            } while (gender != "M" && gender != "F");

            return gender;
        }
        #endregion

        #region "Birth City - Birth City Code - Birth Date"
        // -------------------- Metodo che Setta il Birth City --------------------
        /// <summary>
        /// Prompts the user to input their Birth City and returns it as a string.
        /// </summary>
        /// <returns>The Birth City entered by the user.</returns>
        public string setBirthCity() {
            string birthCity;

            // Prompt the user to enter their birth city
            Console.Write("Birth City: ");

            // Read the input from the console and store it in the birthCity variable
            birthCity = Console.ReadLine();

            return birthCity;
        }

        // -------------------- Metodo che Setta il Birth City Code --------------------
        /// <summary>
        /// Prompts the User to input their Birth City Code (XX) and returns it as a string.
        /// </summary>
        /// <returns>The Birth City Code entered by the User.</returns>
        public string setBirthCityCode()
        {
            string birthCityCode;

            // Prompt the user to enter their birth city code
            Console.Write("Birth City Code (XX): ");

            // Read the input from the console and store it in the birthCityCode variable
            birthCityCode = Console.ReadLine();

            return birthCityCode;
        }

        // -------------------- Metodo che Setta il Birth Date --------------------
        /// <summary>
        /// Prompts the User to input their Birth Date (XX-XX-XXXX) and returns it as a string.
        /// </summary>
        /// <returns>The Birth Date entered by the User.</returns>
        public string setBirthDate()
        {
            string birthDate;

            // Prompt the user to enter their birth date
            Console.Write("Birth Date (XX-XX-XXXX): ");

            // Read the input from the console and store it in the birthDate variable
            birthDate = Console.ReadLine();

            return birthDate;
        }
        #endregion

        #region "Menu"
        // -------------------- Motodo Menu --------------------
        /// <summary>
        /// Display a menu for user interaction and return the selected option.
        /// </summary>
        /// <returns>The user's selected option (0-3).</returns>
        public int stampaMenu() {
            int answer;

            Console.WriteLine("\n---------------------------------");

            // Display the menu options
            Console.WriteLine("\n1) INSERIRE una PERSONA");
            Console.WriteLine("2) CODICE FISCALE della PERSONA");
            Console.WriteLine("3) ETÁ della PERSONA");
            Console.WriteLine("0) USCIRE");

            do
            {
                // Prompt the user to select an action and read the input as an integer
                Console.Write("\nSelezionare l'Azione da Eseguire (0-3): ");
                answer = Int32.Parse(Console.ReadLine());
            } while (answer < 0 || answer > 3);

            return answer;
        }

        // -------------------- Motodo che Setta il Menu --------------------
        /// <summary>
        /// Present a menu and handle user's actions based on their selection.
        /// </summary>
        public void setScelta() {
            int menu;

            do {
                // Display the menu and get the user's selection
                menu = stampaMenu();

                switch (menu) {
                    case 1:
                        // Action 1: Insert a new person's information
                        this.setNewPerson();
                        break;
                    case 2:
                        try {
                            // Action 2: Display the age of the person
                            Console.WriteLine("\n" + this.firstName + " Age: " + this.getAge(this.birthDate));
                        } catch (Exception e) {
                            Console.WriteLine("\nDati Inseriti in Modo Errato o Inesistenti");
                            this.setNewPerson();
                        }
                        break;
                    case 3:
                        try {
                            // Action 3: Display the fiscal code of the person
                            Console.WriteLine("\nCF: " + this.getFiscalCode(this.firstName, this.secondName, this.gender, this.birthCity, this.birthCityCode, this.birthDate));
                        } catch (Exception e) {
                            Console.WriteLine("\nDati Inseriti in Modo Errato o Inesistenti");
                            this.setNewPerson();
                        }
                        break;
                    case 0:
                        // Action 0: Exit the program (commented out)
                        //Environment.Exit(0);              // CHIUDE IL PROGRAMMA
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            } while (menu != 0);
        }
        #endregion

        #region "Set New Person"
        // -------------------- Metodo che Lancia il Programma --------------------
        /// <summary>
        /// Collect and set a new person's information by invoking input methods.
        /// </summary>
        public void setNewPerson() {
            // Use various input methods to collect information and set object attributes
            this.firstName = this.setFirstName();
            this.secondName = this.setSecondName();
            this.gender = this.setGender();
            this.birthCity = this.setBirthCity();
            this.birthCityCode = this.setBirthCityCode();
            this.birthDate = this.setBirthDate();
        }
        #endregion

        #region "Get Age"
        // -------------------- Metodo che Restituisce l'Età --------------------
        /// <summary>
        /// Calculate and return a person's age based on their birth date.
        /// </summary>
        /// <param name="birthDate">The birth date in the format "XX-XX-XXXX".</param>
        /// <returns>The age of the person as a string.</returns>
        public string getAge(string birthDate) {
            string age;

            // Get the current date
            DateTime data_odierna = DateTime.Today;

            // Convert the birth date string to a DateTime object
            DateTime data_nascita = Convert.ToDateTime(birthDate);

            // Calculate the age by subtracting the birth year from the current year
            int differenza_eta = data_odierna.Year - data_nascita.Year;

            // Adjust the age if the birth month and day haven't occurred yet this year
            if (data_nascita.Month > data_odierna.Month) {
                differenza_eta = differenza_eta - 1;
            } else if (data_nascita.Month == data_odierna.Month && data_nascita.Day > data_odierna.Day) {
                differenza_eta = differenza_eta - 1;
            }

            // Convert the age to a string and return it
            age = differenza_eta.ToString();
            return age;
        }
        #endregion

        #region "Get Fiscal Code"
        // -------------------- Metodo che Restituisce il Codice Fiscale --------------------
        /// <summary>
        /// Generate and return a person's fiscal code based on their information.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="secondName">The second name of the person.</param>
        /// <param name="gender">The gender of the person (M/F).</param>
        /// <param name="birthCity">The birth city of the person.</param>
        /// <param name="birthCityCode">The birth city code (XX) of the person.</param>
        /// <param name="birthDate">The birth date of the person in the format "XX-XX-XXXX".</param>
        /// <returns>The fiscal code of the person as a string or an exception message.</returns>
        public string getFiscalCode(string firstName, string secondName, string gender, string birthCity, string birthCityCode, string birthDate) {
            // Parse the birth date string to a DateTime object
            var parsedDate = DateTime.Parse(birthDate);
            string fiscalCode;

            try {
                // Create a CodiceFiscaleUtility.CodiceFiscale object based on the provided information
                CodiceFiscaleUtility.CodiceFiscale CF;
                CF = new CodiceFiscaleUtility.CodiceFiscale(secondName, firstName, gender, parsedDate, birthCity, birthCityCode);

                // Get the fiscal code
                fiscalCode = CF.Codice;
            } catch (Exception e) {
                // Handle exceptions and return an error message
                fiscalCode = $"Exception: {e.Message}";
            }

            return fiscalCode;
        }
        #endregion
    }
}
