﻿using System;
using System.Data;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var viewModel = new WeatherLatestViewModel(new WeatherMock());
            Assert.AreEqual("", viewModel.AreaIdText);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TemperatureText);

            viewModel.AreaIdText = "1";
            viewModel.Search();
            Assert.AreEqual("1", viewModel.AreaIdText);
            Assert.AreEqual("2018/01/01 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("2", viewModel.ConditionText);
            Assert.AreEqual("12.30℃", viewModel.TemperatureText);
        }
    }

    internal class WeatherMock : IWeatherRepository
    {
        public WheatherEntity GetLatest(int areaId)
        {
            return   new WheatherEntity(1,
                                        Convert.ToDateTime("2018/01/01 12:34:56"),
                                        2,
                                        12.3f);
        }
    }
}
