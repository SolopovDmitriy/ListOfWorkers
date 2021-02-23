using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    sealed class Tutor: Employee //запечатанный класс  - запрещает наследовангие о  него
    {
        public TutorSpeciality tutorSpeciality;

        public Tutor():base()
        {
            tutorSpeciality = TutorSpeciality.Probationer;
        }
        public Tutor(string name, string surname, string patronimic, DateTime birthDate, Genre genre, Nationality nationality, 
                                                                        EducationLevel education, float salary, TutorSpeciality tutSpec) 
            : base(name, surname, patronimic, birthDate, genre, nationality, education, salary)
        {
            tutorSpeciality = tutSpec;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tTutorSpeciality: {tutorSpeciality}; ";
        }


    }
}
