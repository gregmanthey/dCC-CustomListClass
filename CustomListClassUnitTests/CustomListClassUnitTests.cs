using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListClassUnitTests
{
  [TestClass]
  public class CustomListClassUnitTests
  {
    [TestMethod]
    public void Add_AddOneItemToEmptyList_ListItemAtIndexZero()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 42;
      int actual;

      //act
      testList.Add(42);
      actual = testList[0];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Add_AddFiveItemsToEmptyList_FifthListItemAtIndexFour()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 42;
      int actual;

      //act
      testList.Add(166);
      testList.Add(785);
      testList.Add(33);
      testList.Add(99);
      testList.Add(42);
      actual = testList[4];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Add_AddNineItemsToEmptyList_NinthListItemAtIndexEight()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 42;
      int actual;

      //act
      testList.Add(166);
      testList.Add(785);
      testList.Add(33);
      testList.Add(99);
      testList.Add(42);
      testList.Add(33);
      testList.Add(99);
      testList.Add(42);
      testList.Add(42);
      actual = testList[8];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Add_AddOneItemToEmptyList_CountIncrementsByOne()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      
      int expected = 1;
      int actual;

      //act
      testList.Add(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Add_AddFiveItemsToEmptyList_CountIncrementsByFive()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 5;
      int actual;

      //act
      testList.Add(166);
      testList.Add(785);
      testList.Add(33);
      testList.Add(99);
      testList.Add(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Add_AddNineItemsToEmptyList_CountIncrementsByNine()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 9;
      int actual;

      //act
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Add(6);
      testList.Add(7);
      testList.Add(8);
      testList.Add(999);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}
