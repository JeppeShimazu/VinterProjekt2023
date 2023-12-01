using System;
public class Apartment : House
{
public Apartment()
{
Name = "Apartment";

Random random = new Random();
int randomNumber = random.Next(1, 5);
People = randomNumber;

}
}
