using Hospital__registration;
using System.Net.Http.Headers;

void Users()
{
    Users user = new Users();
    Console.Write("Users Name:");
    user.Name = Console.ReadLine();
    Console.Write("User Email:");
    user.Email = Console.ReadLine();
    Console.Write("Users Phone");
    user.Phone = Console.ReadLine();
    string userInfo = $"Ad: {user.Name},\n E-posta: {user.Email},\n Telefon: {user.Phone}\n";
    using (StreamWriter writer = File.AppendText("demo.txt"))
    {
        writer.WriteLine(userInfo);
        Console.WriteLine();
    }
}
Branch branchs1 = new Branch("Pediatriya");
Branch branchs2 = new Branch("Travmatologiya");
Branch branchs3 = new Branch("Stamatologiya");
//Pediatriya
Doctors doctors1 = new Doctors("Eli", "Eliyev", branchs1, 2);
Doctors doctors2 = new Doctors("Veli", "Eliyev", branchs1, 3);
Doctors doctors3 = new Doctors("Mehman", "Ehmedli", branchs1, 4);
//Travmatologiya
Doctors doctors4 = new Doctors("Eflatun", "Qubadov", branchs2, 2);
Doctors doctors5 = new Doctors("Nihad", "Amirov", branchs2, 3);
Doctors doctors6 = new Doctors("Elnur", "Memmmedov", branchs2, 4);
//Stamatologiya
Doctors doctors7 = new Doctors("Nizami", "Emirov", branchs3, 2);
Doctors doctors8 = new Doctors("Revan", "Agazade", branchs3, 3);
Doctors doctors9 = new Doctors("Aqsin", "Ehmedli", branchs3, 7);
//Date
Date dates1 = new Date("01", "06", "2024", "09", "00");
Date dates2 = new Date("02", "06", "2024", "12", "00");
Date dates3 = new Date("03", "06", "2024", "15 ", "00");
List<Date> dates = new List<Date>()
{
    dates1, dates2, dates3
};
List<Doctors> doctors = new List<Doctors>
{
    doctors1, doctors2, doctors3, doctors4, doctors5,doctors6, doctors7, doctors8, doctors9

};

void choiceDoctorForPediatriya()
{
    Console.Write("Qebuluna dusmek istediyiniz hekimi qeyd edin:");
    Console.WriteLine();
    string choice1 = Console.ReadLine();
    if (int.TryParse(choice1, out int choice))
    {
        if (choice == 1)
        {
            Console.WriteLine($"Siz {doctors1} - i secdiniz");
            string doctor1 = $"Doctor\n: {doctors1}";
            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor1);
            }

        }
        else if (choice == 2)
        {
            Console.WriteLine($"Siz {doctors2} - i secdiniz");
            string doctor2 = $"Doctor\n: {doctors2}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor2);
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine($"Siz {doctors3} - u secdiniz");
            string doctor3 = $"Doctor\n: {doctors3}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor3);
            }
        }

    }
}

void choiceForTravmatologiya()
{
    Console.Write("Qebuluna dusmek istediyiniz hekimi qeyd edin:");
    string choice2 = Console.ReadLine();
    if (int.TryParse(choice2, out int choice))
    {
        if (choice == 1)
        {
            Console.WriteLine($"Siz {doctors4} - i secdiniz");
            string doctor4 = $"Doctor\n: {doctors4}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor4);
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine($"Siz {doctors5} - i secdiniz");
            string doctor5 = $"Doctor\n: {doctors5}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor5);
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine($"Siz {doctors6} - u secdiniz");
            string doctor6 = $"Doctor\n: {doctors6}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor6);
            }
        }
        else
        {
            throw new WrongDoctor();

        }
    }
}

