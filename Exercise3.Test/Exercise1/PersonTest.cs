using Exercise3.Exercise301;

namespace Exercise3.Test.Exercise1
{
    public class PersonTest
    {
        PersonHandler pHandler = new();

        [Fact]
        public void PersonHandler_CreatePerson_With_Valid_Inputs()
        {
            //Arrange
            int age = 36;
            string fname = "Ronald";
            string lname = "McDonald";
            int height = 180;
            int weight = 120;

            //Act
            Person person = pHandler.CreatePerson(age, fname, lname, height, weight);

            //Assert
            Assert.Equal(age, person.Age);
            Assert.Equal(fname, person.FName);
            Assert.Equal(lname, person.LName);
            Assert.Equal(height, person.Height);
            Assert.Equal(weight, person.Weight);
        }

        [Fact]
        public void PersonHandler_CreatePerson_WithAge0_ShouldThrowException()
        {
            //Arrange
            int age = 0;
            string fname = "Ronald";
            string lname = "McDonald";
            int height = 180;
            int weight = 120;

            //Act
            Action act = () => pHandler.CreatePerson(age, fname, lname, height, weight);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void PersonHandler_CreatePerson_WithTooShortFName_ShouldThrowException()
        {
            //Arrange
            int age = 36;
            string invalidFName = "R";
            string lname = "McDonald";
            int height = 180;
            int weight = 120;

            //Act
            Action act = () => pHandler.CreatePerson(age, invalidFName, lname, height, weight);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void PersonHandler_CreatePerson_WithTooLongFName_ShouldThrowException()
        {
            //Arrange
            int age = 36;
            string invalidFName = "RonaldRonald";
            string lname = "McDonald";
            int height = 180;
            int weight = 120;

            //Act
            Action act = () => pHandler.CreatePerson(age, invalidFName, lname, height, weight);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void PersonHandler_CreatePerson_WithTooShortLName_ShouldThrowException()
        {
            //Arrange
            int age = 36;
            string fname = "Ronald";
            string invalidLName = "Mc";
            int height = 180;
            int weight = 120;

            //Act
            Action act = () => pHandler.CreatePerson(age, fname, invalidLName, height, weight);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void PersonHandler_CreatePerson_WithTooLongLName_ShouldThrowException()
        {
            //Arrange
            int age = 36;
            string fname = "Ronald";
            string invalidLName = "McDonaldMcDonald";
            int height = 180;
            int weight = 120;

            //Act
            Action act = () => pHandler.CreatePerson(age, fname, invalidLName, height, weight);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void PersonHandler_SetAge_WithValidAgeAfterInstantiation()
        {
            //Assert
            int age = 36;
            string fname = "Ronald";
            string lname = "McDonald";
            int height = 180;
            int weight = 120;
            int newAge = 40;

            //Act
            Person person = pHandler.CreatePerson(age, fname, lname, height, weight);
            pHandler.SetAge(person, newAge);

            //Assert
            Assert.Equal(newAge, person.Age);
        }

        [Fact]
        public void PersonHandler_SetAge_WithInvalidValidAgeAfterInstantiation_ShouldReturnException()
        {
            //Assert
            int age = 36;
            string fname = "Ronald";
            string lname = "McDonald";
            int height = 180;
            int weight = 120;
            int newAge = 0;

            //Act
            Person person = pHandler.CreatePerson(age, fname, lname, height, weight);
            Action act = () => pHandler.SetAge(person, newAge);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}
