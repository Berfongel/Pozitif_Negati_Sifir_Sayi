// See https://aka.ms/new-console-template for more information
int sayi;
Console.WriteLine("Lütfen bir sayı giriniz");
sayi = Convert.ToInt32(Console.ReadLine());
//girilen sayı 0 dan büyükse pozitif değilse negatif.
if (sayi>0)
{
    Console.WriteLine("Girdiğiniz sayı pozitif bir sayıdır.");
}
else if(sayi==0)
{
    Console.WriteLine("Girdiğiniz sayı ne negatif ne pozitiftir.");
}
else 
{
    Console.WriteLine("Girdiğiniz sayı negatif bir sayıdır.");
}
    