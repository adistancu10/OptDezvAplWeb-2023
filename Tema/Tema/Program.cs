using Tema;

List<Student> studenti = new List<Student>();

Student student1 = new Student("Stancu", "Adrian", "20", "5325235235");
student1.AdaugareMaterie("Informatica", "3 ore");
student1.AdaugareMaterie("Matematica", "2 ore");
student1.AdaugareMaterie("Programare Functionala", "2 ore");



Student student2 = new Student("Iulian", "Bordei", "19", "5325253252");
student2.AdaugareMaterie("SGDB", "2 ore");
student2.AdaugareMaterie("Informatica", "3 ore");
student2.AdaugareMaterie("Probabilitate si Statistica", "2 ore");


studenti.Add(student1);
studenti.Add(student2);

foreach(Student student in studenti)
{
    Console.WriteLine($"Nume: {student.Nume} , Prenume : {student.Prenume}, Varsta : {student.Varsta} , CNP : {student.CNP}");
    Console.WriteLine("Materii: ");
    foreach (Materie materie in student.Materii)
    {
        Console.WriteLine($"{materie.Titlu} - {materie.Durata} ");
    }
    Console.WriteLine();
}

