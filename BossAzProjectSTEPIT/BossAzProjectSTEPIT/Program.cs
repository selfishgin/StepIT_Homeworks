using System;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;

public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public CV WorkerCV { get; set; }

    public void Notify(string message)
    {
        Console.WriteLine($"Notification for Worker {Name}: {message}");
        Console.WriteLine($"Sending notification to {Name} via email: {message}");
    }

    public void SendCVByEmail(Employer employer)
    {
        string body = $"CV Information for {Name}:\n\n" +
                      $"Specialty: {WorkerCV.Specialty}\n" +
                      $"School Attended: {WorkerCV.SchoolAttended}\n" +
                      $"University Attended: {WorkerCV.UniversityAttended}\n" +
                      $"Skills: {string.Join(", ", WorkerCV.Skills)}\n" +
                      $"Companies: {string.Join(", ", WorkerCV.Companies)}\n" +
                      $"Start Date: {WorkerCV.StartDate}\n" +
                      $"End Date: {WorkerCV.EndDate}\n" +
                      $"Languages: {string.Join(", ", WorkerCV.Languages)}\n" +
                      $"Has Degree: {WorkerCV.HasDegree}\n" +
                      $"GitHub Link: {WorkerCV.GitHubLink}\n" +
                      $"LinkedIn Link: {WorkerCV.LinkedInLink}\n";

        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("moonshinenotsun@gmail.com");   // from email: moonshinenotsun@gmail.com 
            mail.To.Add(employer.Email);
            mail.Subject = $"CV Information for {Name}";
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential("iuseitfortestemail@gmail.com", "-A123456789");    // mail: iuseitfortestemail@gmail.com pass: -A123456789
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            Console.WriteLine("CV sent successfully to the employer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sending CV via email: " + ex.Message);
        }
    }
    public static int ReadPositiveIntegerInput(string prompt)
    {
        int value;
        while (true)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
    public static Worker GatherWorkerInformation()
    {
        Worker worker = new Worker();

        Console.WriteLine("Enter Worker ID:");
        worker.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Worker Name:");
        worker.Name = Console.ReadLine();

        Console.WriteLine("Enter Worker Surname:");
        worker.Surname = Console.ReadLine();

        Console.WriteLine("Enter Worker City:");
        worker.City = Console.ReadLine();

        Console.WriteLine("Enter Worker Phone:");
        worker.Phone = Console.ReadLine();

        worker.Age = ReadPositiveIntegerInput("Enter Worker Age:");

        // CV 
        worker.WorkerCV = new CV();
        Console.WriteLine("Enter Worker Specialty:");
        worker.WorkerCV.Specialty = Console.ReadLine();

        Console.WriteLine("Enter School Attended:");
        worker.WorkerCV.SchoolAttended = Console.ReadLine();

        Console.WriteLine("Enter University Attended:");
        worker.WorkerCV.UniversityAttended = Console.ReadLine();

        Console.WriteLine("Enter Skills (comma-separated):");
        worker.WorkerCV.Skills = Console.ReadLine().Split(',');

        Console.WriteLine("Enter Companies (comma-separated):");
        worker.WorkerCV.Companies = Console.ReadLine().Split(',');

        Console.WriteLine("Enter Start Date (yyyy-MM-dd):");
        worker.WorkerCV.StartDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter End Date (yyyy-MM-dd):");
        worker.WorkerCV.EndDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter Languages (comma-separated):");
        worker.WorkerCV.Languages = Console.ReadLine().Split(',');

        Console.WriteLine("Does the worker have a degree? (true/false):");
        worker.WorkerCV.HasDegree = bool.Parse(Console.ReadLine());

        Console.WriteLine("Enter GitHub Link:");
        worker.WorkerCV.GitHubLink = Console.ReadLine();

        Console.WriteLine("Enter LinkedIn Link:");
        worker.WorkerCV.LinkedInLink = Console.ReadLine();

        return worker;
    }
}

