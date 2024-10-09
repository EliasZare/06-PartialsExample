using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PartialsExample
{

    //Partial Class
    partial class PartialClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PartialClass(int id, string name, string bio)
        {
            Id = id;
            Name = name;
            Bio = bio;
        }
        //Partial Method
        public partial string GetBio();
    }
    partial class PartialClass
    {
        public string Bio { get; set; }

        public string GetName()
        {
            return Name;
        }
        //Partial Method

        public partial string GetBio()
        {
            return this.Bio;
        }
    }
}
