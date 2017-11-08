﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SenchaExtensions.Tests
{
    [TestClass]
    public class FilterTest
    {
        private FilterConverter converter;

        [TestInitialize]
        public void Init()
        {
            converter = new FilterConverter();
            Operator o = new Operator();
        }

        #region Like
        [TestMethod]
        public void TryFilter_Operator_Like()
        {
            object request = "[{\"operator\":\"like\",\"value\":\"DZubak\",\"property\":\"login\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }
        #endregion Like

        #region Equal
        [TestMethod]
        public void TryFilter_Operator_Equal_String()
        {
            object request = "[{\"operator\":\"eq\",\"value\":\"Davor\",\"property\":\"firstName\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_Equal_Int32()
        {
            object request = "[{\"operator\":\"eq\",\"value\":\"102\",\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_Equal_Double()
        {
            object request = "[{\"operator\":\"eq\",\"value\":\"5.2\",\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_Equal_DateTime()
        {
            object request = "[{\"operator\":\"eq\",\"value\":\"2020-02-12\",\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }
        #endregion Equal

        #region GreaterThen
        [TestMethod]
        public void TryFilter_Operator_GreaterThen_Int32()
        {
            object request = "[{\"operator\":\"gt\",\"value\":\"101\",\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_GreaterThen_Double()
        {
            object request = "[{\"operator\":\"gt\",\"value\":\"5.1\",\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_GreaterThen_DateTime()
        {
            object request = "[{\"operator\":\"gt\",\"value\":\"2020-02-11\",\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }
        #endregion GreaterThen

        #region GreaterOrEqual
        [TestMethod]
        public void TryFilter_Operator_GreaterOrEqual_Int32()
        {
            object request = "[{\"operator\":\"ge\",\"value\":\"102\",\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_GreaterOrEqual_Double()
        {
            object request = "[{\"operator\":\"ge\",\"value\":\"5.2\",\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_GreaterOrEqual_DateTime()
        {
            object request = "[{\"operator\":\"ge\",\"value\":\"2020-02-11\",\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }
        #endregion GreaterOrEqual

        #region LessThen
        [TestMethod]
        public void TryFilter_Operator_LessThen_Int32()
        {
            object request = "[{\"operator\":\"lt\",\"value\":\"0\",\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_LessThen_Double()
        {
            object request = "[{\"operator\":\"lt\",\"value\":\"0\",\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_LessThen_DateTime()
        {
            object request = "[{\"operator\":\"lt\",\"value\":\"1995-01-01\",\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }
        #endregion LessThen

        #region LessOrEqual
        [TestMethod]
        public void TryFilter_Operator_LessOrEqual_Int32()
        {
            object request = "[{\"operator\":\"le\",\"value\":\"0\",\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_LessOrEqual_Double()
        {
            object request = "[{\"operator\":\"le\",\"value\":\"0\",\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void TryFilter_Operator_LessOrEqual_DateTime()
        {
            object request = "[{\"operator\":\"le\",\"value\":\"1995-01-01\",\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1);
        }
        #endregion LessOrEqual

        #region In
        [TestMethod]
        public void TryFilter_Operator_In_Int32()
        {
            object request = "[{\"operator\":\"in\",\"value\":[-10,102],\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 2);
        }

        [TestMethod]
        public void TryFilter_Operator_In_Double()
        {
            object request = "[{\"operator\":\"in\",\"value\":[-5.2,5.2],\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 2);
        }

        [TestMethod]
        public void TryFilter_Operator_In_DateTime()
        {
            object request = "[{\"operator\":\"in\",\"value\":[\"1994-16-10\",\"2020-12-02\"],\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 2);
        }
        #endregion In

        #region NotIn
        [TestMethod]
        public void TryFilter_Operator_NotIn_Int32()
        {
            object request = "[{\"operator\":\"notin\",\"value\":[-10,102],\"property\":\"ordersSubmited\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1000);
        }

        [TestMethod]
        public void TryFilter_Operator_NotIn_Double()
        {
            object request = "[{\"operator\":\"notin\",\"value\":[-5.2,5.2],\"property\":\"averageRate\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1000);
        }

        [TestMethod]
        public void TryFilter_Operator_NotIn_DateTime()
        {
            object request = "[{\"operator\":\"notin\",\"value\":[\"1994-16-10\",\"2020-12-02\"],\"property\":\"dateCreated\"}]";

            Filter filter = converter.ConvertFrom(request) as Filter;

            var result = MockData
                .Users()
                .AsQueryable()
                .FilterBy(filter)
                .ToList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == 1000);
        }
        #endregion NotIn
    }
}
