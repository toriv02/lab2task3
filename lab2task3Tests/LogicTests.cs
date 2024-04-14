using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]//1-й тест текст только с суммой
        public void positivetext()
        {
            String input = "10+20+30+40";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку
            if (flag) Assert.AreEqual(100, anser);
            else Assert.Fail();
        }
        [TestMethod()]//2-й тест текст только с разностью
        public void negativetext()
        {
            String input = "0-10-20-30-40";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку
            if (flag) Assert.AreEqual(-100, anser);
            else Assert.Fail();
        }
        [TestMethod()]//3-й тест текст с суммой и разностью
        public void midletext()
        {
            String input = "67+84-78-34+54";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку
            if (flag) Assert.AreEqual(93, anser);
            else Assert.Fail();
        }
        [TestMethod()]//4-й тест текст только с 1 числом
        public void onenumtext()
        {
            String input = "10";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку
            if (flag) Assert.AreEqual(10, anser);
            else Assert.Fail();
        }
        [TestMethod()]//5-й тест текст только с вещественным числом
        public void midletextwihtfructers()
        {
            String input = "10+67-645,4+1000-54,97";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку
            if (flag) Assert.AreEqual(376, 63, anser);
            else Assert.Fail();
        }
        [TestMethod()]//6-й тест пустой текст
        public void EmptyText()
        {
            String input = "";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку, т.к. хоти вызвать ошибку, то инвертируем значение флага
            if (!flag) Assert.AreEqual(-1, anser);
            else Assert.Fail();
        }
        [TestMethod()]//7-й тест текст не представляющий собой сумму
        public void NotSum()
        {
            String input = "fdhg-sdgsd+sajgk";
            bool flag = true;
            Double anser = Logic.findsum(input, ref flag);
            //проверка флага, который должен выдавать ошбку, т.к. хоти вызвать ошибку, то инвертируем значение флага
            if (!flag) Assert.AreEqual(-1, anser);
            else Assert.Fail();
        }
    }
}