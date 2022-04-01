namespace Day08Training;
public class Menu
{
    Author author = new Author();
    Publisher publisher = new Publisher();
    Book book = new Book();




    public static void Test()
    {
        Author author = new Author();
        //author.AddAuthor("Vishal Bhingardive", 11, "my New Author");
        //author.AddAuthor("Stephin James", 26, "my Friend");
        //author.AddAuthor("Adil Sayyad", 47, "My Friend");


        Publisher publisher = new Publisher();
        Menu menu = new Menu();


        int Choice = 0;



        do
        {
            Console.WriteLine("1.Author");

            Console.WriteLine("2.Publisher");

            Console.WriteLine("3.Customer");
            Console.WriteLine("4.Books");
            Console.WriteLine("5.Transaction");



            Console.WriteLine("0.Exit");
            Console.WriteLine("Enter Your Choice: ");

            Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:

                    menu.MenuAuthor();


                    break;

                case 2:

                    menu.MenuPublisher();
                    break;

                case 3:
                    menu.MenuBook();
                    break;
                case 4:
                  
                    break;
                case 5:
                    publisher.AddPublisher();
                    break;

                default:
                    if (Choice == 0)
                    {


                        Console.WriteLine("Exiting.....");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entered Choice is Invalid");
                        break;
                    }
            }

        }
        while (Choice != 0);
    }


    public void MenuAuthor()
    {

        int Choice = 0;



        do
        {
            Console.WriteLine("1.Add Author");

            Console.WriteLine("2.Save Author");

            Console.WriteLine("3.DisplayAuthor");
            Console.WriteLine("4.UpdateAuthor");
            Console.WriteLine("5.Delete Author");

            Console.WriteLine("0.Exit");
            Console.WriteLine("Enter Your Choice: ");

            Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    author.AddAuthor();
                    break;

                case 2:
                    author.Save();

                    break;

                case 3:
                    author.Display();

                    break;
                case 4:
                    author.UpdateAuthor();

                    break;
                case 5:
                    author.Delete();
                    break;

                default:
                    if (Choice == 0)
                    {


                        Console.WriteLine("===============================");
                        Console.WriteLine("Back To Main Menu..............");
                        Console.WriteLine("===============================");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entered Choice is Invalid......");
                        Console.WriteLine("===============================");
                        break;
                    }
            }

        }
        while (Choice != 0);
    }


    public void MenuPublisher()
    {
        int Choice = 0;



        do
        {
            Console.WriteLine("1.Add Publisher");

            Console.WriteLine("2.Save Publisher");

            Console.WriteLine("3.DisplayPublisher");
            Console.WriteLine("4.UpdatePublisher");
            Console.WriteLine("5.DeletePublisher");


            Console.WriteLine("0.Exit");
            Console.WriteLine("Enter Your Choice: ");

            Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    publisher.AddPublisher();
                    break;

                case 2:
                    publisher.Save();

                    break;

                case 3:
                    publisher.Display();

                    break;
                case 4:

                    publisher.UpdatePublisher();
                    break;
                case 5:
                    publisher.Delete();
                    break;

                default:
                    if (Choice == 0)
                    {


                        Console.WriteLine("===============================");
                        Console.WriteLine("Back To Main Menu..............");
                        Console.WriteLine("===============================");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entered Choice is Invalid......");
                        Console.WriteLine("===============================");
                        break;
                    }
            }

        }
        while (Choice != 0);
    }


    public void MenuBook()
    {
        int Choice = 0;



        do
        {
            Console.WriteLine("1.Add Book");

            Console.WriteLine("2.Save ");

            Console.WriteLine("3.DisplayBook");
            Console.WriteLine("4.UpdateBook");
            Console.WriteLine("5.DeleteBook");


            Console.WriteLine("0.Exit");
            Console.WriteLine("Enter Your Choice: ");

            Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                   book.AddBook();
                    break;

                case 2:
                    book.Save();

                    break;

                case 3:
                    book.Display();

                    break;
                case 4:

                    book.UpdateBook();
                    break;
                case 5:
                    book.Delete();
                    break;

                default:
                    if (Choice == 0)
                    {

                        Console.WriteLine("===============================");
                        Console.WriteLine("Back To Main Menu..............");
                        Console.WriteLine("===============================");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entered Choice is Invalid......");
                        Console.WriteLine("===============================");
                        break;
                    }
            }

        }
        while (Choice != 0);
    }

}