<h1>Lab: Generics</h1>
<h1>Part I: Generics</h1>
<h2>1. Box of T</h2>
<p>Create a class <strong>Box&lt;&gt;</strong> that can store anything.</p>
<p>It should have two public methods:</p>
<ul>
<li>void Add(element)</li>
<li>element Remove()</li>
<li>int Count { get; }</li>
</ul>
<p>Adding should add on top of its contents. Remove should get the topmost element.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="720">
<p>public static void Main(string[] args)</p>
<p>{</p>
<p> Box&lt;int&gt; box = new Box&lt;int&gt;();</p>
<p> box.Add(1);</p>
<p> box.Add(2);</p>
<p> box.Add(3);</p>
<p> Console.WriteLine(box.Remove());</p>
<p> box.Add(4);</p>
<p> box.Add(5);</p>
<p> Console.WriteLine(box.Remove());</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use the syntax Box&lt;T&gt; to create a generic class</p>
<h2>2. Generic Array Creator</h2>
<p>Create a class ArrayCreator with a method and a single overload to it:</p>
<ul>
<li>static T[] create(int length, T item)</li>
</ul>
<p>The method should return an array with the given length and every element should be set to the given default item.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="720">
<p>static void Main(string[] args)</p>
<p>{</p>
<p> string[] strings = ArrayCreator.Create(5, "Pesho");</p>
<p> int[] integers = ArrayCreator.Create(10, 33);</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h1>Part II: Generic Constaints</h1>
<h2>3. Generic Scale</h2>
<p>Create a class <strong>Scale&lt;T&gt;</strong> that holds two elements - left and right. The scale should receive the elements through its single constructor:</p>
<ul>
<li>Scale(T left, T right)</li>
</ul>
<p>The scale should have a single method:</p>
<ul>
<li>T getHeavier()</li>
</ul>
<p>The greater of the two elements is heavier. The method should return null if elements are equal.</p>
