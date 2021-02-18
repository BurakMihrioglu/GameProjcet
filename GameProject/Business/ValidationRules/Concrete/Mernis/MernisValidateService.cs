using GameProject.Business.ValidationRules.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.ValidationRules.Concrete.Mernis
{
    class MernisValidateService : IValidateService
    {
        public void Validate(Person person)
        {
            if (person.Name.Length>1 && person.LastName.Length>1 && person.NationalityNumber.Length==11 && person.YearOfBirth>1800)
            {
                Console.WriteLine(person.Name + " " + person.LastName + " Mernis doğrulamasından geçti!");
            }
            else
            {
                throw new Exception(person.Name + " " + person.LastName + " Mernis doğrulamasından geçemedi!");
            }
        }
    }
}
