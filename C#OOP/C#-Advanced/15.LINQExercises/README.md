
<h2>Problem 1. Students by Group</h2>
<p>Print all students from group number 2. Use LINQ. Order the students by <strong>FirstName</strong>.</p>
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
<p>Sara Mills 1</p>
<p>Andrew Gibson 2</p>
<p>Craig Ellis 1</p>
<p>Steven Cole 2</p>
<p>Andrew Carter 2</p>
<p>END</p>
</td>
<td>
<p>Andrew Gibson</p>
<p>Andrew Carter</p>
<p>Steven Cole</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2. Students by First and Last Name</h2>
<p>Using the same input as above print all students whose first name is before their last name lexicographically. Use LINQ. Print them in order of appearance.</p>
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
<p>Sara Mills</p>
<p>Andrew Gibson</p>
<p>Craig Ellis</p>
<p>Steven Cole</p>
<p>Andrew Carter</p>
<p>END</p>
</td>
<td>
<p>Andrew Gibson</p>
<p>Craig Ellis</p>
<p>Andrew Carter</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3. Students by Age</h2>
<p>Write a LINQ function that finds the first name and last name of all students with age between 18 and 24. The query should return the <strong>first name</strong>, <strong>last name</strong> and <strong>age</strong>. Print them in order of appearance.</p>
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
<p>Sara Mills 24</p>
<p>Andrew Gibson 21</p>
<p>Craig Ellis 19</p>
<p>Steven Cole 35</p>
<p>Andrew Carter 15</p>
<p>END</p>
</td>
<td>
<p>Sara Mills 24</p>
<p>Andrew Gibson 21</p>
<p>Craig Ellis 19</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4. Sort Students</h2>
<p>Using the lambda expressions with LINQ syntax sort the students first by <strong>last name</strong> in <strong>ascending</strong> order and then by <strong>first name</strong> in <strong>descending</strong> order.</p>
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
<p>Sara Gibson</p>
<p>Andrew Gibson</p>
<p>Craig Ellis</p>
<p>Steven Cole</p>
<p>Andrew Ellis</p>
<p>END</p>
</td>
<td>
<p>Steven Cole</p>
<p>Craig Ellis</p>
<p>Andrew Ellis</p>
<p>Sara Gibson</p>
<p>Andrew Gibson</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5. Filter Students by Email Domain</h2>
<p>Print all students that have email <strong>@gmail.com</strong> in the order of appearance. Use LINQ.</p>
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
<p>Sara Mills smills@gmail.com</p>
<p>Andrew Gibson agibson@abv.bg</p>
<p>Craig Ellis cellis@cs.edu.gov</p>
<p>Steven Cole themachine@abv.bg</p>
<p>Andrew Carter ac147@gmail.com</p>
<p>END</p>
</td>
<td>
<p>Sara Mills</p>
<p>Andrew Carter</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6. Filter Students by Phone</h2>
<p>Print all students with phones starting with Sofia&rsquo;s phone prefix (starting with <strong>02</strong> / <strong>+3592</strong>). Use LINQ.</p>
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
<p>Sara Mills 02435521</p>
<p>Andrew Gibson 0895223344</p>
<p>Craig Ellis +3592667710</p>
<p>Steven Cole 3242133312</p>
<p>Andrew Carter +001234532</p>
<p>END</p>
</td>
<td>
<p>Sara Mills</p>
<p>Craig Ellis</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7. Excellent Students</h2>
<p>Print all students that have <strong>at least one mark Excellent (6)</strong>. Use LINQ.</p>
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
<p>Sara Mills 6 6 6 5</p>
<p>Andrew Gibson 3 4 5 6</p>
<p>Craig Ellis 4 2 3 4</p>
<p>Steven Cole 5 6 5 5</p>
<p>Andrew Carter 5 3 4 2</p>
<p>END</p>
</td>
<td>
<p>Sara Mills</p>
<p>Andrew Gibson</p>
<p>Steven Cole</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8. Weak Students</h2>
<p>Write a similar program to the previous one to extract the <strong>students with at least 2 marks under or equal to "3"</strong>. Use LINQ.</p>
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
<p>Sara Mills 6 6 6 5</p>
<p>Andrew Gibson 3 4 5 6</p>
<p>Craig Ellis 4 2 3 4</p>
<p>Steven Cole 5 6 5 5</p>
<p>Andrew Carter 5 3 4 2</p>
<p>END</p>
</td>
<td>
<p>Craig Ellis</p>
<p>Andrew Carter</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9. Students Enrolled in 2014 or 2015</h2>
<p>Using LINQ, extract and print the <strong>Marks</strong> of the students that <strong>enrolled in 2014 or 2015</strong> (the students from 2014 have 14 as their 5-th and 6-th digit in the <strong>FacultyNumber</strong>, those from 2015 have 15).</p>
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
<p>554214 6 6 6 5</p>
<p>653215 3 4 5 6</p>
<p>156212 4 2 3 4</p>
<p>324413 5 6 5 5</p>
<p>134014 5 3 4 2</p>
<p>END</p>
</td>
<td>
<p>6 6 6 5</p>
<p>3 4 5 6</p>
<p>5 3 4 2</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10. Group by Group</h2>
<p>Create a new class named <strong>Person</strong>. It should consists of <strong>properties</strong> : <strong>name</strong> and <strong>group</strong> (String, Integer). Write a program that extracts all persons (students), <strong>grouped by</strong> <strong>GroupName</strong> and then prints them on the console. Print all group names along with the students in each group in acsending order. Use the <strong>group by</strong> query in LINQ. You will be given an input on the console.</p>
<p><strong>Output format</strong> : <strong>{group} - {name1</strong><strong>}, {name2}, {name3}, ...</strong></p>
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
<p>Ivaylo Petrov 10</p>
<p>Stanimir Svilianov 3</p>
<p>Indje Kromidov 3</p>
<p>Irina Balabanova 4</p>
<p>END</p>
</td>
<td>
<p>3 - Stanimir Svilianov, Indje Kromidov</p>
<p>4 - Irina Balabanova</p>
<p>10 - Ivaylo Petrov</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11. Students Joined to Specialties</h2>
<p>Create a new class <strong>StudentSpecialty</strong> that holds <strong>specialty name</strong> and <strong>faculty number</strong>. Create a <strong>Student </strong>class that holds <strong>student name </strong>and <strong>&nbsp;faculty number</strong>. Create a list of <strong>student specialties,</strong> where each specialty corresponds to a certain student (via the faculty number). You will recieve several specialties in the format :</p>
<p>&nbsp;{specialty name} {specialty name} {faculty number}</p>
<p>Until you reach "<strong>Students:</strong>" , you should add specialties to the collection. After you reach "Students:", you should<strong> start reading students</strong> in the format :</p>
<p> {faculty number} {student's first name} {student's second name}</p>
<p>You should add the students untill you recieve "END" command.</p>
<p>Print <strong>all student</strong> names <strong>alphabetically</strong> along with their <strong>faculty number</strong> and <strong>specialty name</strong>. Use the "<strong>join</strong>" LINQ operator.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Student Specialties</strong></p>
</td>
<td>
<p><strong>join</strong></p>
</td>
<td>
<p><strong>Students</strong></p>
</td>
<td>
<p><strong>&rarr;</strong></p>
</td>
<td>
<p><strong>Result (Joined Students with Specialties)</strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>SpecialtyName</strong></p>
</td>
<td>
<p><strong>FacNum</strong></p>
</td>
<td>
<p><strong>FacNum</strong></p>
</td>
<td>
<p><strong>Name</strong></p>
</td>
<td>
<p><strong>Name</strong></p>
</td>
<td>
<p><strong>FacNum</strong></p>
</td>
<td>
<p><strong>Specialty</strong></p>
</td>
</tr>
<tr>
<td>
<p>Web Developer</p>
</td>
<td>
<p>203314</p>
</td>
<td>
<p>215314</p>
</td>
<td>
<p>Milena Kirova</p>
</td>
<td>
<p>Asya Manova</p>
</td>
<td>
<p>203314</p>
</td>
<td>
<p>Web Developer</p>
</td>
</tr>
<tr>
<td>
<p>Web Developer</p>
</td>
<td>
<p>203114</p>
</td>
<td>
<p>203114</p>
</td>
<td>
<p>Stefan Popov</p>
</td>
<td>
<p>Asya Manova</p>
</td>
<td>
<p>203314</p>
</td>
<td>
<p>QA Engineer</p>
</td>
</tr>
<tr>
<td>
<p>PHP Developer</p>
</td>
<td>
<p>203814</p>
</td>
<td>
<p>203314</p>
</td>
<td>
<p>Asya Manova</p>
</td>
<td>
<p>Diana Petrova</p>
</td>
<td>
<p>203914</p>
</td>
<td>
<p>PHP Developer</p>
</td>
</tr>
<tr>
<td>
<p>PHP Developer</p>
</td>
<td>
<p>203914</p>
</td>
<td>
<p>203914</p>
</td>
<td>
<p>Diana Petrova</p>
</td>
<td>
<p>Diana Petrova</p>
</td>
<td>
<p>203914</p>
</td>
<td>
<p>Web Developer</p>
</td>
</tr>
<tr>
<td>
<p>QA Engineer</p>
</td>
<td>
<p>203314</p>
</td>
<td>
<p>203814</p>
</td>
<td>
<p>Ivan Ivanov</p>
</td>
<td>
<p>Ivan Ivanov</p>
</td>
<td>
<p>203814</p>
</td>
<td>
<p>PHP Developer</p>
</td>
</tr>
<tr>
<td>
<p>Web Developer</p>
</td>
<td>
<p>203914</p>
</td>
<td>
</td>
<td>
</td>
<td>
<p>Stefan Popov</p>
</td>
<td>
<p>203114</p>
</td>
<td>
<p>Web Developer</p>
</td>
</tr>
</tbody>
</table>
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
<p>Web Developer 203314</p>
<p>Web Developer 203114</p>
<p>PHP Developer 203814</p>
<p>PHP Developer 203914</p>
<p>QA Engineer 203314</p>
<p>Web Developer 203914</p>
<p>Students:</p>
<p>215314 Milena Kirova</p>
<p>203114 Stefan Popov</p>
<p>203314 Asya Manova</p>
<p>203914 Diana Petrova</p>
<p>203814 Ivan Ivanov</p>
<p>END</p>
</td>
<td>
<p>Asya Manova 203314 Web Developer</p>
<p>Asya Manova 203314 QA Engineer</p>
<p>Diana Petrova 203914 PHP Developer</p>
<p>Diana Petrova 203914 Web Developer</p>
<p>Ivan Ivanov 203814 PHP Developer</p>
<p>Stefan Popov 203114 Web Developer</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12. Little John</h2>
<p><strong>This problem is originally from the PHP Basics Exam (3 May 2015).</strong></p>
<p>As you probably know Little John is the right hand of the famous English hero - Robin Hood. A little known fact is that Little John can't handle Math very well. Before Robin Hood left to see Marry Ann, he asked John to <strong>count</strong> his hay of arrows and send him an <strong>encrypted</strong> message containing the arrow's count<strong>. </strong>The message should be encrypted since it can be intercepted by the Nottingham&rsquo;s evil Sheriff. Your task is to help Little John before it is too late (0.10 sec).</p>
<p>You are given<strong> 4 input</strong> strings (a hay). Those strings <strong>may or may not</strong> contain arrows. The arrows can be of different type as follows:</p>
<ul>
<li>"&gt;-----&gt;" &ndash; a small arrow</li>
<li>"&gt;&gt;-----&gt;" &ndash; a medium arrow</li>
<li>"&gt;&gt;&gt;-----&gt;&gt;" &ndash; a large arrow</li>
</ul>
<p>Note that the <strong>body</strong> of each arrow will always be <strong>5 dashes long</strong>. The <strong>difference</strong> between the arrows is in their <strong>tip</strong> and <strong>tail</strong>. The given 3 types are the only ones you should count, the <strong>rest should be ignored</strong> (Robin Hood does not like them). You should start searching the hays <strong>from the largest</strong> arrow type down <strong>to the smallest</strong> arrow type.</p>
<p>After you find the <strong>count </strong>of each arrow type you should <strong>concatenate</strong> them into one number in the order: small, medium, large arrow (even if the arrow count is 0). Then you <strong>convert</strong> the number in <strong>binary</strong> representation, <strong>reverse</strong> it and <strong>concatenate it again</strong> with the initial binary representation of the number. You <strong>convert</strong> the final binary number again <strong>back to decimal</strong>. This is the encrypted message you should send to Robin Hood.</p>
<h3>Input</h3>
<p>The input will be read from the console. The <strong>data</strong> will be received from 4 input <strong>lines containing strings</strong>.</p>
<h3>Output</h3>
<p>The output should be a decimal number, representing the encrypted count of arrows.</p>
<h3>Constraints</h3>
<ul>
<li>The input strings will contain any ASCII character.</li>
<li>Allowed working time: 0.1 seconds. Allowed memory: 16 MB.</li>
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
<p>&gt;&gt;&gt;-----&gt;&gt;abc&gt;&gt;&gt;-----&gt;&gt;</p>
<p>&gt;&gt;&gt;-----&gt;&gt;</p>
<p>&gt;-----&gt;s</p>
<p>&gt;&gt;-----&gt;</p>
</td>
<td>
<p>14535</p>
<p><em>The count is: 1 small, 1 medium and 3 large arrows</em></p>
<p><em>113(dec) = 1110001(bin) -&gt; reversed is 1000111(bin)</em></p>
<p><em>11100011000111(bin) = 14535(dec)</em></p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13. Office Stuff</h2>
<p>You are given a sequence of<strong> n</strong> companies in format |<strong>&lt;company&gt; - &lt;amount&gt; - &lt;product&gt;|</strong>. Example:</p>
<ul>
<li>|SoftUni - 600 - paper|</li>
<li>|Vivacom - 600 - pen|</li>
<li>|XS - 20 - chair|</li>
<li>|Vivacom - 200 - chair|</li>
<li>|SoftUni - 40 - chair|</li>
<li>|XS - 40 - chair|</li>
<li>|SoftUni - 1 - printer|</li>
</ul>
<p>Write a program that prints <strong>all companies</strong> in <strong>alphabetical </strong>order. For each company print the product type and their aggregated ordered amounts. Order the products by <strong>order of appearance</strong>. <strong>Print</strong> the result in the following format: <strong>&lt;company&gt;: &lt;product&gt;-&lt;amount&gt;, &lt;product&gt;-&lt;amount&gt;,&hellip;</strong> For the orders above the output should be:</p>
<ul>
<li>SoftUni: paper-600, chair-40, printer-1</li>
<li>Vivacom: pen-600, chair-200</li>
<li>XS: chair-60</li>
</ul>
<h3>Input</h3>
<p>The input comes from the console. At the first line the number <strong>n</strong> stays alone. At the next <strong>n</strong> lines, we have <strong>n</strong> orders in format |<strong>&lt;company&gt; - &lt;amount&gt; - &lt;product&gt;|</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print <strong>one line for each company</strong>. Company lines should be ordered in <strong>alphabetical</strong> <strong>order</strong>. For each company print the <strong>products</strong> ordered by this company in <strong>order</strong> of <strong>appearance</strong>, along with the total amount for the given product. Each line should be in format <strong>&lt;company&gt;: &lt;product&gt;-&lt;amount&gt;, &lt;product&gt;-&lt;amount&gt;, &hellip; &lt;product&gt;-&lt;amount&gt;</strong></p>
<h3>Constraints</h3>
<ul>
<li>The <strong>count</strong> of the lines <strong>n</strong> will be in the range [1 &hellip; 100].</li>
<li>The <strong>&lt;company&gt;</strong> and <strong>&lt;product&gt;</strong> will consist only of <strong>Latin characters</strong>, with length of [1 &hellip; 20].</li>
<li>The <strong>&lt;amount&gt;</strong> will be an integer number in the range [1 &hellip; 1000].</li>
<li>Time limit: 0.1 sec. Memory limit: 16 MB.</li>
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
<td>
</td>
<td>
<p><strong>Input</strong></p>
</td>
<td>
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td>
<p>7</p>
<p>|SoftUni - 600 - paper|</p>
<p>|Vivacom - 600 - pen|</p>
<p>|XS - 20 - chair|</p>
<p>|Vivacom - 200 - chair|</p>
<p>|SoftUni - 40 - chair|</p>
<p>|XS - 40 - chair|</p>
<p>|SoftUni - 1 - printer|</p>
</td>
<td>
<p>SoftUni: paper-600, chair-40, printer-1</p>
<p>Vivacom: pen-600, chair-200</p>
<p>XS: chair-60</p>
</td>
<td>
<p>5</p>
<p>|SoftUni - 200 - desk|</p>
<p>|SoftUni - 40 - PC|</p>
<p>|SoftUni - 200 - desk|</p>
<p>|SoftUni - 600 - paper|</p>
<p>|SoftUni - 600 - textbook|</p>
</td>
<td>
<p>SoftUni: desk-400, PC-40, paper-600, textbook-600</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14. Export to Excel</h2>
<p>Write a program to create an Excel file like the one below using an external library. Such as <a href="https://code.google.com/p/excellibrary/">excellibrary</a>, <a href="http://epplus.codeplex.com/">EPPlus</a>, etc for C#.</p>
<p>You are given as <strong>input</strong> course data about <strong>1000 students</strong> in a <strong>.txt</strong> file (tab-separated values). Each line in the input holds <strong>ID</strong>, <strong>first name</strong>, <strong>last name</strong>, <strong>email</strong>, <strong>gender</strong>, <strong>student type</strong>, <strong>exam result</strong>, <strong>homework sent</strong>, <strong>homework</strong> <strong>evaluated</strong>, <strong>teamwork score</strong>, <strong>attendances count</strong>, <strong>bonus</strong>.</p>
