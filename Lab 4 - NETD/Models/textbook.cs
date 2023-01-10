/*
 * Name: Shivam Janda
 * Date: November 21, 2022
 * Description: textbook class and its properties
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4___NETD.Models
{
    public class textbook
    {
        /// <summary>
        /// Accessors and Mutators
        /// </summary>
        public string title { get; set; }
        public int isbn { get; set; }
        public float version { get; set; }
        public float price { get; set; }
        public string condition { get; set; }

        /// <summary>
        /// Deafult Constructor
        /// </summary>
        public textbook()
        {

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        public textbook(string title, int isbn, float version, float price, string condition)
        {
            this.title = title;
            this.isbn = isbn;
            this.version = version;
            this.price = price;
            this.condition = condition;
        }

        /// <summary>
        /// Appraised price that checks what condition it is and generating a price for it 
        /// </summary>
        public double appraisedPrice(float price, string conditon)
        {
            if (condition == "New")
            {
                return Math.Round((price / 2), 2);
            }

            else if (condition == "Good")
            {
                return Math.Round((price / 3), 2);
            }

            else
            {
                return Math.Round((price / 4), 2);
            }
        }
        /// <summary>
        /// Method that returns a string of the textbook and its attributes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Your textbook: " + this.title +
                ", Version: " + this.version +
                ", was appraised at: $" + appraisedPrice(this.price, this.condition);
        }
    }
}
