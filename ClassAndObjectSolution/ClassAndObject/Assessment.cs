using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Assessment
    {
        //the access privilege to this class is public
        //programs (outside user) can use this class
        //it's NOT static, therefore the outside user will have to create (instantiate) an instance of this class if they wish to use it

        //Private Data Member
        //a private data member CAN be reached by the outside user
        private string _Comment;

        //Properties
        //properties are the interface to the outside world
        //properties that are referenced by the outside world need to be exposed (made public)
        //syntax:
        //accesstype datatype propertyname {coding block}

        //autoimplemented properties don't need a private data member
        //data is stored internally by the system using the requested datatype
        //access to data stored using this implementation MUST be via the property name
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssessmentName { get; set; }
        public double Mark { get; set; }

        //fully implemented properties require a private data member of the same datatype as the property
        //data is stored in the private data member
        //any coding within the class itself can access the private data member
        //best practices is to always use the property and NOT directly access the private data member
        //reason for the above: the property likely has special coding to validate or manage the data which you do not want to bypass
        //Comment is a nullable field. it's a string. we wish to avoid storing an empty string. we either have NO data (null) or we have a character string with at least one real character
        public string Comment
        {
            //get is used when the use of the property is on the "right side" of an assignment statement
            get { return _Comment; }
            //set is used when the data is trying to be placed within the instance ("left side" of an assignment statement)
            //since properties DON'T have a parameter list AND are associated with a single piece of data, the data within the property is accessed using the keyword "value"
            set { _Comment = string.IsNullOrEmpty(value) ? null : value; }
        }

        //if your class has no constructor, the system will create an instance AND initialize all your data storage areas (data members of auto properties) to their basic system defaults (int = 0, boolean = false, etc)
       
        //WARNING: if you code one constructor, then you are responsible for ANY and ALL constructors
        //the system will not do anything on your behalf


        //      Constructors:
        //Constructors are used to intialize the beginning state of an instance

        //"Default" constructor
        //characteristic: no parameters
        //coding block may or may not assign literal values to your data storage
        public Assessment()
        {
            //optionally assign a literal value to a data storage area
            //notice below: good coding practice is to use properties and NOT directly the data member
            //Mark = 0.0;
            //Comment = "no comment";
        }

        //"Greedie" constructor
        //characteristic: one parameter for each data storage item in the class
        public Assessment(string firstname, string lastname, string assessmentname, double mark, string comment)
        {
            FirstName = firstname;
            LastName = lastname;
            AssessmentName = assessmentname;
            Mark = mark;
            Comment = comment;
        }
    }
}
