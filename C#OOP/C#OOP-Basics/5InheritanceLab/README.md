
<h1>Part I: Inheritance</h1>
<h2>1. Single Inheritance</h2>
<p>Create two classes named Animal and Dog.</p>
<p>Animal with a single public method Eat() that prints: <strong>"eating&hellip;"</strong></p>
<p>Dog with a single public method Bark() that prints: <strong>"barking&hellip;"</strong></p>
<p>Dog should inherit from Animal.</p>
<h3>Hints</h3>
<p>Use the <strong>: operator</strong> to build a hierarchy</p>
<h2>2. Multiple Inheritance</h2>
<p>Create three classes named Animal, Dog and Puppy.</p>
<p>Animal with a single public method Eat() that prints: <strong>"eating&hellip;"</strong></p>
<p>Dog with a single public method Bark() that prints: <strong>"barking&hellip;"</strong></p>
<p>Puppy with a single public method Weep() that prints: <strong>"weeping&hellip;"</strong></p>
<p>Dog should inherit from Animal. Puppy should inherit from Dog.</p>
<h2>3. Hierarchical Inheritance</h2>
<p>Create three classes named Animal, Dog and Cat.</p>
<p>Animal with a single public method Eat() that prints: <strong>"eating&hellip;"</strong></p>
<p>Dog with a single public method Bark() that prints: <strong>"barking&hellip;"</strong></p>
<p>Cat with a single public method Meow() that prints: <strong>"meowing&hellip;"</strong></p>
<p>Dog and Cat should inherit from Animal.</p>
<h1>Part II: Reusing Classes</h1>
<h2>4. Random List</h2>
<p>Create a RandomList class that has all the functionality of <strong>Array</strong>List.</p>
<p>Add additional function that <strong>returns</strong> and <strong>removes</strong> a random element from the list.</p>
<ul>
<li>Public method: RandomString(): string</li>
</ul>
<h2>5. Stack of Strings</h2>
<p>Create a class StackOfStrings which can store only strings and has the following functionality:</p>
<ul>
<li>Private field:<strong> data: List&lt;string&gt;</strong></li>
<li>Public method: Push(string item): void</li>
<li>Public method: Pop(): string</li>
<li>Public method: Peek(): string</li>
<li>Public method: IsEmpty(): bool</li>
</ul>
<p>Use composition/delegation in order to have a field in which to store the stack's data</p>