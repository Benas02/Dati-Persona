namespace TestPerson
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void testAge() {
            dati_persona.Person person = new dati_persona.Person("", "", "", "", "", "01-01-2000");

            if(person.getAge() != "23") {
                throw new Exception("");
            }

            person = new dati_persona.Person("", "", "", "", "", "01-12-2000");

            if (person.getAge() != "22") {
                throw new Exception("");
            }
        }
    }
}