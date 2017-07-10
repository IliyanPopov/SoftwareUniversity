
<h2>Problem 1. Person</h2>
<p>You are asked to model an application for storing data about people. You should be able to have a person and a child. The child is derived of the person. Your task is to model the application. The only constraints are:</p>
<ul>
<li>People should <strong>not</strong> be able to have <strong>negative age</strong></li>
<li>Children should <strong>not</strong> be able to have age <strong>more than 15</strong>.</li>
</ul>
<p></p>
<ul>
<li><strong>Person</strong> &ndash; represents the base class by which all others are implemented</li>
<li><strong>Child</strong> - represents a class which is derived by the</li>
</ul>
<h3>Note</h3>
<p>Your class&rsquo;s names <strong>MUST</strong> be the same as the names shown above!!!</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Main()</strong></p>
</td>
</tr>
<tr>
<td>
<p>static void Main()</p>
<p>{</p>
<p> string name = Console.ReadLine();</p>
<p> int age = int.Parse(Console.ReadLine());</p>
<p> try</p>
<p> {</p>
<p> Child child = new Child(name, age);</p>
<p> Console.WriteLine(child);</p>
<p> }</p>
<p> catch (ArgumentException ae)</p>
<p> {</p>
<p> Console.WriteLine(ae.Message);</p>
<p> }</p>
}</td>
</tr>
</tbody>
</table>
<p>Create a new empty class and name it <strong>Person</strong>. Set its access modifier to <strong>public </strong>so it can be instantiated from any project. Every person has a name, and age.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public class Person</p>
<p>{</p>
<p> // 1. Add Fields</p>
<p> // 2. Add Constructor</p>
<p> // 3. Add Properties</p>
<p> // 4. Add Methods</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 2 &ndash; Define the fields</h3>
<p>Define a <strong>field</strong> for each property the class should have (e.g. <strong>Name</strong>, <strong>Age</strong>)</p>
<h3>Step 3 - Define the Properties of a Person</h3>
<p>Define the <strong>Name</strong> and <strong>Age</strong> properties of a Person. Ensure that they can only be <strong>changed by the class itself or its descendants</strong> (pick the most appropriate access modifier).</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public virtual string Name</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> //TODO</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> //TODO</p>
<p> }</p>
<p>}</p>
<p>public virtual int Age</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> //TODO</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> //TODO</p>
 }}</td>
