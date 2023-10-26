using System;

class Program
{
    Dvd dvd1 = new Dvd("Cars");
    dvd1.CheckOut();
    dvd1.Display();

    Book findingNemo = new Book("Finding Nemo, 978-1000000302",10000002);

    findingNemo.Display();
}
