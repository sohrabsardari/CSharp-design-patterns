// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public interface ILaptopBuilder
{
    void StartUpOperations();
    void WithI7Cpu();
    void WithI5Cpu();
    void With16GigaByteRam();
    void With32GigaByteRam();
    void With4KScreen();
    void WithFullHdScreen();
    Laptop GetLaptop();
}

public class Laptop
{
}