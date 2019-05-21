using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGit
{
    public class Logic
    {
        public bool checkUserAge(User user)
        {
            if(user.Age>18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void checkNumber(int number)
        {
            if (number % 2 != 0)
                throw new ArgumentOutOfRangeException();

            //Our code
        }
    }
}
