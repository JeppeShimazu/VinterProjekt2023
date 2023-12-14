public class House
{
    public static int People;
    public string Type;
    public string Name;
    public static string Detection;
}

//Mansion
public class Mansion : House
{
    public Mansion()
    {
        Name = "Mansion";
    }
    public void MansionPeople()
    {
        int randomNumber = Random.Shared.Next(1, 12);
        People = randomNumber;
    }
}

//Villa
public class Villa : House
{
    public Villa()
    {
        Name = "Villa";
    }
    public void VillaPeople()
    {
        int randomNumber = Random.Shared.Next(1, 8);
        People = randomNumber;
    }
}

//Apartment
public class Apartment : House
{
    public Apartment()
    {
        Name = "Apartment";
    }
    public void ApartmentPeople()
    {
        int randomNumber = Random.Shared.Next(1, 5);
        People = randomNumber;
    }
}

//Cabin
public class Cabin : House
{
    public Cabin()
    {
        Name = "Cabin";
    }
    public void CabinPeople()
    {
        int randomNumber = Random.Shared.Next(1, 4);
        People = randomNumber;
    }
}