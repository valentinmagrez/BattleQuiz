using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Battleship.Server.Controllers;
using Battleship.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NFluent;
using NUnit.Framework;

namespace Battleship.Server.Tests.Controller
{
    [TestFixture]
    class PostGameControllerTest
    {
        private GameController _controller;

        [SetUp]
        public void SetUp()
        {
            var dbSetMock = new Mock<DbSet<Game>>();
            var contextMock = new Mock<BattleshipDbContext>();
            contextMock.Setup(_ => _.Games).Returns(dbSetMock.Object);

            _controller = new GameController(contextMock.Object);
        }

        [Test]
        public async Task ReturnHttpCreated()
        {
            var response = (await _controller.Post()).Result as CreatedAtActionResult;

            Check.That(response.StatusCode).IsEqualTo(201);
        }
    }
}
