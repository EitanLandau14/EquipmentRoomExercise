using System;

// <summary>
//Todo: צרו מחלקת חריגים המטפלת במקרים בהם אין מספיק מחשבים זמינים להשאלה.
//שם המחלקה צריך להיות EquipmentUnavailableException.


class EquipmentUnavailableException : Exception
{
    public int WantBorrow { get; }
    public int Differnce { get; }
    public EquipmentUnavailableException(int availableComputers,int Wantborrow):base("Not enough equipment available")
    {
        Wantborrow = Wantborrow;
        Differnce = availableComputers - Wantborrow;
    }
}
class EquipmentRoom
{
    private int availableComputers;

    public int AvailableComputers
    {
        get
        {
            return availableComputers;
        }
        set
        {
            // TODO: יש לבדוק שמספר המחשבים אינו שלילי.
            // אם כן, יש לזרוק חריגה מתאימה.
            availableComputers = value;
        }
    }

    public EquipmentRoom(int amount)
    {
        AvailableComputers = amount;
    }

    public void Borrow(int amount)
    {

        // TODO: יש לזרוק חריגה מתאימה כאשר אין מספיק מחשבים זמינים.
        if (amount > AvailableComputers)
        {
            throw new EquipmentUnavailableException(amount, AvailableComputers);
        }
     

        AvailableComputers -= amount;
        Console.WriteLine($"הושאלו {amount} מחשבים בהצלחה.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int initialComputers = 10;

        EquipmentRoom room = new EquipmentRoom(initialComputers);

        // יצירת חדר מחשבים עם מספר מחשבים שלילי:
        // לאחר מימוש הבדיקה ב-set, יש לוודא שמצב כזה מטופל כראוי.
        // TODO: יש להוסיף try-catch מתאימים סביב הקריאות שעלולות לזרוק חריגה.
        int negativeComputers = -5;
        EquipmentRoom invalidRoom = new EquipmentRoom(negativeComputers);


        room.Borrow(4);
        Console.WriteLine("ממשיכים בתוכנית...");

        room.Borrow(8);

        Console.WriteLine("מספר המחשבים הזמינים: " + room.AvailableComputers);
    }
}
int initialComputers = 10;
int initialComputers = 10;

EquipmentRoom room = new EquipmentRoom(initialComputers);

// יצירת חדר מחשבים עם מספר מחשבים שלילי:
// לאחר מימוש הבדיקה ב-set, יש לוודא שמצב כזה מטופל כראוי.
// TODO: יש להוסיף try-catch מתאימים סביב הקריאות שעלולות לזרוק חריגה.
int negativeComputers = -5;
EquipmentRoom invalidRoom = new EquipmentRoom(negativeComputers);


room.Borrow(4);
Console.WriteLine("ממשיכים בתוכנית...");
try
{
    room.Borrow(8);
}
catch (EquipmentUnavailableException ex)
{
    Comsole.WriteLine(ex.Message);
}
Console.WriteLine("מספר המחשבים הזמינים: " + room.AvailableComputers);
}
}