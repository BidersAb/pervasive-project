using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPervasive.Model
{
	public class User
	{
		public Profile profile { get; set; }
		public Address Address { get; set; }
        public User()
        {

        }
		public User(Profile profile, Address address)
		{
			this.Address = address;	
			this.profile = profile;
		}
		public User GetUser()
        {
			User user = new User();
			user.Address = this.Address;
			user.profile = this.profile;
			return user;
        }
	}
	public class Profile
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Age { get; set; }
		public string Gender { get; set; }
	}
		public class Address
	{
		public string City { get; set; }
		public string Country { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		
	}
}
