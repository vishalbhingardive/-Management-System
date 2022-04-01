namespace Day08Training;

public class Book 
{
    string ISBIN;
    string Title;
    int PublisherId;
    int AuthorId;
    bool IssueStatus;
    bool IsDeleted;
    private const string Heading = "AuthorID,AuthorName,Notes\n";
    private const string FilePath = @"C:\Users\VishalBhingardive\Desktop\LibraryData\Books.csv";

    List<Book> bookInfos = new List<Book>();

    public Book()
    {

    }
    public Book(string isbin,string title,int publisherId,int authorId,bool issueStatus,bool isDeleted)
    {
        ISBIN = isbin;
        Title = title;
        PublisherId = publisherId;
        AuthorId = authorId;
        IssueStatus = issueStatus;
        IsDeleted = isDeleted;
    }



    public void AddBook()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Add New Book");

        Console.WriteLine("----------------");
        Console.WriteLine("Enter Title");
        Title = Console.ReadLine();

        Console.Write("Enter PublisherId : ");
        PublisherId = int.Parse(Console.ReadLine());

        Console.Write("Enter Notes ");
        AuthorId = int.Parse(Console.ReadLine());

       
        Book BookInfo = new Book(ISBIN,Title,PublisherId,AuthorId,IssueStatus,IsDeleted);
        bookInfos.Add(BookInfo);



    }
    public void Save()
    {
        var data = $"{ISBIN},{Title},{PublisherId},{AuthorId}\n";

        if (!File.Exists(FilePath))
            File.WriteAllText(FilePath, Heading);

        try
        {
            File.AppendAllText(FilePath, data);
            Console.WriteLine($"File successfully saved at {FilePath}");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error Saving File. {exception.Message}");
        }

    }


    internal void AddBook(string isbin, string title, int publisherId,int authorId,bool issueStatus, bool isDeleted )
    {

        Console.WriteLine("--------------------------------Student----------------------------\n");
        Console.WriteLine("|-------------------------|-------------------------|-------------|");
        Console.WriteLine($"|        AuthorID           |  Name                   | Notes |");
        Console.WriteLine("|-------------------------|-------------------------|-------------|");
        Console.WriteLine($"|{isbin,10}               |  {title,-25}|  {publisherId,10}  |{authorId,10}|");
        Console.WriteLine("|-------------------------|-------------------------|-------------|");
        Console.WriteLine("                                                                   ");
       


        Book BookInfo = new Book(isbin, title, publisherId,authorId,issueStatus,isDeleted);
        bookInfos.Add(BookInfo);
    }


    public void UpdateBook()
    {
        Console.Write("Enter Author Id to Update: ");
        string idToDeleteText = Console.ReadLine();
        string idToDelete = idToDeleteText;

        // did not make this toList because it is not required in Update
        string[] fileDataList = File.ReadAllLines(FilePath);

        for (int i = 1; i < fileDataList.Length; i++)
        {
            var csvLine = fileDataList[i];

            var book = new Book(csvLine);

            if (book.ISBIN == idToDelete)
            {
                bool confirmed = GetConfirmation(book, "update");

                if (confirmed)
                {
                    var editedBook = GenerateNewBook(book.ISBIN);

                    fileDataList[i] = editedBook.ToCsv;

                    File.WriteAllLines(FilePath, fileDataList);

                    ConsoleHelper.ShowSuccessMessage("Record successfully updated!");
                }
                else
                    ConsoleHelper.ShowWarningMessage("Update aborted......");

                break;
            }
        }
    }

    public void Delete()
    {
        Console.Write("Enter Author Id to Delete: ");
        string idToDeleteText = Console.ReadLine();
        string idToDelete = idToDeleteText;

        // Made this tolist because we need RemoveAt which is only available in List not in array            
        List<string> fileDataList = File.ReadAllLines(FilePath).ToList();

        for (int i = 1; i < fileDataList.Count; i++)
        {
            var csvLine = fileDataList[i];

            var book = new Book(csvLine);

            if (book.ISBIN == idToDelete)
            {
                bool confirmed = GetConfirmation(book, "delete");

                if (confirmed)
                {
                    fileDataList.RemoveAt(i);
                    File.WriteAllLines(FilePath, fileDataList);
                    ConsoleHelper.ShowSuccessMessage("Record successfully deleted!");
                }
                else
                    ConsoleHelper.ShowWarningMessage("Deleting aborted......");

                break;
            }
        }
    }


    private static bool GetConfirmation(Book book, string action)
    {
        Console.WriteLine("Book found");



        Console.WriteLine(book.FormattedData);



        Console.Write($"Are you sure you want to {action} [y/n]: ");
        var confirmKey = Console.ReadKey();

        Console.WriteLine();
        return confirmKey.Key == ConsoleKey.Y;
    }
    private static Book GenerateNewBook(string isbin = null)
    {
        var book = new Book();

        if (isbin != null)
            book.ISBIN= isbin;
        else
        {
            Console.Write("Enter Book Id: ");
            string idText = Console.ReadLine();
            book.ISBIN = idText;
        }

        Console.Write("Enter Book Title");
        book.Title = Console.ReadLine();

        Console.Write("Enter Publisher Id: ");
        book.PublisherId = int.Parse(Console.ReadLine());

        Console.Write("Enter Author Id: ");
        book.AuthorId = int.Parse(Console.ReadLine());
        return book;
    }

    public static string FormattedHeading
    {
        get
        {
            var headerArray = Heading.Split(',');
            return $"{headerArray[0],-10}{headerArray[1],-50}{headerArray[2],-10}{headerArray[3],-20}";
        }
    }

    public string FormattedData => $"{ISBIN,-10}{Title,-50}{PublisherId,-10}{AuthorId,-20}";

    public string ToCsv => $"{ISBIN},{Title},{PublisherId}{AuthorId}";





    public Book(string csvLine)
    {
        var dataArray = csvLine.Split(',');

        ISBIN = dataArray[0];
        Title = dataArray[1];
        PublisherId = int.Parse(dataArray[2]);
        AuthorId = int.Parse(dataArray[3]);
       
    }

    public void Display()
    {
        string[] rows;
        string[] cols;
        string Path = FilePath;

        int index = 0;
        rows = File.ReadAllLines(Path);

        Console.WriteLine("=============Author==============");
        while (index < rows.Length)
        {
            cols = rows[index].Split(',');

            Console.WriteLine("\n " + cols[0] + " " + cols[1] + " " + cols[2] + cols[3]+"\n");
            Console.WriteLine("==============================");

            index++;
        }
    }
}




