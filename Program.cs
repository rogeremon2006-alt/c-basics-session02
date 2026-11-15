#region Q1,Q2
Book b = new Book();
b.title = "David copperfield";
b.pages = 1000;
Console.WriteLine(b.title);
Console.WriteLine(b.pages);
Console.WriteLine(b.ToString());
Console.WriteLine(b.Equals("David copperfield"));
Console.WriteLine(b.GetHashCode());
Console.WriteLine(b.GetType());
class Book
{
    public String title;
    public int pages;
}
#endregion

#region Q3
// Compile-time error 
// int pages = "464";
int pages03 = int.Parse("464");  
#endregion

#region Q4
try
{
    int z = 0;
    int result = 10 / z;
    Console.WriteLine(result);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
#endregion

#region Q5
int pagess = 300;
double book= Convert.ToDouble(pagess);
Console.WriteLine(book);
#endregion

#region Q6
double price = 49.99;
int finalprice =(int)price;
Console.WriteLine(finalprice);
#endregion

#region Q7
string pagesText = "464";
int pagesNumber = Convert.ToInt32(pagesText);
#endregion

#region Q8
string yearText = "2023";
int yearNumber =int.Parse(yearText);
Console.WriteLine(yearNumber);
string badText = "abc";
bool isValid = int.TryParse(badText, out int badNumber);
Console.WriteLine(isValid);
#endregion

#region Q9
int pages02 = 464;
string pagesText02 = pages02.ToString();

Console.WriteLine(pagesText02);            
Console.WriteLine(pagesText02.GetType());
#endregion

#region Q10
int copies = 100;
object boxed = copies;        
int unboxed = (int)boxed;     
Console.WriteLine(boxed);     
Console.WriteLine(unboxed);
#endregion
