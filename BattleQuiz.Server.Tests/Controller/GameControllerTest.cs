using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using BattleQuiz.Server.Controllers;
using BattleQuiz.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NFluent;
using NUnit.Framework;

namespace BattleQuiz.Server.Tests.Controller
{
    [TestFixture]
    class PostGameControllerTest
    {
        private GameController _controller;

        [SetUp]
        public void SetUp()
        {
            var dbSetMock = new Mock<DbSet<Game>>();
            var contextMock = new Mock<BattleQuizDbContext>();
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
