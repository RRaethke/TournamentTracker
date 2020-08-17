using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The person's first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The person's last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The phone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
