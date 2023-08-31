using static TimeApp.TimeClass;

Time t1, t2;
t1 = new Time("08:30:00");
t2 = t1;
t2.Hour = t2.Hour + 2;
Console.WriteLine(t1.ToString());
Console.WriteLine(t2.ToString());