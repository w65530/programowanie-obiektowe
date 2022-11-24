﻿namespace ModelViewControllerProject.Models.Person
{
	public class PersonModel
	{
		public PersonModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public string City { get; set; }

        public List<PersonModel> GetPeople()
        {
            return new List<PersonModel>()
            {
                new PersonModel()
                {
                    Name = "Andrzej",
                    City = "Rzeszów",
                    Gender = GenderEnum.Male,
                    Id = 1
                },
                new PersonModel()
                {
                    Name = "Katarzyna",
                    City = "Rzeszów",
                    Gender = GenderEnum.Female,
                    Id = 2
                },
                new PersonModel()
                {
                    Name = "Julia",
                    City = "Kraków",
                    Gender = GenderEnum.Female,
                    Id = 3
                },
                new PersonModel()
                {
                    Name = "Piotr",
                    City = "Kraków",
                    Gender = GenderEnum.Male,
                    Id = 4
                }
            };
        }
    }
}
