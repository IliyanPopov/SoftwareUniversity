
<h2>1. Simple Mapping</h2>
<p>Create class <strong>Employee</strong> that has properties <strong>first name</strong>, <strong>last name</strong>, <strong>salary</strong>, <strong>birthday</strong> and <strong>address</strong>. Create <strong>EmployeeDto</strong> class that will keep synthesized information about instances of Employee class (only <strong>first name</strong>, <strong>last name</strong> and <strong>salary</strong>). Create an <strong>instance of employee object</strong> and <strong>use the Automapper</strong> <strong>to map</strong> the <strong>newly created Employee</strong> to <strong>object of type EmployeeDto</strong>.</p>
<h2>2. Advanced Mapping</h2>
<p>Create class <strong>Employee</strong> with properties <strong>first name</strong>, <strong>last name</strong>, <strong>birthday</strong>, <strong>salary</strong>, information about whether the employee <strong>is on holiday</strong>, <strong>address</strong>, <strong>manager </strong>(another employee) and <strong>list of employees</strong> that he is in charge of.</p>
<p>Create <strong>2 types</strong> of data transfer objects &ndash; <strong>employee</strong> data transfer object and <strong>manager</strong> data transfer object.</p>
<ul>
<li><strong>EmployeeDto</strong> &ndash; first name, last name, salary</li>
<li><strong>ManagerDto</strong> &ndash; first name, last name, list of EmployeeDtos that he/she is in charge of and their count</li>
</ul>
<p><strong>Create a list</strong> of several <strong>employees</strong> then <strong>transform it to list of ManagerDtos</strong> and <strong>print it on the console</strong> in the format provided below:</p>
<p>{ManagerFirstName} {ManagerLastName} | Employees: {EmployeesCount}</p>
<p> - {EmployeeFirstName} {EmployeeLastName} {EmployeeSalary}</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="262">
<p><strong>Sample output</strong></p>
</td>
</tr>
<tr>
<td width="262">
<p>Steve Jobbsen | Employees: 2</p>
<p> - Stephen Bjorn 4300.00</p>
<p> - Kirilyc Lefi 4400.00</p>
<p>Carl Kormac | Employees: 14</p>
<p> - Jurgen Straus 1000.45</p>
<p> - Moni Kozinac 2030.99</p>
<p> - Kopp Spidok 2000.21</p>
<p> - &hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3. Projection</h2>
<p>Use Entity Framework to create and insert into a database <strong>list of employees</strong> that each employee has <strong>first name</strong>, <strong>last name</strong>, <strong>salary</strong>, <strong>birthday</strong>, <strong>address</strong> and <strong>manager </strong>(another employee). Transform to <strong>EmployeeDto</strong> (first name, last name, salary, manager&rsquo;s last name) those employees who are <strong>born before 1990</strong>. Order them <strong>by salary descending</strong> and <strong>print them on the console</strong>. (Tip: Use LINQ extension of Automapper.)</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="385">
<p><strong>Sample output</strong></p>
</td>
</tr>
<tr>
<td width="385">
<p>Steve Jobbsen 6000.20 &ndash; Manager: [no manager]</p>
<p>Kirilyc Lefi 4400.00&ndash; Manager: Jobbsen</p>
<p>Stephen Bjorn 4300.00 &ndash; Manager: Jobbsen</p>
</td>
</tr>
</tbody>
</table>
<h2>4. ** Explore Automapper</h2>
<p>Use your favorite search engine to find more information about the more advanced features of Automapper such as configuration validation, nested mappings, custom type converters, custom value resolvers, condition mapping etc.</p>
<p>Compose <a href="https://wordhtml.com/">Word documents and convert them to HTML</a> easily for free with this online tool. Please leave this message unchanged or subscribe now for a htmlg.com membership.</p>