public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public int Vacancies { get; set; }
    public string Email { get; set; }

    public void Notify(string message)
    {
        Console.WriteLine($"Notification for Employer {Name}: {message}");
        Console.WriteLine($"Sending notification to {Name} via email: {message}");
    }
    public static int ReadPositiveIntegerInput(string prompt)
    {
        int value;
        while (true)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
    public static Employer GatherEmployerInformation()
    {
        Employer employer = new Employer();

        Console.WriteLine("Enter Employer ID:");
        employer.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employer Name:");
        employer.Name = Console.ReadLine();

        Console.WriteLine("Enter Employer Surname:");
        employer.Surname = Console.ReadLine();

        Console.WriteLine("Enter Employer City:");
        employer.City = Console.ReadLine();

        Console.WriteLine("Enter Employer Phone:");
        employer.Phone = Console.ReadLine();

        employer.Age = ReadPositiveIntegerInput("Enter Employer Age:");


        Console.WriteLine("Enter Number of Vacancies:");
        employer.Vacancies = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employer Email:");
        employer.Email = Console.ReadLine();

        return employer;
    }
}

public class CV
{
    public string Specialty { get; set; }
    public string SchoolAttended { get; set; }
    public string UniversityAttended { get; set; }
    public string[] Skills { get; set; }
    public string[] Companies { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string[] Languages { get; set; }
    public bool HasDegree { get; set; }
    public string GitHubLink { get; set; }
    public string LinkedInLink { get; set; }
}

public class DataManagement
{
    public static void SaveToJson(object data, string filePath)
    {
        string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }

    internal static T LoadFromJson<T>(string filePath)
    {
        try
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{filePath}' not found.");
            return default(T);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data from '{filePath}': {ex.Message}");
            return default(T);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string username = "user";
        string password = "pass";

        Console.WriteLine("Enter username:");
        string inputUsername = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string inputPassword = Console.ReadLine();

        if (inputUsername == username && inputPassword == password)
        {
            Console.WriteLine("Login successful.");

            Console.WriteLine("Are you a Worker or an Employer? (W/E)");
            string userType = Console.ReadLine().ToUpper();

            if (userType == "W")
            {
                Worker existingWorker = DataManagement.LoadFromJson<Worker>("worker.json");
                Worker workerInfo;
                if (existingWorker != null)
                {
                    Console.WriteLine("Do you want to update your existing information? (Y/N)");
                    string updateOption = Console.ReadLine().ToUpper();
                    if (updateOption == "Y")
                    {
                        workerInfo = Worker.GatherWorkerInformation();
                    }
                    else
                    {
                        workerInfo = existingWorker;
                    }
                }
                else
                {
                    workerInfo = Worker.GatherWorkerInformation();
                }

                DataManagement.SaveToJson(workerInfo, "worker.json");
                workerInfo.Notify("Worker information has been saved.");

                Console.WriteLine("Do you want to send your CV to an Employer? (Y/N)");
                string sendCVOption = Console.ReadLine().ToUpper();
                if (sendCVOption == "Y")
                {
                    Employer employer = Employer.GatherEmployerInformation();
                    workerInfo.SendCVByEmail(employer);
                }
            }
            else if (userType == "E")
            {
                Employer existingEmployer = DataManagement.LoadFromJson<Employer>("employer.json");
                Employer employerInfo;
                if (existingEmployer != null)
                {
                    Console.WriteLine("Do you want to update your existing information? (Y/N)");
                    string updateOption = Console.ReadLine().ToUpper();
                    if (updateOption == "Y")
                    {
                        employerInfo = Employer.GatherEmployerInformation();
                    }
                    else
                    {
                        employerInfo = existingEmployer;
                    }
                }
                else
                {
                    employerInfo = Employer.GatherEmployerInformation();
                }

                DataManagement.SaveToJson(employerInfo, "employer.json");
                employerInfo.Notify("Employer information has been saved.");
            }
            else
            {
                Console.WriteLine("Invalid user type.");
            }
        }
        else
        {
            Console.WriteLine("Invalid username or password. Login failed.");
        }
    }
}
