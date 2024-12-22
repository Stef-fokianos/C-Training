using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Ασκηση 1.6: Δημιουργήστε ένα console application το οποίο θα περιέχει ένα custom type με όνομα “CustomDataTypes”,
//  το οποίο θα περιέχει properties με όλα τα primitive types. Όταν το app τρέξει, θα δείξει στην κονσόλα τις τιμές 
//  από όλα τα properties. Επίσης, θα περιλαμβάνει και μια μέθοδο η οποία θα προσθέτει 2 ακέραιους και θα επιστρέφει το αποτέλεσμά της.


class Task1_6
{
    static void Main(string[] args)
    {
        //Creation of a CustomDataType object 
        CustomDataTypes data = new CustomDataTypes
        {
            booleanData = true,
            shortData = 10,
            floatData = 10.10f,
            integerData = 1,
            charData = 'A',
            stringData = "ABC",
            doubleData = 1.001,
            decimalData = 1.10m,
            longData = 1001001001,


        };

        //Print all properties of data object in console
        Console.WriteLine("All primitive data type examples: ");
        Console.WriteLine();
        Console.WriteLine($"Boolean Value: {data.booleanData}" );
        Console.WriteLine($"Byte Value:  {data.byteData}");
        Console.WriteLine($"Short Value: {data.shortData}");
        Console.WriteLine($"Float Value: {data.floatData}");
        Console.WriteLine($"Integer Value: {data.integerData}");
        Console.WriteLine($"Character Value: {data.charData}");
        Console.WriteLine($"String Value: {data.stringData}");
        Console.WriteLine($"Double Value: {data.doubleData}");
        Console.WriteLine($"Decimal Value: {data.decimalData}");
        Console.WriteLine($"Long Value : {data.longData}");
        Console.WriteLine();

        //Adding and printing of int A = 1 and int B = 2 
        int intA = 1, intB = 2;
        int resultAB = data.AddIntegers(intA, intB);

        Console.WriteLine($"Result of adding A + B = {resultAB} ");
        

    }


    public class CustomDataTypes
        //This is a custom class containing properties that contain all primitive data types.
    {
        //Boolean data type
        public bool booleanData { get; set; }
        //Byte data type
        public byte byteData { get; set; }
        //Short data type 
        public short shortData { get; set; }
        //Float data type 
        public float floatData { get; set; } 
        //Integer data type
        public int integerData { get; set; }
        //Character data type
        public char charData { get; set; }
        //String data type
        public string stringData { get; set; } 
        //Double data type 
        public double doubleData { get; set; }
        //Decimal data type
        public decimal decimalData { get; set; }
        //Long data type 
        public long longData { get; set; }


        public int AddIntegers(int intA, int intB)
            //This is a simple function that adds two integers.
        {    
            //Return sum of integers
            return intA + intB;
        }
      
    }
}