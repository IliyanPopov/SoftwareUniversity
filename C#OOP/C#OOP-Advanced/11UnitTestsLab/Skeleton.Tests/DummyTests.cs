namespace Skeleton.Tests
{
    using System;
    using Contracts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private ITarget _target;
        private const int WeaponInitialDamage = 10;
        private const int WeaponInitialDurability = 10;
        private const int DummyInitialHealth = 10;
        private const int DummyExperiance = 10;
        private const int Damage = 5;

        [SetUp]
        public void InitializeData()
        {
            this._target = new Dummy(DummyInitialHealth, DummyExperiance);
        }

        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            int initialHealth = this._target.Health;

            this._target.TakeAttack(Damage);

            Assert.AreEqual(initialHealth - Damage, this._target.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptioIfAttacked()
        {
            var targetMock = new Mock<Dummy>(DummyInitialHealth, DummyExperiance);
            targetMock.Object.Health = 0;

            Assert.Throws<InvalidOperationException>(() => targetMock.Object.TakeAttack(Damage));
        }

        [Test]
        public void DeadDummyGivesExperianceIfAttacked()
        {
           this._target.Health = 0;

            var experiancePoints = this._target.GiveExperience();

            Assert.AreEqual(DummyExperiance, experiancePoints);
        }

        [Test]
        public void AliveDummyDoesntNotGiveExperiance()
        {
            Assert.Throws<InvalidOperationException>(() => this._target.GiveExperience());
        }
    }
}