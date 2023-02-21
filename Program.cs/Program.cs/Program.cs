int age = 17;
string name = "Ewa";
string sex = "Female";

if (age > 0)
{
    if (age < 18)
    {
        if (sex == "Female" || sex == "female")
        {
            if (name == "Ewa" || name == "ewa")
            {
                Console.WriteLine("Ewa poniżej 18 lat");
            }
            else
            {
                Console.WriteLine("Jakaś inna kobieta niebędąca Ewą poniżej 18 lat");
            }

        }
        else if (sex == "Male" || sex == "male")
        {
            if (name == "Jakub" || name == "jakub")
            {
                Console.WriteLine("Jakub poniżej 18 lat");
            }
            else
            {
                Console.WriteLine("Jakiś inny mężczyzna niebędący Jakubem poniżej 18 lat");
            }
        }
        else
        {
            Console.WriteLine("Czy jesteś osobą niebinarną?");
        }
    }
    else if (age >= 18 && age < 150)
    {
        if (sex == "Female" || sex == "female")
        {
            if (name == "Ewa" || name == "ewa")
            {
                Console.WriteLine("Ewa pomiędzy 18 a 150 rokiem życia");
            }
            else
            {
                Console.WriteLine("Inna kobieta niebędąca Ewą pomiędz 18 a 150 rokiem życia");

            }
        }
        else if (sex == "Male" || sex == "male")
        {
            if (name == "Jakub" || name == "Jakub")
            {
                Console.WriteLine("Jakub pomiędzy 18 a 150 rokiem życia");
            }
            else
            {
                Console.WriteLine("Inny mężczyzna pomiędzy 18 a 150 rokiem życia");

            }
        }
        else
        {
            Console.WriteLine("Czy jesteś osobą niebinarną");
        }
        
            
        
        
    }
    else
    {
        Console.WriteLine("Czy jesteś starożytnym mnichem czy wampirem");
    }
}
else
{
    Console.WriteLine("Przykro mi, ale prawdopodobnie nie istniejesz albo dopiero się rodzisz");
}
