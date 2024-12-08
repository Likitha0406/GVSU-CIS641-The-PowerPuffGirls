using System;
using SQLite;

namespace nitesh_passman.ViewModel
{
	public class PasswordModel
	{

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string Title { get; set; }
        public int isPasswordVisible { get; set; }
        public int isObscureVisible { get; set; }
        public string Password { get; set; }
        public int isExpanded { get; set; }
    }
}

