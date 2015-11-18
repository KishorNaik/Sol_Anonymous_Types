using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Anonymous_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonymous Types

            // Create a Anonymous Type
            var AnonymousTypesObj = new {FirstName="Kishor",LastName="Naik"};

            // Read Anonymous Type
            System.Console.WriteLine("{0} {1}", AnonymousTypesObj.FirstName, AnonymousTypesObj.LastName);

            #endregion

            #region Pass Anonymous type into Object

            Developer DeveloperObj = new Developer() {FirstName=AnonymousTypesObj.FirstName,LastName=AnonymousTypesObj.LastName};

            System.Console.WriteLine("{0} {1}",DeveloperObj.FirstName, DeveloperObj.LastName);

            #endregion

            #region Pass Anonymous Type as Parameter

            ReadAnonymousType(new {FirstName = "Yogesh", LastName = "Naik"});

            #endregion

            #region Anonymous type as Return type.

            var ReturnAnonymousTypeData = ReturnAnonymousType();
            System.Console.WriteLine("{0} {1}",ReturnAnonymousTypeData.FirstName,ReturnAnonymousTypeData.LastName);

            #endregion

          
        }

        /// <summary>
        /// Anonymous type as function Parameter
        /// </summary>
        /// <param name="AnonymousTypePara"></param>
        private static void ReadAnonymousType(dynamic AnonymousTypePara)
        {
            System.Console.WriteLine("{0} {1}",AnonymousTypePara.FirstName, AnonymousTypePara.LastName);
        }

        /// <summary>
        /// Anonymous type as Return type.
        /// </summary>
        /// <returns></returns>
        private static dynamic ReturnAnonymousType()
        {
            return new {FirstName = "Deepika", LastName = "Naik"};
        }

    }

    public class Developer
    {
        #region Property 

        public String FirstName { get; set; }

        public String LastName { get; set; }

        #endregion
    }
}
