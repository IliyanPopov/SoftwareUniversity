namespace Skeleton.Tests
{
    using Contracts;
    using Moq;
    using NUnit.Framework;
    using NUnit.Framework.Internal;

    [TestFixture]
    public class HeroTests
    {
        private IWeapon weapon;
        private IHero hero;
        private ITarget target;
        private const int DefaultAxeAttack = 10;
        private const int DefaultAxeDurability = 10;
        private const int DummyInitialHealth = 10;
        private const int DummyExperiance = 10;
        private const string WeaponName = "Zero";

        //[SetUp]
        //void InitializeData()
        //{
        //    this.weapon = new Axe(DefaultAxeAttack, DefaultAxeDurability);
        //    this.hero = new Hero(this.weapon, WeaponName);
        //    this.target = new Dummy(DummyInitialHealth, DummyExperiance);
        //}

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            var fakeWeapon = new Mock<IWeapon>();
            fakeWeapon.Setup(fw => fw.AttackPoints).Returns(DefaultAxeAttack);
            fakeWeapon.Setup(fw => fw.DurabilityPoints).Returns(DefaultAxeDurability);

            var fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(fk => fk.Health).Returns(DummyInitialHealth);
            fakeTarget.Setup(fk => fk.IsDead()).Returns(true);
            fakeTarget.Setup(fk => fk.GiveExperience()).Returns(DummyExperiance);

            var heroResult = new Hero(fakeWeapon.Object, WeaponName);

            // Act
            heroResult.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(DummyExperiance, heroResult.Experience);
        }
    }
}