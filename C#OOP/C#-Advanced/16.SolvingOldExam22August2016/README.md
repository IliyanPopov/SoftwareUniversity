<h1>Problem 1 &ndash; Second Nature</h1>
<p>Some unknown universal power has given you the idea to create a software program, which oversees the blooming of the legendary Edel flowers. The Edel flowers blooms when their Weiss dust is completely gone. Weiss dust is reduced by watering an Edel flower.</p>
<p>You will be given a <strong>sequence of integers</strong> &ndash; each indicating the Weiss dust in <strong>each flower</strong>. After that you will be given <strong>another sequence of integers</strong>. This time, each indicating &ndash; a bucket and the water in it.</p>
<p>Watering is done by picking <strong>exactly one</strong> bucket at a time. You must start picking from <strong>the last received bucket</strong> and start watering from <strong>the first entered flower</strong>. If the current bucket has <strong>N </strong>water, you <strong>give</strong> the <strong>first entered flower</strong> <strong>N</strong> water, <strong>reducing</strong> its Weiss dust by <strong>N</strong> &ndash; therefore <strong>reducing</strong> its integer value by <strong>N</strong>.</p>
<p>When an Edel flower&rsquo;s <strong>integer value</strong> reaches <strong>0 or less</strong>, it blooms and <strong>gets removed</strong>. It is <strong>possible</strong> that the current flower&rsquo;s value is <strong>greater</strong> than the current bucket&rsquo;s value. <strong>In that case</strong> you <strong>pick buckets</strong> <strong>until</strong> you reduce its integer value to <strong>0 or less</strong>. If a bucket&rsquo;s value is <strong>greater</strong> than the flower&rsquo;s <strong>current</strong> value, you water the flower, and <strong>add the remaining water</strong> to the <strong>next bucket in order</strong>. In case there is no such, keep the remaining water in the same bucket.</p>
<p>If the <strong>current bucket</strong>&rsquo;s value is <strong>equal</strong> to the <strong>current flower</strong>&rsquo;s <strong>current value</strong>, the flower develops a <strong>second nature</strong>. <br/> By doing that, the flower becomes eternally bloomed &ndash; it cannot be affected by water. The bucket however <strong>gets removed</strong>.<br/> The watering is <strong>continued</strong> with the <strong>next flower in order</strong>.</p>
<p>If you <strong>have managed</strong> to <strong>water all the flowers</strong>, print the <strong>remaining water buckets</strong>, from the <strong>last entered</strong> <strong>&ndash; to the first</strong>. <br/> If you <strong>haven&rsquo;t managed</strong> to water <strong>all the flowers</strong> with the given water, you must print the <strong>remaining</strong> <strong>flowers</strong>, by <strong>order of entrance</strong> &ndash; from the <strong>first entered &ndash; to the last</strong>. <br/> In both cases, you must also print the <strong>second nature</strong> flowers, if there are such, by <strong>order of their appearance</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first line</strong> of input you will receive the integers, representing the <strong>flowers</strong>, and the Weiss dust in them &ndash; each with each, <strong>separated</strong> by a <strong>single space</strong>.</li>
<li>On the <strong>second line </strong>of input you will receive the integers, representing the <strong>buckets with water</strong> &ndash; each with each, <strong>separated</strong> by a <strong>single space</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first line of output you must print the remaining water buckets, or the remaining flowers, depending on the case you are in. Just <strong>keep</strong> the <strong>orders of printing</strong> exactly as <strong>specified</strong>.</li>
<li>On the second line of output you must print the second nature flowers, by the order of their appearance.<br/> If there are no second nature flowers, just print <strong>&ldquo;None&rdquo; </strong>on the second line of output.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>All of the given numbers will be valid integers in the range [1, 500].</li>
<li>It is safe to assume that there will be <strong>NO</strong> case in which the water is <strong>exactly as much</strong> as the flowers&rsquo; values, so that at the end there are no flowers and no water.</li>
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
<td>
<p><strong><strong>Comment</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>4 2 10 5</strong></p>
<p><strong>3 5 5 11 6</strong></p>
</td>
<td>
<p><strong>9</strong></p>
<p><strong>None</strong></p>
</td>
<td>
<p><strong>We take the first entered flower, and the last entered bucket, as we are told by the description.</strong></p>
<p></p>
<p><strong><strong>6 &ndash; 4 = 2 </strong></strong><strong>&ndash; we have </strong><strong><strong>2</strong></strong><strong> more so we add it to the next bucket in order and it becomes </strong><strong><strong>13</strong></strong></p>
<p></p>
<p><strong><strong>13 &ndash; 2 = 11</strong></strong><strong> - </strong>again more, so we add it to 5 and it becomes 16</p>
<p><strong><strong>16 &ndash; 10 = 6 </strong></strong><strong>&ndash; we add it to the next in order </strong></p>
<p></p>
<p><strong><strong>11 &ndash; 5 = 6</strong></strong><strong> &ndash; adds its value to the last bucket</strong></p>
<p><strong></strong></p>
<p><strong>We&rsquo;ve managed to water all the flowers so we print what we have, remaining, from the water and the second nature flowers we found, in our case - </strong><strong><strong>None</strong></strong></p>
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
<p><strong>1 5 28 11 4</strong></p>
<p><strong>3 8 1 9 30 4 5</strong></p>
</td>
<td>
<p><strong>8 3</strong></p>
<p><strong>4</strong></p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 2 &ndash;Nature&rsquo;s Prophet</h1>
<p>Furion loves nature and that is why he has a beautiful square garden. He wants to plant it with magical flowers, so it can be even more beautiful. No one knows why, but he actually needs a software program to do that, that is why you&rsquo;ll write one for him.</p>
<p>You will be given <strong>N</strong> and <strong>M</strong> &ndash; <strong>integers</strong>, indicating the <strong>dimensions </strong>of the <strong>square garden</strong>. The garden is <strong>empty at the beginning</strong> &ndash; it has no flowers. Furion wants every place for a flower to be presented with a <strong>zero (0)</strong> when it is <strong>empty</strong>. After you&rsquo;ve finished creating the garden, you will start receiving two integers &ndash; <strong>Row</strong> and <strong>Column</strong>, <strong>separated</strong> by a <strong>single space</strong> &ndash; which represent the <strong>position</strong> at which Furion <strong>currently plants a flower</strong>. This happens until you receive the command <strong>&ldquo;Bloom Bloom Plow&rdquo;</strong>. When you receive that input, <strong>all planted flowers</strong> should <strong>bloom</strong>.</p>
<p>The flowers are <strong>magical</strong>. When a flower <strong>blooms</strong> it instantly <strong>blooms flowers</strong> to <strong>all places</strong> to its <strong>left</strong>, <strong>right</strong>, <strong>up</strong>, and <strong>down</strong>, <strong>increasing</strong> their <strong>value</strong> with <strong>1</strong>. Flowers can bloom <strong>multiple times</strong>, and <strong>each time</strong> the flower blooms &ndash; it becomes more and more beautiful, which means its <strong>value increases</strong>. The blooming of flowers is done from the <strong>top-left</strong> corner of the garden to the <strong>bottom-right</strong> one.</p>
<p><strong>Note</strong>: If one flower blooms and affects several places, and then another flower blooms and affects one of the <strong>first flower&rsquo;s affected places</strong>, it does <strong>NOT</strong> override their values with 1 again. Instead it blooms them one more time &ndash; <strong>increasing</strong> their value with <strong>1</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first line of input you will receive two integers, separated by a single space &ndash; indicating the dimensions of the garden.</li>
<li>On the next several lines you will be receiving two integers separated by a single space &ndash; indicating the position at which Furion currently plants a flower.</li>
<li>When you receive the input line <strong>&ldquo;Bloom Bloom Plow&rdquo; </strong>the input sequence should end.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. Print the whole garden &ndash; each row of it on a new line, and each column &ndash; separated by a <strong>single space</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the matrix (<strong>N</strong> and <strong>M</strong>) will be integers in the range [3, 500].</li>
<li>The integers received as position of planting a flower will <strong>always</strong> be inside the matrix.</li>
<li>The amount of input commands will be in the range [0, <strong>N * M</strong>].</li>
<li>Flowers will <strong>always</strong> be planted on <strong>empty</strong></li>
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
<td>
<p><strong><strong>Comment</strong></strong></p>
</td>
</tr>
<tr>
<td>
<p><strong>5 5</strong></p>
<p><strong>1 1</strong></p>
<p><strong>3 3</strong></p>
<p><strong>Bloom Bloom Plow</strong></p>
</td>
<td>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 1 1 2 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 2 1 1 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
</td>
<td>
<p><strong>The garden has 5 rows and 5 columns.</strong></p>
<p><strong>They are all </strong><strong><strong>0</strong></strong><strong> at the beginning.</strong></p>
<p><strong>The planted flowers are at [1, 1] and [3, 3].</strong></p>
<p><strong>The affected places are:</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>We receive the blooming command and we bloom the flowers from top-left to bottom-right corner of the garden.</strong></p>
<p><strong>First we reach the first flower, and we bloom it, increasing all affected fields&rsquo; value with 1.</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>1 1 1 1 1</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>Then we bloom the second flower, and we increase all affected fields&rsquo; (even those from the first flower) value with 1.</strong></p>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 1 1 </strong><strong>2</strong><strong> 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 2 1 1 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
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
<p><strong>4 4</strong></p>
<p><strong>0 0</strong></p>
<p><strong>3 3</strong></p>
<p><strong>1 1</strong></p>
<p><strong>2 2</strong></p>
<p><strong>Bloom Bloom Plow</strong></p>
</td>
<td>
<p><strong>1 </strong><strong>2 </strong><strong>2 </strong><strong>2</strong></p>
<p><strong>2 1 2 2</strong></p>
<p><strong>2 2 1 2</strong></p>
<p><strong>2 2 2 1</strong></p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 3 &ndash; NMS</h1>
<p>Furion has created the NMS &ndash; Natural Messaging Service, for all the flowers. They communicate through special messages which only they understand. You want to know what the flowers are saying to each other, that&rsquo;s why you&rsquo;ve decided to create a software program which translates the messages.</p>
<p>You will be given several input lines of random, <strong>upper case</strong> and <strong>lower case, English alphabet letters</strong>. You need to find <strong>all words</strong> in that message. A word in the Natural language is an <strong>increasing sequence of letters</strong>.</p>
<p>Тhe message <strong>&ldquo;abc&rdquo;</strong> is a <strong>single</strong> word, because <strong>&ldquo;b&rdquo;&gt;&ldquo;a&rdquo; </strong>and <strong>&ldquo;c&rdquo;&gt;&ldquo;b&rdquo;</strong>, therefore it <strong>IS</strong> an increasing sequence and it is counted as a word. The message <strong>&ldquo;abca&rdquo;</strong> consists of <strong>2</strong> words &ndash; <strong>&ldquo;abc&rdquo;</strong> and <strong>&ldquo;a&rdquo;</strong> because <strong>&ldquo;a&rdquo;&lt;&ldquo;c&rdquo; </strong>and it <strong>breaks </strong>the increasing sequence and <strong>begins a new one.</strong><strong> <br/> Equal letters</strong> do <strong>NOT</strong> break the subsequence. The <strong>comparison</strong> is <strong>case-insensitive</strong>.</p>
<p>The input <strong>ends</strong> when you receive the command <strong>&ldquo;---NMS SEND---&ldquo;</strong>. After it you will receive a <strong>specified delimiter</strong>. You need to <strong>break the whole message</strong> into <strong>words</strong> and print them as a text, each separated with <strong>the given delimiter</strong>. The delimiter can be a line of <strong>random ASCII characters</strong> with <strong>random length</strong>.</p>
<p>NOTE: The <strong>comparison</strong> is <strong>case-insensitive</strong>, as specified above, therefore <strong>&ldquo;B&rdquo;&gt;&ldquo;a&rdquo;</strong>, and <strong>&ldquo;A&rdquo;=&rdquo;a&rdquo;</strong>.</p>
<h3>Input</h3>
<ul>
<li>You will be receiving lines of input containing random English alphabet letters, until you receive the line &ndash; <br/> <strong>&ldquo;---NMS SEND---&ldquo;</strong>.</li>
<li>After you receive the ending command, you will receive the delimiter on the next line, as <strong>the last line of input</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you need to print all the words you&rsquo;ve found, <strong>separated by the given delimiter</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>All of the input lines, except the input-terminating one and the delimiter, will consist only of uppercase and lowercase English alphabet letters.</li>
<li>The maximum lines of input you can receive is 1000.</li>
<li>The delimiter will be a string, which can consist of any ASCII character.</li>
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
<p><strong>Foxtrot</strong></p>
<p><strong>Uniform</strong></p>
<p><strong>Charlie<br/> Kilo</strong></p>
<p><strong>---NMS SEND---</strong></p>
<p><strong>(space)</strong></p>
</td>
<td>
<p><strong>Fox t r ot</strong></p>
<p><strong>U n i for m Ch ar l i eK ilo</strong></p>
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
<p><strong>abcdefghijklmnopqrstuvwxyz</strong></p>
<p><strong>ABCDEFGHIJKLMNOPQRSTUVWXYZ</strong></p>
<p><strong>---</strong><strong>NMS </strong><strong>SEND---</strong></p>
<p><strong>---</strong><strong>NMS </strong><strong>SEND---</strong></p>
</td>
<td>
<p><strong>abcdefghijklmnopqrstuvwxyz---NMS SEND---ABCDEFGHIJKLMNOPQRSTUVWXYZ</strong></p>
</td>
</tr>
<tr>
<td>
<p></p>
</td>
<td>
<p></p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 4 &ndash; Ashes of Roses</h1>
<p>The time has come for the great Rosen Flame Festival. Million Roses must be prepared for the reincarnation of the Icarus, The Great Phoenix God. Different regions that participate in the Festival will grow roses for Icarus to burn, upon resurrecting. You are asked to create a software program which oversees that process.</p>
<p>Regions can <strong>grow</strong> a <strong>specific amount</strong> of <strong>specifically colored</strong> roses.</p>
<p>The <strong>valid input</strong> will come in the following format:</p>
<ul>
<li><strong>Grow &lt;{regionName}&gt; &lt;{colorName}&gt; {roseAmount}</strong> &ndash; grows the given amount of the given color roses in the given region.</li>
</ul>
<p>The <strong>region names</strong> must always <strong>start</strong> with a <strong>capital</strong> <strong>English alphabet letter</strong>, and <strong>consist </strong>only of <strong>lowercase</strong> letters. The <strong>color&rsquo;s name</strong> must consist only of <strong>English alphabet letters</strong> and <strong>digits</strong>. The <strong>rose amount</strong> must be an <strong>integer</strong>. <br/> Any input that <strong>does NOT</strong> <strong>follow </strong>the, specified above, rules is to be treated as <strong>invalid</strong>, and must be <strong>ignored</strong>.</p>
<p>If you receive an input with <strong>existent</strong> region, you should <strong>add</strong> the new color and roses to it. If even <strong>the</strong> <strong>color exists, increase</strong> their <strong>current value</strong> with the<strong> given one</strong>.</p>
<p>The input ends when you receive the command <strong>&ldquo;Icarus, Ignite!&rdquo;</strong>. That means that the Festival is ready to begin, and the roses are all ready and set. You must <strong>print all the regions</strong> and their roses, but in a <strong>specific order</strong>.</p>
<p>Regions must be <strong>ordered by amount</strong> of roses they have, in <strong>descending order</strong>, as prime criteria and in <strong>alphabetical order</strong>, as secondary criteria. Their colors must be <strong>ordered by amount of roses</strong>, in <strong>ascending order</strong>, as prime criteria and in <strong>alphabetical order</strong>, as secondary criteria.</p>
<h3>Input</h3>
<ul>
<li>The input will consist only of the commands specified above.</li>
<li>The input ends when you receive the command <strong>&ldquo;Icarus, Ignite!&rdquo;</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print information about each region and its roses in the specified order.</li>
<li>The format of output is:
<ul>
<li><strong>&ldquo;{region1Name}</strong></li>
<li><strong>*--{color1Name} | {roseCount}</strong></li>
<li><strong>*--{color2Name} | {roseCount}</strong></li>
<li><strong>&hellip;&rdquo;</strong></li>
</ul>
</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input lines can consist of any ASCII character. You must find only the valid ones.</li>
<li>The input count of roses will be a valid integer in range [0, 2<sup>31 </sup>&ndash; 1].</li>
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
<p><strong>Grow &lt;Dorne&gt; &lt;Indigo&gt; 2000</strong></p>
<p><strong>Grow &lt;Dorne&gt; &lt;Purple&gt; 5000</strong></p>
<p><strong>Grow &lt;Dorne&gt; &lt;Purple&gt; 1000</strong></p>
<p><strong>Grow &lt;Ironislands&gt; &lt;Blue&gt; 20000</strong></p>
<p><strong>Grow &lt;North&gt; &lt;Scarlet&gt; 1000000</strong></p>
<p><strong>Icarus, Ignite!</strong></p>
</td>
<td>
<p><strong>North</strong></p>
<p><strong>*--Scarlet | 1000000</strong></p>
<p><strong>Ironislands</strong></p>
<p><strong>*--Blue | 20000</strong></p>
<p><strong>Dorne</strong></p>
<p><strong>*--Indigo | 2000</strong></p>
<p><strong>*--Purple | 6000</strong></p>
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
<p><strong>Grow &lt;Valeofarryn&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;Stormlands&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;TheGift&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;Yiti&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;Valeofarryn&gt; &lt;Blue&gt; 1</strong></p>
<p><strong>Grow &lt;Stormlands&gt; &lt;Green&gt; 1</strong></p>
<p><strong>Icarus, Ignite!</strong></p>
</td>
<td>
<p><strong>Stormlands</strong></p>
<p><strong>*--Green | 1</strong></p>
<p><strong>*--White | 1</strong></p>
<p><strong>Valeofarryn</strong></p>
<p><strong>*--Blue | 1</strong></p>
<p><strong>*--White | 1</strong></p>
</td>
</tr>
</tbody>
</table>