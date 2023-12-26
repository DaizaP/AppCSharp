using AppCSharp.Seminar1;

internal class Program
{
    static void Main(string[] args)
    {
        FamilyMember grandfather0 = new() { mother = null, father = null, name = "Дедушка0 Иван", gender = Gender.Male };
        FamilyMember grandmother0 = new() { mother = null, father = null, name = "Бабушка0 Зина", gender = Gender.Female };
        
        FamilyMember father0 = new FamilyMember() { mother = grandmother0, father = grandfather0, name = "Папа0 Олег", gender = Gender.Male };
        FamilyMember father1 = new FamilyMember() { mother = grandmother0, father = grandfather0, name = "Папа1 Геннадий", gender = Gender.Male };
        FamilyMember father2 = new FamilyMember() { mother = grandmother0, father = grandfather0, name = "Папа2 Михаил", gender = Gender.Male };

        FamilyMember mother0 = new FamilyMember() { mother = null, father = null, name = "Мама0 Катя", gender = Gender.Female };
        FamilyMember mother1 = new FamilyMember() { father = null, mother = null, name = "Мама1 Света", gender = Gender.Female };

        FamilyMember son0 = new FamilyMember() { father = father0, mother = mother0, name = "Сын0 Олег", gender = Gender.Male };
        FamilyMember son1 = new FamilyMember() { father = father0, mother = mother1, name = "Сын1 Петр", gender = Gender.Male };
        FamilyMember son2 = new FamilyMember() { father = father0, mother = mother1, name = "Дочь2 Лида", gender = Gender.Female };

        grandfather0.children = new FamilyMember[] { father0, father1, father2 };

        grandmother0.children = new FamilyMember[] { father0, father1, father2 };

        mother1.children = new FamilyMember[] { son1, son2 };

        mother0.children = new FamilyMember[] { son0 };

        father0.children = new FamilyMember[] { son0, son1, son2 };


        father0.PrintHusbandOrWifeAndChildren();

    }
}