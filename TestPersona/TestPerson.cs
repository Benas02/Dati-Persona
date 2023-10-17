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

        #region "Test Codice Fiscale"
        /*[TestMethod]
        public void testCF()
        {
            dati_persona.Person person = new dati_persona.Person("", "", "", "", "", "01-01-2000");

            if (person.getFiscalCode("", "", "", "", "", "01-01-2000").Length == 16)
            {
                throw new Exception("");
            }
        }*/
        #endregion
    }
}