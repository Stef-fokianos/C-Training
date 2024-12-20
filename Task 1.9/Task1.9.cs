using System;

// Άσκηση 1.9
// Δημιουργήστε μια κλάση με όνομα “Book”. Προσθέστε μια μέθοδο στη κλάση, η οποία θα λέγεται “GetPageCount” χωρίς παραμέτρους.
//  Η μέθοδος αυτή στην Book θα επιστρέφει έναν ακέραιο αριθμό “1”. Φτιάξτε άλλες 2 κλάσεις που να κληρονομούν από την Book,
//   και ονομάστε τις με κάποιον τίτλο βιβλίου. Η κάθε κλάση που κληρονομεί από την Book,
//    θα πρέπει να επιστρέφει διαφορετικό αριθμό σελίδων, προσθέτοντας επίσης το αποτέλεσμα από την “GetPageCount” της βάσης.

public class Book
{
    public int PageCount = 1;

    public int GetPageCount()
    {
        return PageCount;
    }
}

public class BookA : Book
{
    public virtual int GetPageCount()
    {
        PageCount = base.GetPageCount() + 100;
        return PageCount;
    }
}

public class BookB : Book
{
    public virtual int GetPageCount()
    {
        PageCount = base.GetPageCount() + 200;
        return PageCount;
    }
}



class Task1_9
    {
    static void Main (string[] args)
        {
        Book book = new Book();
        BookA bookA = new BookA();
        BookB bookB = new BookB();        

        Console.WriteLine($"Book pages : {book.GetPageCount()}");
        Console.WriteLine($"Book A pages : {bookA.GetPageCount()}");
        Console.WriteLine($"Book B pages : {bookB.GetPageCount()}");
    }
    }