using System;

namespace Library02
{
    class Program
    {
        static void Main(string[] args)
        {
            string AuthorsMenu = "";
            string Comeback = "";
            string ComeGenre = "";
            Console.Write("Hi No-name, enter your name please: ");
            string name = Console.ReadLine();

            Console.WriteLine("I'm your library {0}", name);
            do
            {
                Console.WriteLine("1. Books by genre");  //knihy podle žánru
                Console.WriteLine("2. Books by Authors");  //knihy podle autora
                Console.WriteLine("3. Books in read process"); //rozectene knihy
                Console.WriteLine("4. UnRead Books");     //neprectene knihy
                Console.WriteLine("5. Read(ed) books");   //prectene knihy
                Console.WriteLine("6. Missing books in bundle");  //chybejici knihy ve svazku
                Console.Write("Choose between 1-6 options.\nEnter a number of your way: ");
                int MainMenu = Int32.Parse(Console.ReadLine());

                do
                {
                    ComeGenre = "none";
                    Comeback = "none";
                    if (MainMenu == 1)
                    {  //books by genre
                        Console.WriteLine("1. Prose");  //Próza
                        Console.WriteLine("2. Poetry");   //poezie
                        Console.WriteLine("3. Drama");   //Drama
                        Console.WriteLine("4. Comics"); //komiksy
                        Console.WriteLine("5. Fables and Myths"); //BájeAmyty 
                        Console.WriteLine("6. Girls novels");  //Divci romany
                        Console.WriteLine("7. Fantasy");  //Fantasy
                        Console.WriteLine("8. Sci-Fi");  //Sci-fi
                        Console.WriteLine("9. Horror");  //Horory 
                        Console.WriteLine("10. Detective stories");
                        Console.WriteLine("11. Humor and satire");
                        Console.WriteLine("12. Back to Main menu"); //Zpět
                        Console.Write("Choose your way with number 1-12: ");
                        int genre = Int32.Parse(Console.ReadLine());

                        if (genre == 1)
                        {
                            Console.WriteLine("***PROSE***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. Blood Meridian *** Cormac McCarthy *** 337 pages *** Novel, Western, Western fiction, Historical Fiction, historical novel ");
                            Console.WriteLine("2. Invisible Man *** Ralph Ellison *** 581 pages *** Novel, Fiction, Bildungsroman ");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();

                        }
                        else if (genre == 2)
                        {
                            Console.WriteLine("***POETRY***\nBook name *** Author *** Length *** Genre");
                            Console.WriteLine("1. Beowulf *** William Shakespeare *** 3182 lines *** Epic heroic writing ");
                            Console.WriteLine("2. The Tyger *** Willian Blake *** Not specified *** Poetry");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 3)
                        {
                            Console.WriteLine("***DRAMA***\nBook name *** Author *** Length *** Genre");
                            Console.WriteLine("1. Hamlet *** Willien Shakespeare *** 29 551 words *** Tragedy, Drama");
                            Console.WriteLine("2. Romeo and Juliet *** William Shakespeare *** Long *** Tragedy");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 4)
                        {
                            Console.WriteLine("***COMICS***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. Rick and Morty Volume 1 *** Zac Gorman *** 32 pages *** Comics, Graphic novel");
                            Console.WriteLine("2. Rick and Morty Book One: Deluxe Edition *** Zac Gorman *** 34 pages *** Comics, Graphic novel");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 5)
                        {
                            Console.WriteLine("***FAMLES AND MYTHS***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. Star Wars Myths & Fables *** George Mann *** I dont know(your librabry) *** Fiction ");
                            Console.WriteLine("2. Usborne Illustrated Guide to Norse Myths and Legends *** Rodney Matthews *** Too many stories *** Legend");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 6)
                        {
                            Console.WriteLine("***GIRLS NOVELS***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. Anne of Green Gables *** Lucy Maud Montgomery *** 261 pages *** Novel, Children's literature, Fiction, Bildungsroman ");
                            Console.WriteLine("2. Madeline *** Ludwig Bemelmans *** 44 pages *** Children's literature, Fiction");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 7)
                        {
                            Console.WriteLine("***FANTASY***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. A Game of Thrones *** George R. R. Martin *** 694 pages *** Novel, Fantasy Fiction, High fantasy, Political fiction ");
                            Console.WriteLine("2. The Hobbit, or There and Back Again *** J. R. R. Tolkien *** 310 pages *** Novel, Children's literature, Fantasy Fiction, High fantasy, Epic ");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 8)
                        {
                            Console.WriteLine("***SCI-FI***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. Dune *** Frank Herbert *** 500 pages *** Novel, Science fiction, Fantasy Fiction, Adventure fiction ");
                            Console.WriteLine("2. The Martian *** Andy Weir *** 369 pages *** Science fiction, Novel ");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 9)
                        {
                            Console.WriteLine("***HORROR***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. It *** Stephen King *** 1 138 pages *** Novel, Horror fiction, Thriller, Dark fantasy");
                            Console.WriteLine("2. The Stand *** Stephen King *** 823 pages *** Novel, Horror fiction, Science fiction, Apocalyptic and post-apocalyptic fiction, Fantasy Fiction, Fantastique");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 10)
                        {
                            Console.WriteLine("***DETECTIVE***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. The Hound of the Baskervilles *** Arthur Conan Doyle *** 254 pages *** Novel, Mystery, Detective novel, Crime Fiction ");
                            Console.WriteLine("2. The Murders in the Rue Morgue *** Edgar Allan Poe *** Missing pages *** Mystery, Detective novel, Crime Fiction");
                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 11)
                        {
                            Console.WriteLine("***HUMOR AND SATIRE***\nBook name *** Author *** Pages *** Genre");
                            Console.WriteLine("1. Animal Farm *** George Orwell *** 112 pages *** Allegory, Satire, Novella, Political satire, Roman à clef, Dystopian Fiction ");
                            Console.WriteLine("2. A Confederacy of Dunces *** John Kennedy Toole *** 636 pages *** Novel, Humour, Comedy, Picaresque novel, Humorous Fiction, Tragicomedy");

                            Console.Write("If you want go back write Back: ");
                            ComeGenre = Console.ReadLine();
                        }
                        else if (genre == 12)
                        {
                            Comeback = "Back";
                        }

                        else if (genre >= 13)
                        {
                            Console.WriteLine("!Incorrect number!\nEnter the right one Please");
                        }


                    }
                } while (ComeGenre == "Back");
                do
                {
                    AuthorsMenu = "none";
                    if (MainMenu == 2)
                    { //Books by authors
                        Console.WriteLine("Orwell");
                        Console.WriteLine("Poe");
                        Console.WriteLine("Author3");
                        Console.WriteLine("For Main Menu write Back");
                        //find a way how to operate with string in if like string == name of author.
                        Console.Write("Enter author name: ");
                        string Authors = Console.ReadLine();
                        if (Authors == "Orwell")
                        {
                            Console.WriteLine("***George Orwell***");
                            Console.WriteLine("Nineteen Eighty-four *** 328 pages *** Science fiction, Social science fiction, Dystopian Fiction, Political fiction");
                            Console.Write("If you want go back write Back: ");
                            AuthorsMenu = Console.ReadLine();
                        }
                        if (Authors == "Poe")
                        {
                            Console.WriteLine("***Edgar Allan Poe***");
                            Console.WriteLine("The Murders in the Rue Morgue *** 264 pages *** Mystery, Detective novel, Crime Fiction");
                            Console.Write("If you want go back write Back: ");
                            AuthorsMenu = Console.ReadLine();

                        }
                        if (Authors == "Author3")
                        {
                            Console.WriteLine("Doesn´t exist");
                            Console.Write("If you want go back write Back: ");
                            AuthorsMenu = Console.ReadLine();
                        }
                        if (Authors == "Back")
                        {
                            Comeback = "Back";
                        }
                    }
                } while (AuthorsMenu ==  "Back");

                if (MainMenu == 3)
                        {    //Books in read process.
                            Console.WriteLine("***Edgar Allan Poe***");
                            Console.WriteLine("The Murders in the Rue Morgue *** 85/264 pages *** Mystery, Detective novel, Crime Fiction");
                            Console.Write("If you want go back write Back: ");
                            Comeback = Console.ReadLine();
                        }

                        if (MainMenu == 4)
                        {    //unreaded books
                            Console.WriteLine("1.***George Orwell***");
                            Console.WriteLine("Nineteen Eighty-four *** 328 pages *** Science fiction, Social science fiction, Dystopian Fiction, Political fiction");
                            Console.WriteLine("2. The Hound of the Baskervilles *** Arthur Conan Doyle *** 254 pages *** Novel, Mystery, Detective novel, Crime Fiction ");
                            Console.Write("If you want go back write Back: ");
                            Comeback = Console.ReadLine();


                        }

                        if (MainMenu == 5)
                        {    // Readed books.
                            Console.WriteLine("Title // Writer // Genre // total pages");
                            Console.WriteLine("1. Hamlet *** Willien Shakespeare *** 29 551 words *** Tragedy, Drama");
                            Console.WriteLine("2. Romeo and Juliet *** William Shakespeare *** Long *** Tragedy");
                            Console.Write("If you want go back write Back: ");
                            Comeback = Console.ReadLine();
                        }

                        if (MainMenu == 6)
                        {   // missing books in bundle.
                            Console.WriteLine("Title // Writer // Genre // total pages");
                            Console.WriteLine("1. The Masque of the Red Death *** Edgar Allan Poe *** 451 pages *** Gothic fiction, horror");
                            Console.Write("If you want go back write Back: ");
                            Comeback = Console.ReadLine();
                        }
                    

                

            } while (Comeback == "Back");
        }
    }
}


