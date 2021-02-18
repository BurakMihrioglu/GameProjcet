using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.ValidationRules.Abstract
{
    interface IValidateService
    {
        void Validate(Person person);
    }
}
