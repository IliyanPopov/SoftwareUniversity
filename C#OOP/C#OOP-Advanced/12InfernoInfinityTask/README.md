<h2>Problem 1. Inferno Infinity</h2>
<p>If you've been involved with the creation of Inferno III last year, you may be informed of the disastrous critic reception it has received. Nevertheless, your company is determined to satisfy its fan base, so a sequel is coming and yeah, you will develop the crafting module of the game using the latest OOP trends.</p>
<p>You have three different weapons (Axe, Sword and Knife) which have base stats and a name. The base stats are min damage, max damage and number of sockets (sockets are basically holes, in which you can insert gems). Below are the base stats for the three weapon types:</p>
<ul>
<li>Axe (5-10 damage, 4 sockets)</li>
<li>Sword (4-6 damage, 3 sockets)</li>
<li>Knife (3-4 damage, 2 sockets)</li>
</ul>
<p>What&rsquo;s more, every weapon comes with a different level of rarity (how rare it is to come across such an item). Depending on its rarity, a weapon&rsquo;s maximum and minimum damage can be modified.</p>
<ul>
<li>Common (increases damage x1)</li>
<li>Uncommon (increases damage x2)</li>
<li>Rare (increases damage x3)</li>
<li>Epic (increases damage x5)</li>
</ul>
<p>So a Common Axe would have its damage modified in the following way: minimum damage = 5 *1, maximum damage = 10 *1. Whereas an Epic Axe would look like this: minimum damage = 5 * 5, maximum damage = 10 * 5.</p>
<p>Additionally, every weapon provides a bonus to three magical stats - strength, agility and vitality. At first the bonus of every magical stat is zero and can be increased with gems which are inserted into the weapon.</p>
<p>Every gem provides a bonus to all three of the magical stats. There are three different kind of gems:</p>
<ul>
<li>Ruby (+7 strength, +2 agility, +5 vitality)</li>
<li>Emerald (+1strength, +4 agility, +9 vitality)</li>
<li>Amethyst (+2 strength, +8 agility, +4 vitality)</li>
</ul>
<p>Every point of strength adds +2 to min damage and +3 to max damage. Every point of agility adds +1 to min damage and +4 to max damage. Vitality does not add damage.</p>
<p>Furthermore, every gem comes in different levels of clarity (basically level of quality). Depending on its level of clarity, a gem&rsquo;s stats can be modified in the following manner:</p>
<ul>
<li>Chipped (increases each stat by 1)</li>
<li>Regular (increases each stat by 2)</li>
<li>Perfect (increases each stat by 5)</li>
<li>Flawless (increases each stat by 10)</li>
</ul>
<p>So a Chipped Amethyst will have its stats modified like this: strength = 2 + 1, agility = 8 + 1, vitality = 4 + 1. Whilst a Perfect Emerald would look like this: strength = 1 + 5, agility = 4 + 5, vitality = 9 + 5.</p>
<p>Your job is to implement the functionality to read some weapons from the console and optionally to insert or remove gems at different socket indexes until you receive the END command.</p>
<p>Also, upon the <strong>Print</strong> command, in order to print correct final stats for a given weapon, first calculate the weapon&rsquo;s <strong>base stats </strong>taking into account <strong>its type and rarity</strong>. Afterwards, calculate the stats of each of its gems based on their <strong>clarity </strong>and finally add everything together. For the specific format of printing refer to the Output section.</p>
<h3>Note</h3>
<p>If you add gem on top of another, just overwrite it. If you add a gem to an invalid index, nothing happens. If you try to remove a gem from an empty socket or from invalid index, nothing happens. Upon receiving the END command print the weapons in order of their appearance in the format provided below.</p>
<h3>Input</h3>
<p>Each line consists of three types of commands in which the tokens are separated by ";".</p>
<p>Command types:</p>
<ul>
<li>Create;{weapon type};{weapon name}</li>
<li>Add;{weapon name};{socket index};{gem type}</li>
<li>Remove;{weapon name};{socket index}</li>
<li>Print;{weapon name}</li>
</ul>
<h3>Output</h3>
<p>Print weapons in the given format:</p>
<p>"{weapon's name}: {min damage}-{max damage} Damage, +{points} Strength, +{points} Agility, +{points} Vitality"</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="321">
<p><strong>Input</strong></p>
</td>
<td width="387">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="321">
<p>Create;Common Axe;Axe of Misfortune</p>
<p>Add;Axe of Misfortune;0;Chipped Ruby</p>
<p>Print;Axe of Misfortune</p>
<p>END</p>
</td>
<td width="387">
<p>Axe of Misfortune: 24-46 Damage, +8 Strength, +3 Agility, +6 Vitality</p>
</td>
</tr>
<tr>
<td width="321">
<p>Create;Common Axe;Axe of Misfortune</p>
<p>Add;Axe of Misfortune;0;Flawless Ruby</p>
<p>Remove;Axe of Misfortune;0</p>
<p>Print;Axe of Misfortune</p>
<p>END</p>
</td>
<td width="387">
<p>Axe of Misfortune: 5-10 Damage, +0 Strength, +0 Agility, +0 Vitality</p>
</td>
</tr>
</tbody>
</table>
