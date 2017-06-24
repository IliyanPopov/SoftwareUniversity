
<h2>1. Create a Database for Student System using Code First</h2>
<p>First of all, create a <strong>Blank Solution</strong> and name it accordingly - in our case, <strong>BookShopSystem</strong> sounds like a nice name.</p>
<p>After that create simple console application:</p>
<p>We will separate code into different folders - <strong>Models</strong> (holding the classes Entity Framework will use as a basis for creating our database), <strong>Data</strong> (holding Entity Framework specific logic) and <strong>Client</strong> (holding our renamed Program.cs file).</p>
<p>Before we continue make sure that we have installed Entity Framework (go to the project then right click on &ldquo;<strong>References</strong>&rdquo; -&gt; &ldquo;<strong>Manage&hellip;</strong>&rdquo;):</p>
<p>Then in the new query window change section to &ldquo;<strong>Browse</strong>&rdquo; search for entity framework and install it.</p>
<h3>Step 1 - Model the Database</h3>
<p>A book shop keeps <strong>books</strong>. A book can have one <strong>author</strong> and many <strong>categories</strong>. Let's create a class for each of the main tables.</p>
<ul>
<li><strong>Book</strong> - id, title (between 1 ... 50 symbols - inclusive), description (optional, up to 1000 symbols), edition type <br/> (<strong>Normal</strong>, <strong>Promo</strong> or <strong>Gold</strong>), price, copies (number), release date (optional)</li>
<li><strong>Author</strong> - id, first name (optional) and last name</li>
<li><strong>Category</strong> - id, name</li>
</ul>
<p>Assume everything <strong>not market optional</strong> is mandatory. The <strong>classes</strong> should describe with <strong>properties</strong> each of the <strong>table columns</strong>.</p>
<p>For the book edition type you could use enumeration:</p>
<p>Add constraints as described above using attributes (e.g. <strong>Required</strong>, <strong>MinLength</strong>, <strong>MaxLength</strong>, etc). Do the same for the <strong>Book</strong> and <strong>Category</strong> models. Make sure you add <strong>navigation properties</strong> when there are relations.</p>
<p><strong><u>Important</u></strong><u> <strong>Note</strong></u>: Always make <strong>navigation properties</strong> <strong>virtual</strong>, so Entity Framework can <strong>override</strong> them and apply <strong>lazy loading</strong>.</p>
<h3>Step 2 - Create the Data Folder</h3>
<p>Once the models are done, our next step is to write the so-called <strong>Data Layer </strong>(Folder). Let's create it in a separate folder.</p>
<p>In the newly created folder, add a new ADO.NET Entity Data Model. Name it <strong>BookShopContext</strong>.</p>
<p>From the Model Wizard, select <strong>Empty Code First Model </strong>(meaning we will model our database from the code we write alone).</p>
<p>The Wizard should generate a <strong>BookShopContext</strong> class in our Data folder. The idea behind the context is that it <strong>manages the connection to the database</strong> for us and reveals all data as <strong>DbSet&lt;T&gt;</strong> - generic collections which represent the data stored in our database. Thanks to it, we can easily work on that data with standard CRUD operations - just like we work with any C# collections!</p>
<p>Delete the auto-generated comments and let's start writing.</p>
<p>In the <strong>BookShopContext</strong> class, write in all necessary tables (as shown below) as <strong>IDbSet&lt;T&gt;</strong><strong> properties</strong>, where <strong>T</strong> is the respective table. Make those properties public so we can access them outside the current project.</p>
<p>Make them <strong>virtual</strong>.</p>
<p>After that's done, there's one final thing left. In the <strong>App.config</strong> file there is a <strong>&lt;connectionStrings/&gt;</strong> tag which keeps information about the connection.</p>
<ul>
<li>The <strong>name </strong>attribute should correspond to the <strong>connection string</strong> in the <strong>Context</strong> <strong>constructor</strong>.</li>
<li>Data source holds the target database (if you're using SQL Express it should be <strong>.</strong> or <strong>localhost</strong>. Otherwise, leave it <strong>(LocalDb)\v11.0</strong>.</li>
</ul>
<h3>Step 3 - Console Client</h3>
<p>We now have our <strong>models</strong> (classes which will be mapped to database tables) and our <strong>data layer. </strong>It's time we write the console client and start Entity Framework for the first time.</p>
<p>Finally, in order for Entity Framework to <strong>create the database</strong> for us, we need to execute any action through the <strong>context</strong>.</p>
<p>The application should finish without any exceptions.</p>
<p>The generated relational <strong>diagram</strong> should be as follows:</p>
<h3>Step 4 - Make Changes to the Local Model</h3>
<p>Let's add a new property to the <strong>Book</strong> class - <strong>AgeRestriction</strong> (Minor, Teen or Adult). Run the program again. We expect EF to update the dabase according to the changes made to the models. However&hellip;</p>
<p>We get an exception and we are told to use <strong>Code First Migrations</strong>. <strong>Migrations</strong> update database according to the model by using a <strong>strategy</strong>. We need to configure Entity Framework to use a <strong>migration strategy </strong>(i.e. tell it what to do each time it <strong>connects</strong> to the database for the <strong>first time</strong>).</p>
<p>First, we need to <strong>enable automatic migrations</strong>. Open the Package Manager Console and write the following command:</p>
<p>This will create a <strong>Configuration.cs</strong> class which enables automatic migrations and has a <strong>Seed()</strong> method.</p>
<p>Finally, we need to the EF to apply a specific strategy to this configuration. The most used migrations are as follows:</p>
<ul>
<li><strong>DropCreateDatabaseIfModelChanges </strong>- We lose all the data when the model changes</li>
<li><strong>DropCreateDatabaseAlways </strong>- Recreate the database each time we start the program</li>
<li><strong>MigrateDatabaseToLatestVersion </strong>- Updates the database in accordance to the changes we've made to the model</li>
</ul>
<p>Select the last migration strategy and initialize it as shown below in the <strong>Main()</strong> method.</p>
<p>Once done, start the program again and no exception should occur. The design of the Books table should have a new column added.</p>
<h3>Step 5 - Seed Data into the Database</h3>
<p>We have our database up and running. However, there is no data to work with. Let's seed some!</p>
<p>Go to the <strong>Seed()</strong> method of the <strong>Configuration.cs</strong> class we just created. Add three methods as shown below.</p>
<p>Create new folder &ldquo;<strong>Import</strong>&rdquo; inside your project. In it put all <strong>authors.csv</strong>, <strong>books.csv </strong>and <strong>categories.csv</strong>:</p>
<p>Here is how SeedAuthors may look like:</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Importing Authors from File</strong></p>
</td>
</tr>
<tr>
<td>
<p>private static void SeedAuthors(BookShopContext context)</p>
<p>{</p>
<p> string[] authors = File.ReadAllLines("../../Import/authors.csv");</p>
<p> // Foreach all authors and add them to database.</p>
<p> // Skip first row because it is only describing column names.</p>
<p> for (int i = 1; i &lt; authors.Length; i++)</p>
<p> {</p>
<p> string[] data = authors[i].Split(',');</p>
<p> string firstName = data[0].Replace("\"", string.Empty);</p>
<p> string lastName = data[1].Replace("\"", string.Empty);</p>
<p> Author author = new Author()</p>
<p> {</p>
<p> FirstName = firstName,</p>
<p> LastName = lastName</p>
<p> };</p>
<p> // When adding we may want to check if author with same first name and last name is existing.</p>
<p> context.Authors.AddOrUpdate(a =&gt; new { a.FirstName, a.LastName }, author);</p>
<p> }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p><br/> Useful links:</p>
<ul>
<li>What is <a href="https://en.wikipedia.org/wiki/Comma-separated_values">CSV</a>?</li>
</ul>
<p>Here is how SeedBooks may look like:</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Importing Books from File</strong></p>
</td>
</tr>
<tr>
<td>
<p>private static void SeedBooks(BookShopContext context)</p>
<p>{</p>
<p> int authorsCount = context.Authors.Local.Count;</p>
<p> string[] books = File.ReadAllLines("../../Import/books.csv");</p>
<p> for (int i = 1; i &lt; books.Length; i++)</p>
<p> {</p>
<p> string[] data = books[i]</p>
<p> .Split(',')</p>
<p> .Select(arg =&gt; arg.Replace("\"", string.Empty))</p>
<p> .ToArray();</p>
<p> int authorIndex = i % authorsCount;</p>
<p> Author author = context.Authors.Local[authorIndex];</p>
<p> EditionType edition = (EditionType)int.Parse(data[0]);</p>
<p> DateTime releaseDate = DateTime.ParseExact(data[1], "d/M/yyyy",CultureInfo.InvariantCulture);</p>
<p> int copies = int.Parse(data[2]);</p>
<p> decimal price = decimal.Parse(data[3]);</p>
<p> AgeRestriction ageRestriction = (AgeRestriction)int.Parse(data[4]);</p>
<p> string title = data[5];</p>
<p> Book book = new Book</p>
<p> {</p>
<p> Author = author,</p>
<p> AuthorId = author.Id,</p>
<p> Edition = edition,</p>
<p> ReleaseDate = releaseDate,</p>
<p> Copies = copies,</p>
<p> Price = price,</p>
<p> AgeRestriction = ageRestriction,</p>
<p> Title = title</p>
<p> };</p>
<p> context.Books.AddOrUpdate(b =&gt; new { b.Title, b.AuthorId }, book);</p>
<p> }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>Useful links:</p>
<ul>
<li>Working with <a href="https://www.dotnetperls.com/enum">enumerations</a>.</li>
<li>Working with context <a href="http://www.entityframeworktutorial.net/EntityFramework4.3/local-data.aspx">local</a></li>
</ul>
<p>You should implement SeedCategories like this:</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Importing Categories from File</strong></p>
</td>
</tr>
<tr>
<td>
<p>private static void SeedCategories(BookShopContext context)</p>
<p>{</p>
<p> int booksCount = context.Books.Local.Count;</p>
<p> string[] categories = File.ReadAllLines("../../Import/categories.csv");</p>
<p> for (int i = 1; i &lt; categories.Length; i++)</p>
<p> {</p>
<p> string[] data = categories[i]</p>
<p> .Split(',')</p>
<p> .Select(arg =&gt; arg.Replace("\"", string.Empty))</p>
<p> .ToArray();</p>
<p> string categoryName = // TODO: Get name from data.</p>
<p> Category category = new Category() { Name = categoryName };</p>
<p> int bookIndex = (i * 30) % booksCount;</p>
<p> for (int j = 0; j &lt; bookIndex; j++)</p>
<p> {</p>
<p> Book book = context.Books.Local[j];</p>
<p> // TODO: Add book to current category</p>
<p> }</p>
<p> context.Categories.AddOrUpdate(c =&gt; c.Name, category);</p>
<p> }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 6 - Related Books</h3>
<p>Let's say at one point we decide that <strong>books</strong> should have <strong>related books</strong> - i.e. a book has many related books and each related book has related books as well.</p>
<p>Go to the <strong>Book</strong> class and add a <strong>navigational property </strong><strong>RelatedBooks</strong>(collection of releted books). Make sure you <strong>instantiate</strong> it in the constructor.</p>
<p>Start the program again.</p>
<p>No errors. The migration has most likely been successful and we should see a many-to-many self-reference in the database schema.</p>
<p>However, that's not the case - the migration is successful but a book can have only 1 related book.</p>
<p>This is one of those cases where Entity Framework does not correctly update the DB schema after changes have been made to the model.</p>
<p>In such events, we need to manually configure the relationship with the so-called <strong>Model Builder</strong>. Go to the <strong>BookShopContext</strong> class and override the <strong>OnModelCreating()</strong> method.</p>
<p>This method is called only once when entity framework starts for the first time (like <strong>Seed()</strong>). It receives a <strong>DbModelBuilder</strong> as argument. We will use that model builder to configure the desired relationship.</p>
<p>The Model Builder (also <strong>fluent API</strong>) will allow us to tell EF that a <strong>Book</strong> has <strong>many books</strong> (the related books) and those books have many as well. Then we will map that relationship to a <strong>junction</strong> (<strong>many-to-many</strong>) table where we manually set the <strong>left key</strong> (book id) and <strong>right key</strong> (related book id). Finally, we <strong>name the table</strong>.</p>
<p>At the end, we call the <strong>base</strong> implementation of the method (it contains native EF configurations, so it's best we call it at the end).</p>
<p>Restart the program and if no exception is thrown, the new DB schema should now look as follows:</p>
<p>Keep in mind that your column and table names may differ from the ones in the above picture.</p>
<p>And finally, let's test the <strong>RelatedBooks</strong> functionality it. <strong>Query 3 books</strong> from the database and set them as <strong>related</strong>.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
<td>
<p><strong>Sample Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>var books = context.Books</p>
<p> .Take(3)</p>
<p> .ToList();</p>
<p>books[0].RelatedBooks.Add(books[1]);</p>
<p>books[1].RelatedBooks.Add(books[0]);</p>
<p>books[0].RelatedBooks.Add(books[2]);</p>
<p>books[2].RelatedBooks.Add(books[0]);</p>
<p>context.SaveChanges();</p>
<p>// <strong>TODO:</strong></p>
<p>// <strong>Query the first three books to get their names</strong></p>
<p>// <strong>and their related book names</strong></p>
<p>foreach (var book in booksFromQuery)</p>
<p>{</p>
<p> Console.WriteLine("--{0}", book.Title);</p>
<p> foreach (var relatedBook in book.RelatedBooks)</p>
<p> {</p>
<p> Console.WriteLine(relatedBook);</p>
<p> }</p>
<p>}</p>
</td>
<td>
<p>--Absalom</p>
<p>A che punto A" la notte</p>
<p>After Many a Summer Dies the Swan</p>
<p>--A che punto A" la notte</p>
<p>Absalom</p>
<p>--After Many a Summer Dies the Swan</p>
<p>Absalom</p>
</td>
</tr>
</tbody>
</table>


<h1>Bookshop System</h1>
<p>For the following tasks use the <a href="http://svn.softuni.org/admin/svn/DB-Fundamentals/DB-Advanced-EntityFramework/Feb-2017/06.%20DB-Advanced-EntityFramework-EntityFramework-Relations(Advanced)/BookShopSystem-Solution.zip">BookhopSystem</a> database from the <a href="https://softuni.bg/downloads/svn/DB-Fundamentals/DB-Advanced-Hibernate/Oct-2016/05.%20DB-Advanced-Hibernate-Hibernate-Relations/04.%20DB-Advanced-Hibernate-Hibernate-Code-First-Exercise-Bookshop.zip">previous exercise</a>. Make sure it has proper connections between tables and its populated with any sample data.</p>
<h2>1. Books Titles by Age Restriction</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints titles of all books</strong> where their <strong>age restriction</strong> matches the given input (minor, teen or adult). <strong>Ignore </strong><a href="https://msdn.microsoft.com/en-us/library/kxydatf9(v=vs.110).aspx">casing</a> of the input.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>miNor</p>
</td>
<td>
<p>A che punto &Atilde; la note</p>
<p>After Many a Summer Dies the Swan</p>
<p>Ah</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td>
<p>teEN</p>
</td>
<td>
<p>All Passion Spent</p>
<p>Wide Sea</p>
<p>Antic Hay</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>2. Golden Books</h2>
<p>Write a program that selects and prints <strong>titles of the golden edition books</strong> and have <strong>less than 5000 copies</strong>. Order them by book id ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Behold the Man</p>
<p>Bury My Heart at Wounded Knee</p>
<p>The Cricket on the Hearth</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3. Books by Price</h2>
<p>Write a program that selects <strong>prints titles and price</strong> <strong>of books</strong> with <strong>price lower than 5</strong> and <strong>higher than 40</strong>. Order them by book id ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>A che punto &Atilde; la note - $45.78</p>
<p>All the King's Men - $45.60</p>
<p>An Evil Cradling - $3.30</p>
<p>Beyond the Mexique Bay - $45.45</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>4. Not Released Books</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints titles</strong> of all books that are <strong>NOT released</strong> on given year. Order them by book id ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>2000</p>
</td>
<td>
<p>Absalom</p>
<p>A che punto &Atilde; la note</p>
<p>After Many a Summer Dies the Swan</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td>
<p>1998</p>
</td>
<td>
<p>A che punto &Atilde; la note</p>
<p>Ah</p>
<p>Wilderness!</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>5. Book Titles by Category</h2>
<p>Write a program that <strong>selects</strong> and <strong>print titles of books</strong> by given <strong>list of categories</strong>. The list of categories will be given in a single one separated with one or more spaces. Ignore casing. Order by book id ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>fantasy thriller crime</p>
</td>
<td>
<p>Absalom</p>
<p>A che punto A la notte</p>
<p>After Many a Summer Dies the Swan</p>
<p>Ah</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>6. Books Released Before Date</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints title, edition type and price </strong>of books that are <strong>released before given date</strong> as an input from the console. The date will be <strong>in format dd-MM-yyyy</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>12-04-1992</p>
</td>
<td>
<p>All Passion Spent - Promo - 7.18</p>
<p>Bury My Heart at Wounded Knee - Gold - 3.86</p>
<p>A Catskill Eagle - Normal - 15.78</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td>
<p>30-12-1989</p>
</td>
<td>
<p>Bury My Heart at Wounded Knee - Gold - 3.86</p>
<p>Consider the Lilies - Promo - 30.89</p>
<p>The Curious Incident of the Dog in the Night-Time - Normal - 23.41</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>7. Authors Search</h2>
<p>Write a program that <strong>prints names</strong> of those authors whose <strong>first name ends with </strong>given string.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>e</p>
</td>
<td>
<p>George Powell</p>
<p>Jane Ortiz</p>
<p>Julie Washington</p>
</td>
</tr>
<tr>
<td>
<p>dy</p>
</td>
<td>
<p>Randy Morales</p>
<p>Randy Graham</p>
</td>
</tr>
</tbody>
</table>
<h2>8. Books Search</h2>
<p>Write a program that <strong>selects and prints</strong> <strong>titles of books</strong> which <strong>contains given string</strong> (regardless of the casing).</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>sK</p>
</td>
<td>
<p>A Catskill Eagle</p>
<p>The Daffodil Sky</p>
<p>The Skull Beneath the Skin</p>
</td>
</tr>
<tr>
<td>
<p>WOR</p>
</td>
<td>
<p>Great Work of Time</p>
<p>Terrible Swift Sword</p>
</td>
</tr>
</tbody>
</table>
<h2>9. Book Titles Search</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints titles of books</strong> which are <strong>written by authors </strong>whose<strong> last name start with given string</strong>. Ignore casing. Order by book id ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>R</p>
</td>
<td>
<p>An Evil Cradling (Lillian Robertson)</p>
<p>A Time to Kill (Frances Ross)</p>
<p>Blood's a Rover (Amanda Rice)</p>
</td>
</tr>
<tr>
<td>
<p>gr</p>
</td>
<td>
<p>The Alien CornA&nbsp;(short story) (Brenda Griffin)</p>
<p>Arms and the Man (Randy Graham)</p>
<p>Blithe Spirit (Chris Graham)</p>
</td>
</tr>
</tbody>
</table>
<h2>10. Count Books</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints</strong> <strong>number of books</strong> whose <strong>title is longer than a number</strong> given as an input.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
<td>
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td>
<p>12</p>
</td>
<td>
<p>174</p>
</td>
<td>
<p>There are 174 books with longer title than 12 symbols</p>
</td>
</tr>
<tr>
<td>
<p>40</p>
</td>
<td>
<p>2</p>
</td>
<td>
<p>There are 2 books with longer title than 40 symbols</p>
</td>
</tr>
</tbody>
</table>
<h2>11. Total Book Copies</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints</strong> the <strong>total number of book copies</strong> <strong>by author</strong>. Order the results <strong>descending by total book copies</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Amanda Rice &ndash; 87819</p>
<p>Amy Porter &ndash; 29366</p>
<p>Christina Jordan &ndash; 18708</p>
<p>Earl Bennett &ndash; 12978</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>12. Find Profit</h2>
<p>Write a program that <strong>selects</strong> and <strong>prints</strong> the <strong>total profit of all books by category</strong>. Profit for a book can be calculated by multiplying its <strong>number of copies</strong> with <strong>price per single book</strong>. Order the results <strong>descending by total profit</strong> for category and <strong>ascending by category name</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Romance - $68796663.44</p>
<p>Science Fiction - $58574167.29</p>
<p>Mystery - $43998398.44</p>
<p>Fiction - $32311904.52</p>
<p>Thriller - $21279119.91</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>13. Most Recent Books</h2>
<p>Get the most recent books by categories. The <strong>categories</strong> should be ordered by <strong>total</strong> <strong>book count</strong>. Only take the <strong>top 3</strong> most recent books from each category - ordered by <strong>date</strong> (descending), then by <strong>title</strong> (ascending). <strong>Select</strong> and <strong>print</strong> the <strong>category name</strong>, <strong>total book count</strong> and for each <strong>book</strong> - its <strong>title</strong> and <strong>release date</strong>. Get only those categories that <strong>have total book count more than 35</strong>.</p>
<p><strong>Note</strong>: Books may appear in several categories.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>--Romance: 180 books</p>
<p>Brandy of the Damned (2015)</p>
<p>Surprised by Joy (2014)</p>
<p>Alien CornA&nbsp;(play) (2014)</p>
<p>--Science Fiction: 150 books</p>
<p>Brandy of the Damned (2015)</p>
<p>Alien CornA&nbsp;(play) (2014)</p>
<p>Great Work of Time (2014)</p>
<p>--Mystery: 120 books</p>
<p>Brandy of the Damned (2015)</p>
<p>Alien CornA&nbsp;(play) (2014)</p>
<p>Great Work of Time (2014)</p>
<p>--Fiction: 90 books</p>
<p>Brandy of the Damned (2015)</p>
<p>Alien CornA&nbsp;(play) (2014)</p>
<p>Great Work of Time (2014)</p>
</td>
</tr>
</tbody>
</table>
<h2>14. Increase Book Copies</h2>
<p>Write a program that <strong>increases the copies of all books</strong> <strong>released after &lsquo;</strong>06 Jun 2013&rsquo; <strong>with </strong>44. Print the total amount of book copies that were added.</p>
<h3>Output</h3>
<ul>
<li><strong>Total number of books</strong> that was added to the database</li>
</ul>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
<td>
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td>
<p>572</p>
</td>
<td>
<p>13 books are released after 6 Jun 2013 so total of 572 book copies were added</p>
</td>
</tr>
</tbody>
</table>
<h2>15. Remove Books</h2>
<p>Write a program that <strong>removes from the database</strong> those <strong>books</strong> whose <strong>copies are lower than 4200</strong>. Print on the console the <strong>number of books that were deleted</strong> from the database. Remember to call SaveChanges().</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>34 books were deleted</p>
</td>
</tr>
</tbody>
</table>
<h2>16. Stored Procedure</h2>
<p>Using SQL Server Management Studio <strong>create stored procedure</strong> that receives <strong>authors first and last name</strong> and returns the <strong>total number of books that author has written</strong>. Then write a <strong>program</strong> that <strong>receives author name</strong> from the console and prints the <strong>total number of books</strong> that author has written by <strong>using the stored procedure</strong> you&rsquo;ve just created.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Amanda Rice</p>
</td>
<td>
<p>Amanda Rice has written 4 books</p>
</td>
</tr>
<tr>
<td>
<p>Beverly Ford</p>
</td>
<td>
<p>Beverly Ford has written 4 books</p>
</td>
</tr>
<tr>
<td>
<p>Wanda Morales</p>
</td>
<td>
<p>Wanda Morales has written 6 books</p>
</td>
</tr>
</tbody>
</table>
<h2>17. Call a Stored Procedure</h2>
<p>Your task is to create a stored procedure in the <strong>SoftUni</strong> database for finding <strong>all projects</strong> for given employee. The procedure should receive <strong>first name</strong> and <strong>last name</strong> as arguments.</p>
<p>Using EF implement a C# method that calls the stored procedure and returns the result projects' <strong>name</strong>, <strong>description</strong> and <strong>start date</strong>.</p>
<p>Note that in the picture above description is sliced for the sake of simplicity.</p>
<h2>18. Employees Maximum Salaries</h2>
<p>Write a program to find the <strong>max salary</strong> for each <strong>department</strong>. Filter those which have max salaries not in the range 30000 and 70000.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Tool Design - 29800.00</p>
</td>
</tr>
<tr>
<td>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>19. Deposits Sum for Ollivander Family</h2>
<p>Use the <strong>Gringotts database</strong>. Write a program that print all <strong>deposit groups</strong> and its <strong>total deposit sum</strong> but only for the wizards who has their magic wand crafted by Ollivander family.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Human Pride - 188366.86</p>
</td>
</tr>
<tr>
<td>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>20. Deposits Filter</h2>
<p>Use the <strong>Gringotts database</strong>. Write a program that print all <strong>deposit groups</strong> and its <strong>total deposit sum</strong> but only for the wizards who has their magic wand crafted by Ollivander family. After this filter total deposit amounts lower than 150000. Order by total deposit amount in descending order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>Troll Chest - 126585.18</p>
</td>
</tr>
<tr>
<td>
<p>Blue Phoenix - 52968.96</p>
</td>
</tr>
<tr>
<td>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>