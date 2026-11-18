namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();

            #region object Methods
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetType());
            #endregion

            #region the error
            // so the error it is easy 
            //int pages = "464";
            int pages = 464; // it will be this because the variable int is only store numbers
            // and he is compile error btw
            #endregion

            #region try catch
            try
            {
                int num = 10;
                int result = num / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region converts 
            int pages1 = 300;
            double Pages2 = Convert.ToDouble(pages1);

            double price = 49.99;
            int price2 = Convert.ToInt32(price);

            string pagesText = "464";
            int pages3 = Convert.ToInt32(pagesText);

            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";
            int badNumber = int.TryParse(badText, out int invalidNumber) ? invalidNumber : 0;

            int pages4 = 464;
            string pagesText2 = pages4.ToString();
            Console.WriteLine(pages4.GetType());
            #endregion

            #region boxing and unboxing
            int copies = 100; // boxing here 
            object obj = copies;
            int newCopies = (int)obj; // then unboxing
            Console.WriteLine(obj);
            Console.WriteLine(newCopies);
            #endregion
            #region nullable 
            int? year2 = null; // using ? to ask if it will be null
            Console.WriteLine(year2.HasValue);
             year2 = 2023;
            Console.WriteLine(year2.HasValue);
            Console.WriteLine(year2.Value);
             
            string? reviewer = null; // same as int 
            Console.WriteLine(reviewer == null);

            // we got wrong syntex here casue we cant define new 2 instance in one scope so beacuse we defined in the top
            //here num 4
            Book? book2 = null;
            Console.WriteLine(book2?.title);

            // here num 5
            string? title = null;
            Console.WriteLine(title?? "untitled");
            title ??= "untitled";
            Console.WriteLine(title);



            // here num 6 
            string? name = "Ahmed";
            string confirme = name!;
            Console.WriteLine(confirme);


            #endregion
        }
    }
    
}
