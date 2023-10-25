// See https://aka.ms/new-console-template for more information
using Demo_Heritage.Models;

Console.WriteLine("Demo 01");


Student st1 = new Student();

st1.Firstname = "Zaza";
st1.Lastname = "Vanderquack";
st1.Birthdate = new DateTime(1999, 01, 12);
st1.Sleep(7);

Teacher t1 = new Teacher();
t1.Firstname = "Balthazar";
t1.Lastname = "Picsou";

t1.SayHello(st1);
st1.SayHello(t1);
Console.WriteLine();

Console.WriteLine("Demo 02");
Person st2 = st1;
Person t2 = t1;

t2.SayHello(st2);
st2.SayHello(t2);

t2.Sleep(6);
st2.Sleep(9);