void choiceForStamatologiya()
{
    Console.Write("Qebuluna dusmek istediyiniz hekimi qeyd edin:");
    string choice3 = Console.ReadLine();
    if (int.TryParse(choice3, out int choice))
    {

        if (choice == 1)
        {
            Console.WriteLine($"Siz {doctors7} - i secdiniz");
            string doctor7 = $"Doctor\n: {doctors7}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor7);
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine($"Siz {doctors8} - i secdiniz");
            string doctor8 = $"Doctor\n: {doctors8}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor8);
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine($"Siz {doctors9} - u secdiniz");
            string doctor9 = $"Doctor\n: {doctors9}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(doctor9);
            }
        }
        else
        {
            throw new WrongDoctor();
        }
    }
}
int count1 = 0;
int count2 = 0;
int count3 = 0;
void choiceDate()
{
    Console.Write("Zehmet olmasa Vaxti qeyd edin:");
    string choiceDate = Console.ReadLine();


    if (int.TryParse(choiceDate, out int choice))
    {
        if (choice == 1)
        {
            if (count1 == 1)
            {
                throw new ReservException();
            }
        }
        else
        {
            Console.WriteLine($"Siz {dates1} - tarixinde hekimin qebulunda ola bilersiniz");

            count1++;
            string date1 = $"Doctor\n: {dates1}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(date1);
            }
        }
    }
    else if (choice == 2)
    {
        if (count2 == 1)
        {
            throw new ReservException();

        }
        else
        {
            Console.WriteLine($"Siz {dates1} - tarixinde hekimin qebulunda ola bilersiniz");
            string date2 = $"Doctor\n: {dates1}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(date2);
            }
            count2++;
        }

    }
    else if (choice == 3)
    {
        if (count3 == 1)
        {
            throw new ReservException();
        }
        else
        {
            Console.WriteLine($"Siz {dates1} - tarixinde hekimin qebulunda ola bilersiniz");
            count3++;
            string date3 = $"Doctor\n: {dates1}";

            using (StreamWriter writer = File.AppendText("demo.txt"))
            {
                writer.WriteLine(date3);
            }
        }

    }

}

void Choice(Branch branchs1, Branch branchs2, Branch branchs3)
{
    Console.WriteLine("Select 1 for Pediatrics:");
    Console.WriteLine("Select 2 for Travmatology:");
    Console.WriteLine("Select 3 for Stomatology:");
    Console.Write("Choice: ");
    string choiceInput = Console.ReadLine();
    string choice1 = $"Doctor\n: {choiceInput}";


    if (int.TryParse(choiceInput, out int choice))
    {
        if (choice == 1)
        {
            Console.WriteLine($"Siz {branchs1} - i secdiniz");
            Console.WriteLine("Bu Sobedeki Hekimler:");
            for (int i = 0; i < 3; i++)
            {
                var doctor = doctors[i];
                Console.WriteLine($"Doctors: {doctor.Name} {doctor.Surname},{doctor.BranchName},Experience:{doctor.experience}");
            }
            choiceDoctorForPediatriya();
            Console.WriteLine();
            Console.WriteLine("Hekimin qeydiyyat vaxtlari:");
            Console.WriteLine();
            foreach (var date in dates)
            {
                Console.WriteLine($"Date: {date.ToString()}");
            }
            Console.WriteLine();
            choiceDate();


        }
        else if (choice == 2)
        {
            Console.WriteLine($"Siz {branchs2} - i secdiniz");
            Console.WriteLine("Bu Sobedeki Hekimler:");
            for (int i = 3; i < 6; i++)
            {
                var doctor = doctors[i];
                Console.WriteLine($"Doctor: {doctor.Name} {doctor.Surname},{doctor.BranchName},Experience:{doctor.experience}");
            }
            choiceForTravmatologiya();
            Console.WriteLine("Hekimin qeydiyyat vaxtlari:");
            foreach (var date in dates)
            {
                Console.WriteLine($"Date: {date.ToString()}");
            }
            Console.WriteLine();
            choiceDate();
        }

        else if (choice == 3)
        {
            Console.WriteLine($"Siz {branchs3} - i secdiniz");
            Console.WriteLine("Bu Sobedeki Hekimler:");
            for (int i = 6; i < 9; i++)
            {
                var doctor = doctors[i];
                Console.WriteLine($"Doctors: {doctor.Name} {doctor.Surname},{doctor.BranchName},Experience:{doctor.experience}");
            }
            Console.WriteLine();
            choiceForStamatologiya();
            Console.WriteLine("Hekimin qeydiyyat vaxtlari:");
            foreach (var date in dates)
            {
                Console.WriteLine($"Date: {date.ToString()}");
            }
            choiceDate();
        }
        else
        {
            throw new WrongBranch();
        }

    }

}
while (true)
{
    Console.WriteLine("Klinikamiza xos gelmisiniz!");
    Console.WriteLine();
    Console.WriteLine("Zehmet olmasa sexsi melumatlarinizi doldurun!");
    Console.WriteLine();
    Users();
    Console.WriteLine();
    Choice(branchs1, branchs2, branchs3);
    Console.WriteLine();


}


