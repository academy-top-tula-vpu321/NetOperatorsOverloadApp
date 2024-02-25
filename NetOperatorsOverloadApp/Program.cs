using NetOperatorsOverloadApp;

Money money1 = new Money(5, 20);
//Console.WriteLine(money1);

//Money money2 = new Money(2, 90);

//money1 += money2;
//Console.WriteLine(money1);

//int number = (int)money1;

Student bob = new Student()
{
    Name = "Bob",
    Email = "bob@gmail.com",
    Phone = "999 123-45-67"
};

Student joe = new Student()
{
    Name = "Joe",
    Email = "joe@yandex.ru",
    Phone = "900 555-45-45"
};

Student tom = new Student()
{
    Name = "Tom",
    Email = "tommy@mail.ru",
    Phone = "953 111-22-33"
};

Group group = new();
group[0] = bob;
group[1] = joe;
group[2] = tom;

for(int i = 0; i < group.Size; i++)
    Console.WriteLine(group[i]);


Student leo = new();
leo["name"] = "Leo"; //leo.Name = "Leo";
leo["email"] = "leopold@yandex.ru";
leo["phone"] = "955 590-23-32";

Console.WriteLine(leo);
