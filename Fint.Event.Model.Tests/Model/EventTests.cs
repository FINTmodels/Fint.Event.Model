using Xunit;

namespace Fint.Event.Model.Tests.Model
{
    public class EventTests
    {
        [Fact]
        public void HealthEventShouldReturnTrue()
        {
            //Arrange
            var eventObject = new Event<object> {Action = DefaultActions.HEALTH.ToString()};

            //Assert
            Assert.True(eventObject.IsHealthCheck());
        }

        [Fact]
        public void NonHealthEventShouldReturnFalse()
        {
            //Arrange
            var eventObject = new Event<object> { Action = DefaultActions.REGISTER_ORG_ID.ToString() };

            //Assert
            Assert.False(eventObject.IsHealthCheck());
        }

        [Fact]
        public void IsRegisterOrdIdEventShouldReturnTrue()
        {
            //Arrange
            var eventObject = new Event<object> { Action = DefaultActions.REGISTER_ORG_ID.ToString() };

            //Assert
            Assert.True(eventObject.IsRegisterOrgId());
        }

        [Fact]
        public void NonIsRegisterOrdIdEventShouldReturnFalse()
        {
            //Arrange
            var eventObject = new Event<object> { Action = DefaultActions.HEALTH.ToString() };

            //Assert
            Assert.False(eventObject.IsRegisterOrgId());
        }
    }
}