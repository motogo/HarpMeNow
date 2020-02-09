using BasicClassLibrary;
using System;
using System.Collections.Generic;


namespace HarpMeNow
{
    public class SelectedClass
    {

        public string Culture = "de";



        protected SelectedClass()
        {            
           
        }

        
        private static SelectedClass instance = null;
        public static SelectedClass Instance()
        {
            
            if (instance == null)
            {
                instance = new SelectedClass();
            }
            return (instance);
        }

    }
}
