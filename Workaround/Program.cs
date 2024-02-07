// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
Topla(1, 3);
static int Topla(int sayi1, int sayi2)
{
    int result = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + result);
    return result;
    
}
Person person = new Person();
person.NationalIdentity = 123;
person.FirstName = "Oğuzhan";
person.LastName = "Dilek";
person.DateOfBirthYear = 1992;


PttManager pttManager=new PttManager(new PersonManager());
pttManager.GiveMask(person);
Console.ReadLine();