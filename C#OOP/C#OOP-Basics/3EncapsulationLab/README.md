
<h2>1. Sort Persons by Name and Age</h2>
<p>Create a class <strong>Person</strong>, which should have <strong>private</strong> fields for:</p>
<ul>
<li>firstName: string</li>
<li>lastName: string</li>
<li>age: int</li>
<li>ToString(): string - override</li>
</ul>
<p>You should be able to use the class like this:</p>
<table>
<tbody>
<tr>
<td>
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td>
<p>public static void Main()</p>
<p>{</p>
<p> var lines = int.Parse(Console.ReadLine());</p>
<p> var persons = new List&lt;Person&gt;();</p>
<p> for (int i = 0; i &lt; lines; i++)</p>
<p> {</p>
<p> var cmdArgs = Console.ReadLine().Split();</p>
<p> var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));</p>
<p> persons.Add(person);</p>
<p> }</p>
<p> persons.OrderBy(p =&gt; p.FirstName)</p>
<p> .ThenBy(p =&gt; p.Age)</p>
<p> .ToList()</p>
<p> .ForEach(p =&gt; Console.WriteLine(p.ToString()));</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
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
<p>5</p>
<p>Asen Ivanov 65</p>
<p>Boiko Borisov 57</p>
<p>Ventsislav Ivanov 27</p>
<p>Asen Harizanoov 44</p>
<p>Boiko Angelov 35</p>
</td>
<td>
<p>Asen Harizanoov is a 44 years old</p>
<p>Asen Ivanov is a 65 years old</p>
<p>Boiko Angelov is a 35 years old</p>
<p>Boiko Borisov is a 57 years old</p>
<p>Ventsislav Ivanov is a 27 years old</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>Create a <strong>new class</strong> and ensure <strong>proper naming</strong>. Define the <strong>private</strong> fields</p>
<p>Create a constructor for Person, which takes 3 parameters firstName, lastName, age.</p>
<p>Create properties for these fields, which are as strictly as possible</p>
<p>Override <strong>ToString()</strong> method:</p>
<h2>2. Salary Increase</h2>
<p><strong>Refactor project from last task.</strong></p>
<p>Read person with their names, age and salary. Read percent bonus to every person salary. Persons younger than 30 get half bonus. Expand <strong>Person</strong> from previous task. New <strong>fields</strong> and <strong>methods:</strong></p>
<ul>
<li>salary: double</li>
<li>IncreaseSalary(double bonus)</li>
</ul>
<p>You should be able to use the class like this:</p>
<table>
<tbody>
<tr>
<td>
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td>
<p>var lines = int.Parse(Console.ReadLine());</p>
<p>var persons = new List&lt;Person&gt;();</p>
<p>for (int i = 0; i &lt; lines; i++)</p>
<p>{</p>
<p> var cmdArgs = Console.ReadLine().Split();</p>
<p> var person = new Person(cmdArgs[0],</p>
<p> cmdArgs[1],</p>
<p> int.Parse(cmdArgs[2]),</p>
<p> double.Parse(cmdArgs[3]));</p>
<p> persons.Add(person);</p>
<p>}</p>
<p>var bonus = double.Parse(Console.ReadLine());</p>
persons.ForEach(p =&gt; Console.WriteLine(p.ToString()));</td>
</tr>
</tbody>
</table>
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
<p>5</p>
<p>Asen Ivanov 65 2200</p>
<p>Boiko Borisov 57 3333</p>
<p>Ventsislav Ivanov 27 600</p>
<p>Asen Harizanoov 44 666.66</p>
<p>Boiko Angelov 35 559.4</p>
<p>20</p>
</td>
<td>
<p>Asen Ivanov get 2640.00 leva</p>
<p>Boiko Borisov get 3999.60 leva</p>
<p>Ventsislav Ivanov get 660.00 leva</p>
<p>Asen Harizanoov get 799.99 leva</p>
<p>Boiko Angelov get 671.28 leva</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>Add new <strong>private</strong> field for <strong>salary</strong> and <strong>refactor constructor</strong>. Add new <strong>method</strong>, which will <strong>update</strong> salary with bonus</p>
<p>Refactor <strong>toString()</strong> method for this task.</p>
<h2>3. Validation Data</h2>
<p>Expand Person with proper validation for every field:</p>
<ul>
<li><strong>Names must be at least 3 symbols</strong></li>
<li><strong>Age must not be zero or negative</strong></li>
<li><strong>Salary can't be less than 460.0 </strong></li>
</ul>
<p>Print proper message to end user (look at example for messages).</p>
<p>Use ArgumentExeption with messages from example.</p>
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
<p>5</p>
<p>Asen Ivanov -6 2200</p>
<p>B Borisov 57 3333</p>
<p>Ventsislav Ivanov 27 600</p>
<p>Asen H 44 666.66</p>
<p>Boiko Angelov 35 300</p>
<p>20</p>
</td>
<td>
<p>Age cannot be zero or negative integer</p>
<p>First name cannot be less than 3 symbols</p>
<p>Last name cannot be less than 3 symbols</p>
<p>Salary cannot be less than 460 leva</p>
<p>Ventsislav Ivanov get 660.0 leva</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>Add validation to all setters in Person. Validation may look like this or something similar:</p>
<h2>4. First and Reserve Team</h2>
<p>Create a Team class. Add to this team all person you read. All person younger than 40 go in first team, others go in reverse team. At the end print first and reserve team sizes.</p>
<p>The class should have <strong>private fields</strong> for:</p>
<ul>
<li>name: string</li>
<li>firstTeam: List&lt;Person&gt;</li>
<li>reserveTeam: List&lt;Person&gt;</li>
</ul>
<p>The class should have <strong>constructors</strong>:</p>
<ul>
<li>Team(string name)</li>
</ul>
<p>The class should also have <strong>public methods</strong> for:</p>
<ul>
<li>AddPlayer(Person person): void</li>
<li>FirstTeam: IReadOnlyCollection</li>
<li>ReserveTeam: IReadOnlyCollection</li>
</ul>
<p>You should be able to use the class like this:</p>
<p>You should <strong>NOT </strong>be able to use the class like this:</p>
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
<p>5</p>
<p>Asen Ivanov 20 2200</p>
<p>Boiko Borisov 57 3333</p>
<p>Ventsislav Ivanov 27 600</p>
<p>Grigor Dimitrov 25 666.66</p>
<p>Boiko Angelov 35 555</p>
</td>
<td>
<p>First team have 4 players</p>
<p>Reserve team have 1 players</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>Add new class Team. Its fields and constructor look like:</p>
<p>Properties for FirstTeam and ReserveTeam have only getters:</p>
<p>There will be only one method, which add players to teams:</p>