<h1>Lab: Interfaces and Abstraction</h1>
<h2>1. Shapes</h2>
<p>Build hierarchy of interfaces and classes:</p>
<table>
<tbody>
<tr>
<td>
<p>&lt;&lt;inteface&gt;&gt;</p>
<p>&lt;&lt;Drawable&gt;&gt;</p>
</td>
</tr>
<tr>
<td>
<p><strong>+Draw()</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td width="115">
<p><strong>Circle</strong></p>
</td>
</tr>
<tr>
<td width="115">
<p><strong>-radius: Integer</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td width="116">
<p>Rectangle</p>
</td>
</tr>
<tr>
<td width="116">
<p><strong>-width: Integer</strong></p>
<p><strong>-height: Integer</strong></p>
</td>
</tr>
</tbody>
</table>
<p>You should be able to use the class like this:</p>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>var radius = int.Parse(Console.ReadLine());</p>
<p>IDrawable circle = new Circle(radius);</p>
<p>var width = int.Parse(Console.ReadLine());</p>
<p>var height = int.Parse(Console.ReadLine());</p>
<p>IDrawable rect = new Rectangle(width, height);</p>
<p>circle.Draw();</p>
rect.Draw();</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="157">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="60">
<p>3</p>
<p>5</p>
<p>4</p>
</td>
<td width="157">
<p>*******</p>
<p>&nbsp;** **</p>
<p>** **</p>
<p>* *</p>
<p>** **</p>
<p>&nbsp;** **</p>
<p>*******</p>
<p>****</p>
<p>* *</p>
<p>* *</p>
<p>* *</p>
<p>****</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>For circle drawing you can use this algorithm:</p>
<p>For rectangle drawing algorithm will be:</p>
<h2>2. Cars</h2>
<p>Build hierarchy of interfaces and classes:</p>
<table>
<tbody>
<tr>
<td width="126">
<p>&lt;&lt;ICar&gt;&gt;</p>
</td>
</tr>
<tr>
<td width="126">
<p><strong>+Model: string</strong></p>
<p><strong>+Color: string</strong></p>
<p><strong>+Start(): string</strong></p>
<p><strong>+Stop(): string</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td>
<p>&lt;&lt;IElectricCar&gt;&gt;</p>
</td>
</tr>
<tr>
<td>
<p><strong>+Battery: int</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td width="126">
<p>Audi</p>
</td>
</tr>
<tr>
<td width="126">
<p><strong>+ToString(): string</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td width="138">
<p>Tesla</p>
</td>
</tr>
<tr>
<td width="138">
<p><strong>+ToString(): string</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Your hierarchy have to be used with this code</p>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>Main.java</p>
</td>
</tr>
<tr>
<td width="695">
<p>ICar seat = new Seat("Leon", "Grey");</p>
<p>ICar tesla = new Tesla("Model 3", "Red", 2);</p>
<p>Console.WriteLine(seat.ToString());</p>
<p>Console.WriteLine(tesla.ToString());</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="181">
<p><strong>Input</strong></p>
</td>
<td width="406">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="406">
<p>Grey Seat Leon</p>
<p>Engine start</p>
<p>Breaaak!</p>
<p>Red Tesla Model 3 with 2 Batteries<br /> Engine start</p>
<p>Breaaak!</p>
</td>
</tr>
</tbody>
</table>
<p>The free online <a href="https://wordhtml.com/" target="_blank">Word editor</a> lets you compose any document in your web browser without downloading and installing any program.</p>