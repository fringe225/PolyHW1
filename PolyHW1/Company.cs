using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyHW1
{
    internal class Company
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                while (true)
                {
                    bool CheckUpper = false;
                    bool CheckSymbol = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsUpper(value[i]) && i == 0)
                        {
                            CheckUpper = true;
                            break;
                        }
                        else if (char.IsSymbol(value[i]))
                        {
                            CheckSymbol = true;
                            break;
                        }

                    }
                    if (CheckSymbol && CheckUpper)
                    {
                        _name = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Companiyanin adini duzgun daxil edin!");
                        value = Console.ReadLine() ?? "";
                    }
;
                }
            }
        }
            

        public static int Limit { get; set; }
        public static Employe[] Employees = new Employe[0];

        public Company(string name,int limit)
        {
            this._name = name;
            Limit = limit;
        }

        public static void AddEmploye(Employe value)
        {
            if (IsFree())
            {
                Array.Resize(ref Employees, Employees.Length+1);
                Employees[Employees.Length - 1] = value;
            }
            else
            {
                Console.WriteLine("No vacancies in this state !");
            }
        }

        public Employe[] GetEmployes()
        {
            return Employees;
        }
        public static bool IsFree() //maybe add Resize
        {
            if(Employees.Length < Limit)
            {
                return true;
            }
            return false;
        }

        public static Employe SearchEmployes(string search)
        {
            foreach (var item in Employees)
            {
                if(item.Fullname == search)
                {
                    return item;
                }

            }
            return new Employe("Not Found",0,"Not Found");
        }

        public static void RemoveEmploye(ref Employe[] employes ,int no)
        {
            Employe[] empl = new Employe[Employees.Length - 1];
            for (int i = 0; i < Employees.Length; i++)
            {
                
                if (Employees[i].No == no)
                {
                    for (int j = 0; j < i; j++)
                    {
                        empl[j] = Employees[j];
                    }
                    for (int k = i; k < empl.Length; k++)
                    {
                        empl[k] = Employees[k+1];
                    }

                }
            }

            employes = empl;
        }

    }
}
