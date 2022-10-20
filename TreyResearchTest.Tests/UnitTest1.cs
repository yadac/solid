using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using TreyResearch.Controllers;
using TreyResearch.Models;
using TreyResearch.Services;

namespace TreyResearchTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void GETリクエスト時のCreate振る舞い検証()
        //{
        //    // ???
        //    Assert.DoesNotThrow(() => CreateController());
        //}

        //[Test]
        //public void CreateView取得検証()
        //{
        //    var controller = CreateController();
        //    var result = controller.Create();
        //    Assert.That(result, Is.InstanceOf<ViewResult>());
        //}

        //[Test]
        //public void CreateViewのモデルの型を検証()
        //{
        //    var controller = CreateController();
        //    var result = controller.Create() as ViewResult;
        //    Assert.That(result.Model, Is.InstanceOf<CreateRoomViewModel>());
        //}

        //public RoomController CreateController()
        //{
        //    // poorman
        //    var service = new AdoNetRoomRepository(null);
        //    return new RoomController(null, service);
        //}
    }
}