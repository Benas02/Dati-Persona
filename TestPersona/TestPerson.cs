namespace TestPerson
{
    [TestClass]
    public class TestPerson
    {
        #region "Test Age"
        [TestMethod]
        public void testAge() {
            dati_persona.Person person = new dati_persona.Person("", "", "", "", "", "01-01-2000");

            if(person.getAge("01-01-2000") != "23") {
                throw new Exception("");
            }

            person = new dati_persona.Person("", "", "", "", "", "01-12-2000");

            if (person.getAge("01-12-2000") != "22") {
                throw new Exception("");
            }
        }
        #endregion

        // --------------------------------------------------------------------------------------------------------

        #region "Test Costruttore"
        [TestMethod]
        public void testConstructors()
        {
            dati_persona.Person person;

            person = new dati_persona.Person();
            person = new dati_persona.Person("Mario", "Rossi");
            person = new dati_persona.Person("Mario", "Rossi", "M");
            person = new dati_persona.Person("Mario", "Rossi", "M", "Roma", "RM", "01-01-2000");

        }
        #endregion

        // --------------------------------------------------------------------------------------------------------

        #region "Test Codice Fiscale"
        [TestMethod]
        public void testFiscalCode()
        {
            dati_persona.Person person;
        
            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            if(person.getFiscalCode("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002") != "BNSGRL02P25F257Z") {
                throw new Exception("");
            }

        }
        #endregion

        // --------------------------------------------------------------------------------------------------------

        #region "Test Gender"
        [TestMethod]
        public void testGender()
        {
            dati_persona.Person person;

            person = new dati_persona.Person("Gabriele", "Benassi", "M", "Modena", "MO", "25-09-2002");

            if (person.gender == "M") {
                // OK
            } else {
                throw new Exception("");
            }

            person = new dati_persona.Person("Gabriele", "Benassi", "F", "Modena", "MO", "25-09-2002");

            if (person.gender == "F") {
                // OK
            }
            else {
                throw new Exception("");
            }



        }
        #endregion

        // --------------------------------------------------------------------------------------------------------
    }
}