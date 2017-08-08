namespace Skeleton.Tests
{
    using System;
    using Contracts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        private const int DecreasingDurabilityValue = 1;
        private const int AxeInitialAttack = 10;
        private const int AxeInitialDurability = 10;
        private const int DummyInitialHealth = 10;
        private const int DummyinitialExperiance = 10;
        [Test]
        public void AttackingWithBrokenAxeThrowsException()
        {
            var fakeBrokenAxe = new Axe(AxeInitialAttack, 0);

            var fakedummy = new Mock<ITarget>();
            fakedummy.Setup(fd => fd.Health).Returns(DummyInitialHealth);
            fakedummy.Setup(fd => fd.GiveExperience()).Returns(DummyinitialExperiance);

            var ex = Assert.Throws<InvalidOperationException>(() => fakeBrokenAxe.Attack(fakedummy.Object));
            Assert.AreEqual("Axe is broken.", ex.Message);
        }

        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            IWeapon axe = new Axe(10, 10);
            ITarget dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability points not decresing when attacking");
        }

        [Test]
        public void DurabilityIsDecreasedAfterAttaking()
        {
            var fakeTarget = new Mock<ITarget>();
            var fakeWeapon = new Mock<IWeapon>();
            fakeWeapon.SetupAllProperties();
            fakeWeapon.Object.AttackPoints = AxeInitialAttack;
            fakeWeapon.Object.DurabilityPoints = AxeInitialDurability;
            fakeWeapon.Setup(fw => fw.Attack(It.IsAny<ITarget>()))
                .Callback(() => fakeWeapon.Object.DurabilityPoints -= DecreasingDurabilityValue);

            fakeWeapon.Object.Attack(fakeTarget.Object);
            Assert.AreEqual(AxeInitialAttack, fakeWeapon.Object.DurabilityPoints + DecreasingDurabilityValue);
        }
    }
}