using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traditional_Singleton_Pattern;

public class Singleton
{
    private static Singleton instance;      //It's declared as static to ensure there's only one instance shared across all instances of the class.

    private Singleton()      //private ctor to prevent  the creation of new instances of the Singleton class from outside the class
    {
        
    }


    public static Singleton GetInstance()      //the method should be static to call it by class name without using any objects
    { 
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;            // It first checks if instance is null, and if it is,
                                    // it creates a new instance of the class and assigns it to instance.
                                    // If an instance already exists, it returns the existing instance.
    }


}
