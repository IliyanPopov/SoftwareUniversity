
<h2>1. Take Two</h2>
<p>Read a <strong>sequence of integers</strong>, given on a single line separated by a space.</p>
<p>Finds all <strong>unique</strong> elements, that are in range [<strong>10, 20] inclusive</strong> and print only <strong>the first 2 elements</strong>.</p>
<p>If there are <strong>fewer than 2 elements</strong>, print as much as there are. If there are <strong>no elements</strong>, print nothing.</p>
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
<p>15 2 15 14 12</p>
</td>
<td>
<p>15 14</p>
</td>
</tr>
<tr>
<td>
<p>17 -2 3</p>
</td>
<td>
<p>17</p>
</td>
</tr>
<tr>
<td>
<p>-2 3</p>
</td>
<td>
<p>(<em>no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read the input and parse the strings to a list of numbers:</li>
<li>Filter the numbers with Where() and lambda expression, take the unique ones with Distinct(), take only two from the collection with Take() and iterate over them while printing with ForEach():</li>
</ul>
<h2>2. Upper Strings</h2>
<p>Read a sequence of strings, given on a single line separated with a space.</p>
<p>Map each to upper case and print them, using LINQ.</p>
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
<p>Pesho Gosho Stefan</p>
</td>
<td>
<p>PESHO GOSHO STEFAN</p>
</td>
</tr>
<tr>
<td>
<p>Soft Uni Rocks</p>
</td>
<td>
<p>SOFT UNI ROCKS</p>
</td>
</tr>
<tr>
<td>
<p><em>(empty line)</em></p>
</td>
<td>
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read the input into a list of strings List&lt;string&gt;:</li>
<li>Use the Select() method to change every element of the list of words to uppercase. Iterate over the words and print the result:</li>
</ul>
<h2>3. First Name</h2>
<p>Read a <strong>sequence of </strong><strong>names</strong>, given on a single line, separated by a space.</p>
<p>Read a <strong>sequence of letters</strong>, given on the next line, separated by a space.</p>
<p>Find the <strong>names that start with one of the given letters</strong> and print the first of them (<strong>ordered lexicographically</strong>).</p>
<p>If there is <strong>no name</strong> that conforms to the requirement, <strong>print "No match"</strong>.</p>
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
<p>Rado Plamen Gosho</p>
<p>p r</p>
</td>
<td>
<p>Plamen</p>
</td>
</tr>
<tr>
<td>
<p>Plamen Gosho Rado</p>
<p>s c</p>
</td>
<td>
<p>No match</p>
</td>
</tr>
<tr>
<td>
<p>plamen gosho rado</p>
<p>r d e g</p>
</td>
<td>
<p>gosho</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>You can use a hash set to store letter, for efficient searching. Or just simply sort the letters but it will perform poorly</li>
<li>Make sure you are comparing letter with the same casing (lower or upper)</li>
<li>Use Where() and First() or FirstOrDefault()</li>
</ul>
<h2>4. Average of Doubles</h2>
<p>Read a <strong>sequence of double numbers</strong>, given on a single line, separated by a space.</p>
<p>Find the <strong>average of all elements</strong>, using LINQ.</p>
<p><strong>Round</strong> the output to the second digit after the decimal separator.</p>
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
<p>3 4 5 6</p>
</td>
<td>
<p>4.50</p>
</td>
</tr>
<tr>
<td>
<p>3.14 5.2 6.18</p>
</td>
<td>
<p>4.84</p>
</td>
</tr>
</tbody>
</table>
<h2>5. Min Even Number</h2>
<p>Read a sequence of numbers, given on a single line, separated by a space.</p>
<p>Find the smallest number of all even numbers, using LINQ.</p>
<p>If there are <strong>no numbers</strong> in the sequence, <strong>print "No match"</strong>.</p>
<p>Numbers in the output should be formatted with <strong>2 decimal</strong> <strong>places</strong> after floating point.</p>
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
<p>1 2 3 4 5 6</p>
</td>
<td>
<p>2.00</p>
</td>
</tr>
<tr>
<td>
<p>3.14 -2.00 1.33</p>
</td>
<td>
<p>-2.00</p>
</td>
</tr>
<tr>
<td>
<p><em>1 3</em></p>
</td>
<td>
<p>No match</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use select function to map the objects to double</li>
<li>Make sure to filter empty strings</li>
<li>Filter the even numbers</li>
<li>Get the smallest number using Min()</li>
</ul>
<h2>6. Find and Sum Integers</h2>
<p>Read a sequence of elements, given on a single line, separated by a space.</p>
<p>Filter all elements that are integers and calculate their sum, using LINQ.</p>
<p>If there are <strong>no numbers</strong> in the sequence, <strong>print "No match"</strong>.</p>
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
<p>Sum 3 and 4</p>
</td>
<td>
<p>7</p>
</td>
</tr>
<tr>
<td>
<p>Sum -3 and -4</p>
</td>
<td>
<p>-7</p>
</td>
</tr>
<tr>
<td>
<p>Sum three and four</p>
</td>
<td>
<p>No match</p>
</td>
</tr>
<tr>
<td>
<p>cat dog 1 catch</p>
</td>
<td>
<p>1</p>
</td>
</tr>
<tr>
<td>
<p>cat 1 dog -1 min</p>
</td>
<td>
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h2>7. Bounded Numbers</h2>
<p>On the first line, read two numbers, a <strong>lower </strong>and<strong> an upper bound</strong>, separated by a space. The bigger number is the upper bound and the smaller number is the lower bound.</p>
<p>On the second line, read a sequence of numbers, separated by a space.</p>
<p>Print all numbers, such that [lower bound] &le; n &le; [upper bound].</p>
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
<p>5 7</p>
<p>1 2 3 4 5 6 7 8 9</p>
</td>
<td>
<p>5 6 7</p>
</td>
</tr>
<tr>
<td>
<p>7 5</p>
<p>9 5 7 2 6 8</p>
</td>
<td>
<p>5 7 6</p>
</td>
</tr>
<tr>
<td>
<p>3 4</p>
<p>5 6 7 8</p>
</td>
<td>
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h2>8. Map Districts</h2>
<p>On the first line, you are given the population of districts in different cities, separated by a single space in the format "city:district population".</p>
<p>On the second line, you are given the minimum population for filtering of the towns. The <strong>population of a town</strong> is the <strong>sum of populations of all of its districts</strong>.</p>
<p><strong>Print</strong> all <strong>cities</strong> with population greater than a given number on the second line. <strong>Sort</strong> <strong>cities</strong> <strong>and districts</strong> by descending population and <strong>print</strong><strong> top 5 districts for a given city</strong>.</p>
<p>For a better understanding, see the examples below.</p>
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
<p>Pld:9 Pld:13 Has:7 Sof:20 Sof:10 Sof:15</p>
<p>10</p>
</td>
<td>
<p>Sof: 20 15 10</p>
<p>Pld: 13 9</p>
</td>
</tr>
<tr>
<td>
<p>Sof:10 Sof:12 Sof:15</p>
<p>10</p>
</td>
<td>
<p>Sof: 15 12 10</p>
</td>
</tr>
<tr>
<td>
<p>Sof:5</p>
<p>15</p>
</td>
<td>
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>