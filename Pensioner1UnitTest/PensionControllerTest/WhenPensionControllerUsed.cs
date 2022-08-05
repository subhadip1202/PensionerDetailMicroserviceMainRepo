using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using PensionerDetailMicroservice.Controllers;
using PensionerDetailMicroservice.Models;
using PensionerDetailMicroservice.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pensioner1UnitTest.PensionControllerTest
{
    class WhenPensionControllerUsed
    {


        [Test]
        public void GetPensionerDetail_validInput()
        {
            Mock<IRepo> mockrepo = new Mock<IRepo>();

            PensionerDetailModel pensionerDetailModel = new PensionerDetailModel
            {


                aadharno = 1234
            };
            mockrepo.Setup(s => s.getAllDetails(1234)).Returns(pensionerDetailModel);

            PensionerDetailController pensionerDetailController = new PensionerDetailController(mockrepo.Object);

            var result = pensionerDetailController.GetPensionerDetail(1234) as OkObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo(200));

            Assert.That(result.Value, Is.EqualTo(pensionerDetailModel));
        }

        [Test]
        public void GetPensionerDetail_InvalidInput()
        {
            Mock<IRepo> mockrepo = new Mock<IRepo>();


            mockrepo.Setup(s => s.getAllDetails(12341)).Returns(null);

            PensionerDetailController pensionerDetailController = new PensionerDetailController(mockrepo.Object);

            var result = pensionerDetailController.GetPensionerDetail(12341) as BadRequestObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo(400));

            Assert.That(result.Value, Is.EqualTo("Invalid User"));
        }
    }
}
