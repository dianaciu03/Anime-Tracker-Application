using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Reviews
{
    public class ReviewDataValidator
    {
        public ReviewDataValidator()
        {

        }

        public bool IsDescriptionValid(string description)
        {
            if (String.IsNullOrEmpty(description))
                throw new Exception("You need to provide a description!");
            else
                return true;
        }

        public bool IsRatingValid(string rating)
        {
            if (!String.IsNullOrEmpty(rating))
            {
                try
                {
                    decimal nr = Convert.ToDecimal(rating);
                    if (nr >= 1 && nr <= 5)
                        return true;
                    else
                        throw new Exception("The rating must be between 1 and 5!");
                }
                catch (Exception)
                {
                    throw new Exception("The rating is not valid number!");
                }
            }
            else
                throw new Exception("You need to provide a number for episodes!");
        }
    }
}
