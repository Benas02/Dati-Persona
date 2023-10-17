namespace TestPerson
{
    [TestClass]
    public class TestPerson
    {
        #region "Test Age"
        [TestMethod]
        public void testAge() {
            // Create a new Person object with a birthdate of "01-01-2000"
            dati_persona.Person person = new dati_persona.Person("", "", "", "", "", "01-01-2000");

            // Check if the age calculation for the given birthdate is not equal to "23"
            if (person.getAge("01-01-2000") != "23") {
                // If the age calculation is incorrect, throw an exception with a message
                throw new Exception("Wrong Age");
            }

            // Reassign the person object with a different birthdate of "01-12-2000"
            person = new dati_persona.Person("", "", "", "", "", "01-12-2000");

            // Check if the age calculation for the new birthdate is not equal to "22"
            if (person.getAge("01-12-2000") != "22") {
                // If the age calculation is incorrect, throw an exception with a message
                throw new Exception("Wrong Age");
            }
        }
        #endregion

        #region "Test Costruttore"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testConstructors()
        {    
            dati_persona.Person person;

            // Create a new Person object using the default constructor (no arguments)
            person = new dati_persona.Person();

            // Create a new Person object with first name "Mario" and last name "Rossi"
            person = new dati_persona.Person("Mario", "Rossi");

            // Create a new Person object with first name "Mario," last name "Rossi," and gender "M"
            person = new dati_persona.Person("Mario", "Rossi", "M");

            // Create a new Person object with first name "Mario," last name "Rossi," gender "M," city "Roma," state "RM," and birthdate "01-01-2000"
            person = new dati_persona.Person("Mario", "Rossi", "M", "Roma", "RM", "01-01-2000");

        }
        #endregion        

        #region "Test Codice Fiscale"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testFiscalCode()
        {
            dati_persona.Person person;

            // Create a new Person object with specific attributes
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            // Check if the calculated fiscal code matches the expected one
            if (person.getFiscalCode("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002") != "BNSGRL02P25F257Z") {
                // If the fiscal code is incorrect, throw an exception with a message
                throw new Exception("Wrong Fiscal Code");
            }

        }
        #endregion

        #region "Test Gender"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testGender()
        {
            dati_persona.Person person;

            // Create a new Person object with gender "M"
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            // Check if the gender of the person is "M"
            if (person.gender == "M") {
                // If the gender is correct, it's considered OK
            }
            else {
                // If the gender is incorrect, throw an exception with a message
                throw new Exception("Wrong Gender");
            }

            // Create a new Person object with gender "F"
            person = new dati_persona.Person("Gabriele", "Benassi", "F", "Modena", "MO", "25-09-2002");

            if (person.gender == "F") {
                // If the gender is correct, it's considered OK
            }
            else {
                // If the gender is incorrect, throw an exception with a message
                throw new Exception("Wrong Gender");
            }
        }
        #endregion

        #region "Test First Name"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testFirstName()
        {
            dati_persona.Person person;

            // Create a new Person object with the first name "Gabriele"
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            // Check if the first name of the person is "Gabriele"
            if (person.firstName != "Gabriele") {
                // If the first name is incorrect, throw an exception with a message
                throw new Exception("Wrong First Name");
            }           
        }
        #endregion

        #region "Test Second Name"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testSecondName()
        {
            dati_persona.Person person;

            // Create a new Person object with the second name "Benassi"
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            // Check if the second name of the person is "Benassi"
            if (person.secondName != "Benassi")
            {
                // If the second name is incorrect, throw an exception with a message
                throw new Exception("Wrong Second Name");
            }
        }
        #endregion

        #region "Test Birth City"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testBirthCity()
        {
            dati_persona.Person person;

            // Create a new Person object with the birth city "Modena"
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            // Check if the birth city of the person is "Modena"
            if (person.birthCity != "Modena")
            {
                // If the birth city is incorrect, throw an exception with a message
                throw new Exception("Wrong Birth City");
            }
        }
        #endregion

        #region "Test Birth City Code"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testBirthCityCode()
        {
            dati_persona.Person person;

            // Create a new Person object with the birth city code "MO"
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            // Check if the birth city code of the person is "MO"
            if (person.birthCityCode != "MO")
            {
                // If the birth city code is incorrect, throw an exception with a message
                throw new Exception("Wrong Birth City Code");
            }
        }
        #endregion
    }
}