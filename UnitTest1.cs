using System;
using System.Collections.Generic;
using Xunit;

namespace Exercise.Tests
{
    public class UnitTest1
    {
        private Exercise.Program prog;
        public UnitTest1()
        {
            prog = new Program();
        }
        [Theory]
        [InlineData(new int[] { 1, 9, 4, 0, -2, -9, 9, 3, 9, -6, -6, 2, -1, 6, -10, -1, 0, -5, 4, -2 }, 47)]
        [InlineData(new int[] {-6,1,-7,9,-10,-3,-1,-2,7,2,-3,-10,2,8,3,-10,8,-7,-9,5},45)]
        [InlineData(new int[] {-86,-28,-32,15,-41,63,-63,-64,-9,-78,60,2,18,-38,27,-79,27,95,-68,70,29,-18,27,-90,94,-99,20,-70,-61,-61,-31,-54,-25,-64,-93,-91,-64,55,-21,95},697)]
        [InlineData(new int[] {-1466,1118,-7022,2926,289,-5760,-1442,730,8414,4140,-6643,-9534,-8859,-239,-157,9323,9085,6565,-5254,-7670},42590)]
        public void Test2(int[] values, int result)
        {
            var outcome = prog.CalPositiveSum(values);
            Assert.True(outcome == result, $"You should have returned {result} but did return {outcome}.");
        }

        [Theory]
        [InlineData(new int[] {1, 4, 3, -4, 1 },-4)]
        [InlineData(new int[] {6, 2, 9, 5, -8, 4, -9, -1, 2, -7 },504)]
        [InlineData(new int[] {2, 8, -3, -9, 1, 4, 5, 8, 4, -1, 5, 8, -2, -8, -4, -2, -9, -9, -8, -7, 3, 4, -6, -9, 8, 7, -3, -6, -5, 2, -6, 3, 9, -5, -6, 5, 6, 3, -9, 6, 1, 2, 3, 6, 9, 4, 8, 2, 9, 3 },int.MinValue)]
        [InlineData(new int[] {-1, 2, -1, -4, 1, -3, 2, 3, -1, 2, -4, 3, 2, -1, -2, 4, 3, -4, 3, -3, -2, -4, 1, -4, 3, 2, -3, 2, 2, -3, 3, 3, 3, -4, 2, -3, -2, 4, -4, 1, -2, 1, -3, -3, 1, 1, -2, 2, -1, -4 },int.MinValue)]
        public void Test2b(int[] values, int result)
        {
            var outcome = prog.CalNegativeMulti(values);
            Assert.True(outcome == result, $"You should have returned {result} but did return {outcome}.");
        }

        [Theory]
        [InlineData(new string[] { "3", "3", "0", "-3", "-3", "2", "1", "0", "-4", "-5", "1", "-4", "-3", "1", "1", "-5", "3", "-4", "-2", "-1" }, -34)]
        [InlineData(new string[] { "3", "3", "a", "-3", "four", "1", "2", "1", "-4", "-1", }, -8)]
        [InlineData(new string[] { "-4", "-5", "-5", "-3", "4a", "-4", "three houses", "-1", "-4", "-4" }, -30)]
        [InlineData(new string[] { "-1,-17", "-24", "-23", "-30,-3", "-32", "-22", "4", "-33" }, -185)]
        public void Test3(string[] values, int result)
        {

            var outcome = prog.CalValuesSum(new List<string>(values));
            Assert.True(outcome == result, $"You should have returned {result} but did return {outcome}.");
        }

        [Theory]
        [InlineData(new string[] { "O", "9", "4", "7", "-7", }, 0)]
        [InlineData(new string[] { "-9", "2", "-5", "-9", "7", "-5", "-2", "-7", "-2", "-9", }, -14)]
        [InlineData(new string[] { "-9", "2 a", "- 5", "-9", "7", "-5", "-6", "- 7", "-2", "-9 -", }, -7)]
        [InlineData(new string[] { "8 house 3", " boom -3", "-8,0", " -8", "-5", "- -10", "2", "-9 9", "4", "-5", "-2,3,4", "-9,-3", "-4", "3", "- - - - 3", }, -22)]
        public void Test4(string[] values, int result)
        {

            var outcome = prog.CalValuesSum2(new List<string>(values));
            Assert.True(outcome == result, $"You should have returned {result} but did return {outcome}.");
        }

        [Theory]
        [InlineData(new string[] { "5", "ignore1", "-8", "add2", "3", "ignore2", "3", "add1", "9", "add0" }, 4)]
        [InlineData(new string[] { "16", "ignore0", "11", "ignore1", "4", "ignore2", "19", "ignore3", "5", "add4", "1", "add5", "11", "ignore6", "15", "ignore7", "17", "add8", "10", "ignore9", "17", "ignore10", "0", "ignore11", "1", "add12", "11", "add13", "12", "ignore14", "18", "ignore15", "2", "ignore16", "17", "ignore17", "16", "add18", "19", "add19" }, 70)]
        [InlineData(new string[] { "-7", "add234526", "-2", "ignore49921", "-5", "ignore95472", "-5", "ignore91619", "-5", "ignore75508", "-5", "ignore81071", "7", "ignore93595", "-3", "ignore50713", "3", "ignore33333", "6", "ignore81799" }, 0)]
        [InlineData(new string[] { "19", "ignore97027", "13", "ignore88276", "12", "ignore71507", "-17", "ignore58673", "6", "ignore81262", "-3", "ignore2192", "1", "add0", "16", "add1", "7", "add2", "-16", "add3", "13", "add4", "5", "add5", "2", "ignore16539", "12", "add6", "-13", "ignore10704" }, 38)]
        public void Test(string[] values, int result)
        {
            var dictionary = new Dictionary<string, double>();
            for (int i= 0; i < values.Length - 1; i += 2)
            {
                double number = 0;
                double.TryParse(values[i], out number);
                dictionary.Add(values[i + 1], number);
            }
            var outcome = prog.RetrieveCalValues(dictionary);
            Assert.True(outcome == result, $"You should have returned {result} but did return {outcome}.");
        }
        
        
   }
}
