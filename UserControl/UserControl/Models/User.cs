using System;
using System.Collections.Generic;
using System.Text;

namespace UserControl.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}
