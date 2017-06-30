<h1>Problem 1 &ndash; Cubic Artillery</h1>
<p>Cubic has taken charge of creating places where the, the weapons, armor and basically all the resources for the Cubic army, can be stored. He is creating massive bunkers which are capable of storing weapons. However every weapon has a different capacity, and the bunkers can only take up to a specified total capacity. That is why you have taken the task of supervising and managing the process.</p>
<p>You will be given <strong>n</strong> &ndash; an integer specifying the <strong>bunkers&rsquo; maximum capacity</strong>. Then you will be given input lines which will contain <strong>English alphabet letters</strong> and <strong>numbers</strong>, separated by a <strong>single space</strong>. The <strong>letters</strong> represent the <strong>bunkers</strong> and the <strong>numbers</strong> &ndash; the <strong>weapons</strong> and their <strong>capacity</strong>. Weapons must be <strong>stored</strong> in the bunkers. The <strong>first entered</strong> bunker is the <strong>first in which weapons are getting stored</strong>. Every weapon takes <strong>specific capacity</strong>, equal to its number.</p>
<p>When a bunker <strong>overflows</strong> (it <strong>cannot contain</strong> a given weapon due to lack of enough <strong>free capacity)</strong>, it passes the weapon to the <strong>next entered bunker</strong>. If the <strong>next bunker cannot contain</strong> the weapon, it passes it to the next-next, and so on till the <strong>last entered bunker</strong>. If there is <strong>no bunker</strong> that <strong>can hold</strong> the given weapon, <strong>ignore</strong> that weapon.</p>
<p>If there are <strong>no other bunkers</strong> besides the current one, you must check if current weapon can actually be contained (its <strong>needed capacity</strong> is <strong>less than</strong> the <strong>maximum capacity specified for the bunkers</strong>). If the weapon <strong>can be contained</strong>, you must <strong>make enough free capacity</strong> to hold that weapon, <strong>if there isn&rsquo;t already</strong>. That is done by <strong>removing weapons</strong>, starting from <strong>the first entered</strong>, till the last. If the weapon <strong>cannot be</strong> contained, <strong>ignore</strong> the weapon.</p>
<p>If a bunker overflows you must <strong>remove it</strong>, and print it on the console, along with all of the weapons it <strong>currently contains</strong>. If there are no weapons, just print &ldquo;<strong>Empty</strong>&rdquo;. After you&rsquo;ve removed that bunker, <strong>the next one</strong> becomes the <strong>first in the order</strong> &ndash; weapons will <strong>first be passed to it</strong>. If there are <strong>no other bunkers</strong>, you must <strong>NOT</strong> remove the one that overflowed.</p>
<p>The input sequence <strong>ends</strong> when you receive the command &ldquo;<strong>Bunker Revision</strong>&rdquo;.</p>
<h3>Input</h3>
<ul>
<li>The input will come in lines of letters and digits separated by a space.</li>
<li>The input ends when you receive the command &ldquo;<strong>Bunker Revision</strong>&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>For output, you must print a bunker, every time it overflows, after removing it.</li>
<li>The format is the following: <strong>{bunker}</strong> <strong>-&gt; {weapon1}, {weapossn2}&hellip;</strong></li>
<li>Where {bunker} is the letter that corresponds to that bunker, and the weapons are the numbers.</li>
<li>In case a bunker has no weapons, just print &ldquo;<strong>Empty</strong>&rdquo;.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The bunkers will only be English alphabet letters.</li>
<li>Each bunker&rsquo;s letter will always be unique.</li>
<li>The integer n will be In the range [0, 500].</li>
<li>The weapons will always be valid integers in the range [0, 500].</li>
<li>Allowed time/memory: 100ms/16MB.</li>
</ul>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>60</strong></p>
<p><strong>a 20 20 b 20 1</strong></p>
<p><strong>Bunker Revision</strong></p>
</td>
<td>
<p><strong>a -&gt; 20, 20, 20</strong></p>
</td>
</tr>
<tr>
<td>
<p><strong><strong>Comment</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> is the first entered bunker. Then we receive the weapons </strong><strong><strong>20</strong></strong><strong> and </strong><strong><strong>20</strong></strong><strong> which are passed to </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong>. Then we get the bunker </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong>.</strong> <strong>Then again we receive a weapon </strong><strong><strong>20</strong></strong><strong>. </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> still has enough capacity to hold the weapon so we store it there. Then we get the weapon </strong><strong><strong>1</strong></strong><strong>. </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> has capacity </strong><strong><strong>60/60</strong></strong><strong> &ndash; it overflows, so we pass the weapon to the next bunker. We find </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong> and we pass the weapon to </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong>. </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> is then removed and printed on the console. </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong> becomes the first bunker now.</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>50</strong></p>
<p><strong>b 10 15 20 30</strong></p>
<p><strong>c 100</strong></p>
<p><strong>a 65</strong></p>
<p><strong>Bunker Revision</strong></p>
</td>
<td>
<p><strong>b -&gt; 20, 30</strong></p>
<p><strong>c -&gt; Empty</strong></p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 2 &ndash; Cubic&rsquo;s Rube</h1>
<p>Several years ago, while Cubic was researching a new quantum technology, to design a weapon he can use against the Spherical Race, he discovered a magical sub-dimension which stands in the cross-road of all other dimensions. The dimension was completely empty but it had a perfect cubic form and Cubic liked that a lot, so he named it after himself &ndash; The Cubic&rsquo;s Rube.</p>
<p>Cubic noticed that the Rube gets frequently bombarded with particles which fill it, so he decided to research its volume to see how it reacts with particles. He asked for help from The Great Cubical Army, and, guess what? They sent you.</p>
<p>You will be given <strong>n</strong> &ndash; an integer specifying the 3 dimensions of The Rube. Only 1 integer is used for all 3 dimensions because The Rube is a perfect cube. After that you will start receiving lines containing 4 integers separated by a single space. The <strong>first three integers</strong> will represent a <strong>point </strong>in the 3D space, and <strong>the last integer</strong> will represent the particles. You must bombard that cell at that point, <strong>if there is such cell</strong>, with the <strong>given particles</strong>, adding to it &ndash; the value corresponding to the given 4<sup>th</sup> integer. Note that the properties specified above apply <strong>only</strong> for cells <strong>INSIDE </strong>The Rube. Also, there will be <strong>NO</strong> cell that is <strong>hit</strong> more than <strong>1 times</strong> by particles.</p>
<p>The input ends when you receive the command &ldquo;<strong>Analyze</strong>&rdquo;. Then you must print the sum of all the cells in The Rube, along with the number of cells which&rsquo;s value has not been changed. See the output section for more info.</p>
<h3>Input</h3>
<ul>
<li>The first line of input will hold an integer <strong>n</strong>.</li>
<li>After that you will begin receiving lines of input containing 4 integers separated by a space.</li>
<li>The input ends when you receive the command &ldquo;<strong>Analyze</strong>&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output consists of two lines.</li>
<li>On the first line print the sum of all the cells in the Rube.</li>
<li>On the second line print the amount of cells which&rsquo;s value has not been changed.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the matrix &ndash; n will be in the range [0, 25].</li>
<li>The integers from the input lines will be in the range [-2<sup>31 </sup>+ 1, 2<sup>31</sup> &ndash; 1].</li>
<li>Allowed time/memory: 100ms/16MB.</li>
</ul>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>4</strong></p>
<p><strong>2 2 2 2</strong></p>
<p><strong>Analyze</strong></p>
</td>
<td>
<p><strong>2</strong></p>
<p><strong>63</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>5</strong></p>
<p><strong>3 2 3 10</strong></p>
<p><strong>-1 -1 -1 0</strong></p>
<p><strong>1 4 0 20</strong></p>
<p><strong>2 2 2 5</strong></p>
<p><strong>Analyze</strong></p>
</td>
<td>
<p><strong>35</strong></p>
<p><strong>122</strong></p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 3 &ndash; Cubic&rsquo;s Messages</h1>
<p>Cubic is a veteran soldier from The Great Cubic Army. He has even participated in the Spherical Invasion as a Sergeant First Class. As a veteran, Cubic has some personal security issues &ndash; he communicates only trough text messages and sends them in a specific encrypted way, which you must decrypt in order to understand what he is saying.</p>
<p>You will begin receiving lines of input, which will consist of random ASCII characters &ndash; Cubic&rsquo;s encrypted lines. After each line you will receive a number &ndash; the length of the message he sent. Cubic might send false messages, in an act to confuse his &ldquo;enemies&rdquo;. You must capture only the messages that follow a certain format.</p>
<p>According to that format the <strong>valid</strong> messages:</p>
<ul>
<li>Consist of <strong>m </strong>characters, where <strong>m </strong>is the integer entered after each encrypted line.</li>
<li>Has only digits before itself in the encrypted line</li>
<li>Consists only of English alphabet letters</li>
<li>Has no English alphabet letters after itself in the encrypted line</li>
</ul>
<p><strong>Any</strong> message that <strong>does not follow</strong> the, specified above, rules, is <strong>invalid</strong>, and you must <strong>ignore it</strong>.</p>
<p>After you find <strong>all valid</strong> messages, you need to find their <strong>verification code</strong>. Every message has its own verification code, which Cubic gives in order to verify the message. <strong>Take all the digits before the message</strong> and all the digits <strong>after the message</strong> and consider them as <strong>indexes</strong>. If they are <strong>valid existing</strong> indexes <strong>in the message</strong>, <strong>form a string</strong> with those indexes <strong>taking characters from the message</strong>. If an index is <strong>nonexistent</strong>, put a <strong>space </strong>there. The string you form up is the verification code for the current message.</p>
<h3>Input</h3>
<ul>
<li>The input will always come in the form of 2 lines, except when it is the line terminating the input sequence.</li>
<li>The first input line will contain random ASCII characters, and the second &ndash; a number.</li>
<li>When the line &ldquo;<strong>Over!</strong>&rdquo; is entered, the input sequence ends.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. You must print all the valid messages you&rsquo;ve found, each on a new line, and their verification codes, if they have such.</li>
<li>The format of output is &ldquo;<strong>{message} == {verificationCode}</strong>&rdquo;.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input lines can consist of <strong>ANY ASCII</strong></li>
<li>There will be <strong>NO </strong>such cases as an encrypted message without a number before it.</li>
<li>The number will be a valid integer in the range [0, 100].</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>1234test4321</strong></p>
<p><strong>4</strong></p>
<p><strong>0000oooo0000</strong></p>
<p><strong>4</strong></p>
<p><strong>Over!</strong></p>
</td>
<td>
<p><strong>test == est tse</strong></p>
<p><strong>oooo == oooooooo</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>1wat!</strong></p>
<p><strong>3</strong></p>
<p><strong>#23asd33</strong></p>
<p><strong>3</strong></p>
<p><strong>333asd3a</strong></p>
<p><strong>3</strong></p>
<p><strong>100dun2</strong></p>
<p><strong>3</strong></p>
<p><strong>Over!</strong></p>
</td>
<td>
<p><strong>wat == a</strong></p>
<p><strong>dun == uddn</strong></p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 4 &ndash; Cubic Assault</h1>
<p>After countless of hours of preparation &ndash; artillery storage, quantum research, and planning trough encoded messages, time has finally come for a war with the Spherical Race. Cubic is on the front lines devastating the enemy forces. Someone, however, must give statistics to Cubic about the count of enemies on each front. You are best for this job.</p>
<p>You will be given as input lines containing, a region, the type of the soldiers at that region and their amount. You must <strong>store statistics</strong> about the <strong>amount of meteors</strong> Cubic needs to defeat in <strong>every region</strong>. Note that if at one region 1 000 000 Green Meteors gather, they <strong>combine</strong> into 1 Red Meteor. By the same logic, 1 000 000 Red Meteors get <strong>combined </strong>into 1 Black Meteor. Note also, that you might receive <strong>several input lines</strong> with information about <strong>1 region</strong>. In that case just <strong>update that region&rsquo;s statistics</strong>. Multiple values to one type <strong>increase</strong> that type&rsquo;s value each time.</p>
<p>The input data will come in the following format <strong>{regionName} -&gt; {meteorType} -&gt; {count}. </strong></p>
<p>When you receive the command &ldquo;<strong>Count em all</strong>&rdquo;, you must <strong>end</strong> the input sequence. You must print all the regions ordered by the <strong>amount of Black Meteors</strong> &ndash; descending, then by the <strong>length of their names</strong> &ndash; ascending, and lastly <strong>alphabetically</strong>. For every region you must print how many green, red and black meteors there. Order the printing of the types by <strong>amount of defeated units</strong> in them &ndash; descending, and if two are with the same value, order them <strong>alphabetically</strong>.</p>
<h3>Input</h3>
<ul>
<li>As input you will receive random amount of input lines containing information about Cubic&rsquo;s statistics.</li>
<li>The input ends when you receive the command &ldquo;Count em all&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. You must print each region and the statistics about the 3 types of meteors in it.</li>
<li>The format of output is :</li>
</ul>
<p> <strong>{regionName} </strong></p>
<p><strong> -&gt; {firstType} : {firstTypeCount} </strong></p>
<p><strong> -&gt; {secondType} : {secondTypeCount} </strong></p>
<p><strong> -&gt; {thirdType} : {thirdTypeCount}</strong></p>
<ul>
<li>The order of each type depends on its count as specified above. All data must be ordered correctly.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input numbers will be valid integers in the range [-2<sup>31</sup> + 1, 2<sup>31</sup> &ndash; 1].</li>
<li>The input will always be in the format specified above. There is no need to check it explicitly.</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>Cubica -&gt; Black -&gt; 1</strong></p>
<p><strong>Cubica -&gt; Red -&gt; 1000</strong></p>
<p><strong>Spherica -&gt; Green -&gt; 1000000</strong></p>
<p><strong>Count em all</strong></p>
</td>
<td>
<p><strong>Cubica</strong></p>
<p><strong>-&gt; Red : 1000</strong></p>
<p><strong>-&gt; Black : 1</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>Spherica</strong></p>
<p><strong>-&gt; Red : 1</strong></p>
<p><strong>-&gt; Black : 0</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td>
<p><strong><strong>Input</strong></strong></p>
</td>
<td>
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>Triangula Canyon -&gt; Black -&gt; 100</strong></p>
<p><strong>Diagonalica -&gt; Red -&gt; 999999</strong></p>
<p><strong>Ellipsetica -&gt; Red -&gt; 100000000</strong></p>
<p><strong>Diagonalica -&gt; Black -&gt; 99</strong></p>
<p><strong>Diagonalica -&gt; Green -&gt; 1000000</strong></p>
<p><strong>Count em all</strong></p>
</td>
<td>
<p><strong>Diagonalica</strong></p>
<p><strong>-&gt; Black : 100</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>-&gt; Red : 0</strong></p>
<p><strong>Ellipsetica</strong></p>
<p><strong>-&gt; Black : 100</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>-&gt; Red : 0</strong></p>
<p><strong>Triangula Canyon</strong></p>
<p><strong>-&gt; Black : 100</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>-&gt; Red : 0</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Rubik's Cubes make a perfect gift for any occasion. Learn more about this amazing puzzle <a href="https://ruwix.com/">here</a>.</p>