</tr>
</tbody>
</table>
<h3>Step 4 - Define a Constructor</h3>
<p>Define a constructor that accepts <strong>name and age</strong>.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public Person(string name, int age)</p>
<p>{</p>
<p> this.Name = name;</p>
<p> this.Age = age;</p>
}</td>
</tr>
</tbody>
</table>
<h3>Step 5 - Perform Validations</h3>
<p>After you have created a <strong>field</strong> for each property (e.g. <strong>Name</strong> and <strong>Age</strong>). Next step is to <strong>perform validations</strong> for each one. The <strong>getter should return the corresponding field&rsquo;s value</strong> and the <strong>setter should validate</strong> the input data before setting it. Do this for each property.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public virtual int Age</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> return this.age;</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> if (value &lt; 0)</p>
<p> {</p>
<p> throw new ArgumentException("Age must be positive!");</p>
<p> }</p>
<p> //TODO set field age with value</p>
<p> }</p>
}</td>
</tr>
</tbody>
</table>
<h3>Constraints</h3>
<ul>
<li>If the age of a person is negative &ndash; exception&rsquo;s message is: <strong>"Age must be positive!"</strong></li>
<li>If the age of a child is bigger than 15 &ndash; exception&rsquo;s message is: <strong>"Child&rsquo;s age must be less than 15!"</strong></li>
<li>If the name of a child or a person is no longer than 3 symbols &ndash; exception&rsquo;s message is: <strong>"Name&rsquo;s length should not be less than 3 symbols!"</strong></li>
</ul>
<h3>Step 6 - Override ToString()</h3>
<p>As you probably already know, all classes in C# inherit the <strong>Object</strong> class and therefore have all its <strong>public</strong> members (<strong>T</strong><strong>oString()</strong>, <strong>E</strong><strong>quals()</strong> and <strong>G</strong><strong>etHashCode()</strong> methods). <strong>T</strong><strong>oString()</strong> serves to return information about an instance as string. Let's <strong>override</strong> (change) its behavior for our <strong>Person</strong> class.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public override string ToString()</p>
<p>{</p>
<p> StringBuilder stringBuilder = new StringBuilder();</p>
<p> stringBuilder.Append(String.Format("Name: {0}, Age: {1}",</p>
<p> this.Name,</p>
<p> this.Age));</p>
<p> return stringBuilder.ToString();</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>And voila! If everything is correct, we can now create <strong>Person objects</strong> and display information about them.</p>
<h3>Step 7 &ndash; Create a Child</h3>
<p>Create a <strong>Child </strong>class that inherits <strong>Person</strong> and has the same constructor definition. However, do not copy the code from the Person class - <strong>reuse the Person class&rsquo;s constructor</strong>.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public Child(string name, int age)</p>
<p> : base(name, age)</p>
<p>{</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>There is <strong>no need</strong> to rewrite the Name and Age properties since <strong>Child</strong> inherits <strong>Person </strong>and by default has them.</p>
<h3>Step 8 &ndash; Validate the Child&rsquo;s setter</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public override int Age</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> return base.Age;</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> //TODO validate childs age</p>
<p> base.Age = value;</p>
<p> }</p>
}</td>
</tr>
</tbody>
</table>
<h2>Problem 2. Book Shop</h2>
<p>You are working in a library. And you are pissed of writing descriptions for books by hand, so you wish to use the computer to speed up the process. The task is simple - your program should have two classes &ndash; one for the ordinary books &ndash; <strong>Book</strong>, and another for the special ones &ndash; <strong>GoldenEditionBook</strong>. So let&rsquo;s get started! We need two classes:</p>
<ul>
<li><strong>Book</strong> - represents a book that holds <strong>title</strong>, <strong>author </strong>and <strong>price</strong>. A book should offer <strong>information</strong> about itself in the format shown in the output below.</li>
<li><strong>GoldenEditionBook</strong> - represents a special book holds the same properties as any <strong>Book</strong>, but its <strong>price</strong> is always <strong>30% higher</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>If the author&rsquo;s second name is starting with a digit&ndash; exception&rsquo;s message is: <strong>"Author not valid!"</strong></li>
<li>If the title&rsquo;s length is less than 3 symbols &ndash; exception&rsquo;s message is: <strong>"Title not valid!"</strong></li>
<li>If the price is zero or it is negative &ndash; exception&rsquo;s message is: <strong>"Price not valid!"</strong></li>
<li>Price must be formatted to <strong>one</strong> symbol after the decimal separator</li>
</ul>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Main()</strong></p>
</td>
</tr>
<tr>
<td>
<p>static void Main()</p>
<p>{</p>
<p> try</p>
<p> {</p>
<p> string author = Console.ReadLine();</p>
<p> string title = Console.ReadLine();</p>
<p> decimal price = decimal.Parse(Console.ReadLine());</p>
<p> Book book = new Book(author, title, price);</p>
<p> GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);</p>
<p> Console.WriteLine(book);</p>
<p> Console.WriteLine(goldenEditionBook);</p>
<p> }</p>
<p> catch (ArgumentException ae)</p>
<p> {</p>
<p> Console.WriteLine(ae.Message);</p>
<p> }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
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
<p>Ivo 4ndonov</p>
<p>Under Cover</p>
<p>9999999999999999999</p>
</td>
<td>
<p>Author not valid!</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 1 - Create a Book Class</h3>
<p>Create a new empty class and name it <strong>Book</strong>. Set its access modifier to <strong>public </strong>so it can be instantiated from any project.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public class Book</p>
<p>{</p>
<p> //1. Add Fields</p>
<p> //2. Add Constructors</p>
<p> //3. Add Properties</p>
<p> //4. Add Methods</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 2 - Define the Properties of a Book</h3>
<p>Define the <strong>Title</strong>, <strong>Author</strong> and <strong>Price</strong> properties of a Book. Ensure that they can only be <strong>changed by the class itself or its descendants</strong> (pick the most appropriate access modifier).</p>
<h3>Step 3 - Define a Constructor</h3>
<p>Define a constructor that accepts <strong>author, title</strong> and <strong>price</strong> arguments.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public Book(string title, string author, decimal price)</p>
<p> {</p>
<p> this.title = title;</p>
<p> this.author = author;</p>
<p> this.price = price;</p>
<p> }</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 4 - Perform Validations</h3>
<p>Create a <strong>field</strong> for each property (<strong>Price</strong>, <strong>Title</strong> and <strong>Author</strong>) and <strong>perform validations</strong> for each one. The <strong>getter should return the corresponding field</strong> and the <strong>setter should validate</strong> the input data before setting it. Do this for every property.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public string Author</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> return this.author;</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> //TODO validate value</p>
<p> this.author = value;</p>
<p> }</p>
<p>}</p>
<p>public string Title</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> return this.title;</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> //TODO validate value</p>
<p> this.title = value;</p>
<p> }</p>
<p>}</p>
<p>public virtual decimal Price</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> return this.price;</p>
<p> }</p>
<p> set</p>
<p> {</p>
<p> //TODO validate value</p>
<p> this.price = value;</p>
<p> }</p>
<p>}</p>
&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Step 5 - Override ToString()</h3>
<p>We already mentioned that all classes in C# inherit the <strong>System.Object</strong> class and therefore have all its <strong>public</strong> members. Let's <strong>override</strong> (change) the <strong>ToString()</strong> method&rsquo;s behavior again acordingly our <strong>Book</strong> class&rsquo;s data.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public override string ToString()</p>
<p> {</p>
<p> var sb = new StringBuilder();</p>
<p> sb.Append("Type: ").AppendLine(this.GetType().Name)</p>
<p> .Append("Title: ").AppendLine(this.Title)</p>
<p> .Append("Author: ").AppendLine(this.Author)</p>
<p> .Append("Price: ").Append($"{this.Price:f1}")</p>
<p> .AppendLine();</p>
<p> return sb.ToString();</p>
<p> }</p>
</td>
</tr>
</tbody>
</table>
<p>And voila! If everything is correct, we can now create <strong>Book objects</strong> and display information about them.</p>
<h3>Step 6 &ndash; Create a GoldenEditionBook</h3>
<p>Create a <strong>GoldenEditionBook </strong>class that inherits <strong>Book</strong> and has the same constructor definition. However, do not copy the code from the Book class - <strong>reuse the Book class constructor</strong>.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public GoldenEditionBook(string author, string title, decimal price)</p>
<p> : base(author, title, price)</p>
<p>{</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>There is <strong>no need</strong> to rewrite the Price, Title and Author properties since <strong>GoldenEditionBook</strong> inherits <strong>Book </strong>and by default has them.</p>
<h3>Step 7 - Override the Price Property</h3>
<p>Golden edition books should return a <strong>30%</strong> higher <strong>price</strong> than the original price. In order for the getter to return a different value, we need to override the Price property.</p>
<p>Back to the <strong>GoldenEditionBook</strong> class, let's override the Price property and change the getter body</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td>
<p>public override decimal Price</p>
<p>{</p>
<p> get</p>
<p> {</p>
<p> return base.Price * 1.3;</p>
<p> }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3. Mankind</h2>
<p>Your task is to model an application. It is very simple. The mandatory models of our application are 3: Human, Worker and Student.</p>
<p>The parent class &ndash; Human should have <strong>first name</strong> and <strong>last name</strong>. Every student has a <strong>faculty number</strong>. Every worker has a <strong>week salary</strong> and <strong>work hours per day</strong>. It should be able to calculate the money he earns by hour. You can see the constraints below.</p>
<h3>Input</h3>
<p>On the first input line you will be given info about a single student - a name and faculty number.</p>
<p>On the second input line you will be given info about a single worker - first name, last name, salary and working hours.</p>
<h3>Output</h3>
<p>You should first print the info about the student following a single blank line and the info about the worker in the given formats:</p>
<ul>
<li>Print the student info in the following format:</li>
</ul>
<p> <strong>First Name: {student's first name}</strong></p>
<p><strong> Last Name: {student's last name}</strong></p>
<p><strong> Faculty number: {student's faculty number}</strong></p>
<p></p>
<ul>
<li>Print the worker info in the following format:</li>
</ul>
<p><strong> First Name: {worker's first name}</strong></p>
<p><strong>Last Name: {worker's second name}</strong></p>
<p><strong>Week Salary: {worker's salary}</strong></p>
<p><strong>Hours per day: {worker's working hours}</strong></p>
<p><strong>Salary per hour: {worker's salary per hour}</strong></p>
<p>Print exactly two digits after every double value's decimal separator (e.g. 10.00). Consider the workweek from Monday to Friday. A faculty number should be consisted only of digits and letters.</p>
<h3>Constraints</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Parameter</strong></p>
</td>
<td>
<p><strong>Constraint</strong></p>
</td>
<td>
<p><strong>Exception Message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Human first name</p>
</td>
<td>
<p>Should start with a capital letter</p>
</td>
<td>
<p>"Expected upper case letter! Argument: firstName"</p>
</td>
</tr>
<tr>
<td>
<p>Human first name</p>
</td>
<td>
<p>Should be more than 3 symbols</p>
</td>
<td>
<p>"Expected length at least 4 symbols! Argument: firstName"</p>
</td>
</tr>
<tr>
<td>
<p>Human last name</p>
</td>
<td>
<p>Should start with a capital letter</p>
</td>
<td>
<p>"Expected upper case letter! Argument: lastName"</p>
</td>
</tr>
<tr>
<td>
<p>Human last name</p>
</td>
<td>
<p>Should be more than 2 symbols</p>
</td>
<td>
<p>"Expected length at least 3 symbols! Argument: lastName "</p>
</td>
</tr>
<tr>
<td>
<p>Faculty number</p>
</td>
<td>
<p>Should be in range [5..10] symbols</p>
</td>
<td>
<p>"Invalid faculty number!"</p>
</td>
</tr>
<tr>
<td>
<p>Worker last name</p>
</td>
<td>
<p>Should be more than 3 symbols</p>
</td>
<td>
<p>"Expected length more than 3 symbols! Argument: lastName"</p>
</td>
</tr>
<tr>
<td>
<p>Week salary</p>
</td>
<td>
<p>Should be more than 10</p>
</td>
<td>
<p>"Expected value mismatch! Argument: weekSalary"</p>
</td>
</tr>
<tr>
<td>
<p>Working hours</p>
</td>
<td>
<p>Should be in the range [1..12]</p>
</td>
<td>
<p>"Expected value mismatch! Argument: workHoursPerDay"</p>
</td>
</tr>
</tbody>
</table>
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
<p>Ivan Ivanov 08</p>
<p>Pesho Kirov 1590 10</p>
</td>
<td>
<p>Invalid faculty number!</p>
</td>
</tr>
<tr>
<td>
<p>Stefo Mk321 0812111</p>
<p>Ivcho Ivancov 1590 10</p>
</td>
<td>
<p>First Name: Stefo</p>
<p>Last Name: Mk321</p>
<p>Faculty number: 0812111</p>
<p>First Name: Ivcho</p>
<p>Last Name: Ivancov</p>
<p>Week Salary: 1590.00</p>
<p>Hours per day: 10.00</p>
<p>Salary per hour: 31.80</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4. Online Radio Database</h2>
<p>Create an online radio station database. It should keep information about all added songs. On the first line you are going to get the number of songs you are going to try to add. On the next lines you will get the songs to be added in the format <strong>&lt;artist name&gt;;&lt;song name&gt;;&lt;minutes:seconds&gt;</strong>. To be valid, every song should have an artist name, a song name and length.</p>
<p>Design a custom exception hierarchy for invalid songs:</p>
<ul>
<li>InvalidSongException
<ul>
<li>InvalidArtistNameException</li>
<li>InvalidSongNameException</li>
<li>InvalidSongLengthException
<ul>
<li>InvalidSongMinutesException</li>
<li>InvalidSongSecondsException</li>
</ul>
</li>
</ul>
</li>
</ul>
<h3>Validation</h3>
<ul>
<li>Artist name should be between 3 and 20 symbols.</li>
<li>Song name should be between 3 and 30 symbols.</li>
<li>Song length should be between 0 second and 14 minutes and 59 seconds.</li>
<li>Song minutes should be between 0 and 14.</li>
<li>Song seconds should be between 0 and 59.</li>
</ul>
<h3>Exception Messages</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Exception</strong></p>
</td>
<td>
<p><strong>Message</strong></p>
</td>
</tr>
<tr>
<td>
<p>InvalidSongException</p>
</td>
<td>
<p>"Invalid song."</p>
</td>
</tr>
<tr>
<td>
<p>InvalidArtistNameException</p>
</td>
<td>
<p>"Artist name should be between 3 and 20 symbols."</p>
</td>
</tr>
<tr>
<td>
<p>InvalidSongNameException</p>
</td>
<td>
<p>"Song name should be between 3 and 30 symbols."</p>
</td>
</tr>
<tr>
<td>
<p>InvalidSongLengthException</p>
</td>
<td>
<p>"Invalid song length."</p>
</td>
</tr>
<tr>
<td>
<p>InvalidSongMinutesException</p>
</td>
<td>
<p>"Song minutes should be between 0 and 14."</p>
</td>
</tr>
<tr>
<td>
<p>InvalidSongSecondsException</p>
</td>
<td>
<p>"Song seconds should be between 0 and 59."</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Note</strong>: Check validity in the order artist name -&gt; song name -&gt; song length</p>
<h3>Output</h3>
<p>If the song is added, print "<strong>Song added.</strong>". If you <strong>can&rsquo;t add a song</strong>, print an <strong>appropriate exception message</strong>. On the last two lines print the <strong>number of songs added</strong> and the <strong>total length of the playlist</strong> in format <strong>{Playlist length: 0h 7m 47s}.</strong></p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Exception</strong></p>
</td>
<td>
<p><strong>Message</strong></p>
</td>
</tr>
<tr>
<td>
<p>3</p>
<p>ABBA;Mamma Mia;3:35</p>
<p>Nasko Mentata;Shopskata salata;4:123</p>
<p>Nasko Mentata;Shopskata salata;4:12</p>
</td>
<td>
<p>Song added.</p>
<p>Song seconds should be between 0 and 59.</p>
<p>Song added.</p>
<p>Songs added: 2</p>
<p>Playlist length: 0h 7m 47s</p>
</td>
</tr>
<tr>
<td>
<p>5</p>
<p>Nasko Mentata;Shopskata salata;14:59</p>
<p>Nasko Mentata;Shopskata salata;14:59</p>
<p>Nasko Mentata;Shopskata salata;14:59</p>
<p>Nasko Mentata;Shopskata salata;14:59</p>
<p>Nasko Mentata;Shopskata salata;0:5</p>
</td>
<td>
<p>Song added.</p>
<p>Song added.</p>
<p>Song added.</p>
<p>Song added.</p>
<p>Song added.</p>
<p>Songs added: 5</p>
<p>Playlist length: 1h 0m 1s</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5. *Mordor&rsquo;s Cruelty Plan</h2>
<p>Gandalf the Gray is a great wizard but he also loves to eat and the food makes him loose his capability of fighting the dark. The Mordor&rsquo;s orcs have asked you to design them a program which is calculating the Gandalf&rsquo;s mood. So they could predict the battles between them and try to beat The Gray Wizard. When Gandalf is hungry he gets angry and he could not fight well. Because the orcs have a spy, he has told them the foods that Gandalf is eating and the result on his mood after he has eaten some food. So here is the list:</p>
<ul>
<li><strong>Cram</strong>: 2 points of happiness;</li>
<li><strong>Lembas</strong>: 3 points of happiness;</li>
<li><strong>Apple</strong>: 1 point of happiness;</li>
<li><strong>Melon</strong>: 1 point of happiness;</li>
<li><strong>HoneyCake</strong>: 5 points of happiness;</li>
<li><strong>Mushrooms</strong>: -10 points of happiness;</li>
<li><strong>Everything else</strong>: -1 point of happiness;</li>
</ul>
<p>Gandalf moods are:</p>
<ul>
<li><strong>Angry </strong>- below -5 points of happiness;</li>
<li><strong>Sad</strong> - from -5 to 0 points of happiness;</li>
<li><strong>Happy </strong>- from 1 to 15 points of happiness;</li>
<li><strong>JavaScript</strong> - when happiness points are more than 15;</li>
</ul>
<p>The task is simple. Model an application which is calculating the happiness points, Gandalf has after eating all the food passed in the input. After you are done, print on the first line &ndash; total happiness points Gandalf had collected. On the second line &ndash; print the <strong>Mood&rsquo;s</strong> name which is corresponding to the points.</p>
<h3>Input</h3>
<p>The input comes from the console. It will hold a single line: all the Gandalf`s foods he has eaten separated by a whitespace.</p>
<h3>Output</h3>
<p>Print on the console Gandalf`s happiness points and the <strong>Mood&rsquo;s</strong> name which is corresponding to the points.</p>
<h3>Constraints</h3>
<ul>
<li>The characters in the input string will be no more than: <strong>1000.</strong></li>
<li>The food count would be in the range <strong>[1&hellip;100]</strong>.</li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Note</h3>
<p>Try to implement a factory pattern. You should have two factory classes &ndash; <strong>FoodFactory</strong> and <strong>MoodFactory</strong>. And their task is to produce objects (e.g. <strong>FoodFactory</strong>, produces &ndash; <strong>Food</strong> and the <strong>MoodFactory</strong> - <strong>Mood</strong>). Try to implement abstract classes (e.g. classes which can&rsquo;t be instantiated directly)</p>
<h3>Examples</h3>
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
<p>Cram melon honeyCake Cake</p>
</td>
<td>
<p>7</p>
<p>Happy</p>
</td>
</tr>
<tr>
<td>
<p>gosho, pesho, meze, Melon, HoneyCake@;</p>
</td>
<td>
<p>-5</p>
<p>Sad</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6. *Animals</h2>
<p>Create a hierarchy of <strong>Animals</strong>. Your task is simple: there should be a base class which all others derive from. Your program should have 3 different animals &ndash; <strong>Dog</strong>, <strong>Frog</strong> and <strong>Cat</strong>. Let&rsquo;s go deeper in the hierarchy and create two additional classes &ndash; <strong>Kitten</strong> and <strong>Tomcat</strong>. <strong>Kittens are female and Tomcats are male!</strong> We are ready now, but the task is not complete. Along with the animals, there should be also a class which classifies its derived classes as sound producible. You may guess that all animals are sound producible. The only one mandatory functionality of all sound producible objects is to <strong>ProduceSound()</strong>. For instance, the dog should bark.</p>
<p>Your task is to model the hierarchy and test its functionality. Create an animal of all kinds and make them produce sound.</p>
<p>On the console, you will be given some lines of code. Each two lines of code, represents animals and their names, age and gender. On the first line there will be the kind of animal, you should instantiate. And on the next line, you will be given the name, the age and the gender. Stop the process of gathering input, when the command <strong>&ldquo;Beast!&rdquo;</strong> is given.</p>
<h3>Output</h3>
<ul>
<li>On the console, print for each animal you&rsquo;ve instantiated, its info on two lines. On the first line, print:<br/> {<strong>Kind of animal</strong>}</li>
<li>On the second line print it&rsquo;s {<strong>name</strong>} {<strong>age</strong>} {<strong>gender</strong>}</li>
<li>On the third line print the sounds it produces: {<strong>ProduceSound()</strong>}</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Each <strong>Animal</strong> should have <strong>name</strong>, <strong>age</strong> and <strong>gender</strong></li>
<li><strong>All</strong> <strong>properties</strong>&rsquo; values should <strong>not be blank</strong> (e.g. name, age and so on&hellip;)</li>
<li>If you enter invalid input for one of the properties&rsquo; values, throw exception with message: <strong>&ldquo;Invalid input!&rdquo;</strong></li>
<li>Each animal should have a functionality to <strong>ProduceSound()</strong></li>
<li>Here is example of what each kind of animal should produce when, <strong>ProduceSound()</strong> is called</li>
<ul>
<li><strong>Dog: &ldquo;BauBau&rdquo;</strong></li>
<li><strong>Cat: &ldquo;MiauMiau&rdquo;</strong></li>
<li><strong>Frog: &ldquo;Frogggg&rdquo;</strong></li>
<li><strong>Kittens: &ldquo;Miau&rdquo;</strong></li>
<li><strong>Tomcat: &ldquo;Give me one million b***h"</strong></li>
</ul>
</ul>
<h3>Examples</h3>
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
<p>Cat</p>
<p>Macka 12 Female</p>
<p>Dog</p>
<p>Sharo 132 Male</p>
<p>Beast!</p>
</td>
<td>
<p>Cat</p>
<p>Macka 12 Female</p>
<p>MiauMiau</p>
<p>Dog</p>
<p>Sharo 132 Male</p>
<p>BauBau</p>
</td>
</tr>
<tr>
<td>
<p>Frog</p>
<p>Sashky 12 Male</p>
<p>Beast!</p>
</td>
<td>
<p>Frog</p>
<p>Sashky 12 Male</p>
<p>Frogggg</p>
</td>
</tr>
<tr>
<td>
<p>Frog</p>
<p>Invalidcho -2 Male</p>
<p>Frog</p>
<p>Validcho 2 Male</p>
<p>Beast!</p>
</td>
<td>
<p>Invalid input!</p>
<p>Frog</p>
<p>Validcho 2 Male</p>
<p>Frogggg</p>
</td>
</tr>
</tbody>
</table>