using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTest : IDisposable
    {

        Command testCommand;

        public CommandTest()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                CommandLine = "dotnet test",
                Platform = "xUnit"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        // The below are examples of almost identical tests

        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange

            // Act
            var howTo = "Execute Unit Tests";
            testCommand.HowTo = howTo;

            // Assert
            Assert.Equal(howTo, testCommand.HowTo);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Arrang

            // Act 
            var commandLine = "Execute Unit Tests";
            testCommand.CommandLine = commandLine;

            // Assert
            Assert.Equal(commandLine, testCommand.CommandLine);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Arrange

            // Act 
            var platform = "Execute Unit Tests";
            testCommand.Platform = platform;

            // Assert
            Assert.Equal(platform, testCommand.Platform);
        }
    }
}