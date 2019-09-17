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
      int index = 8;

      //act
      testList.Add(166);
      testList.Add(785);
      testList.Add(33);
      testList.Add(99);
      testList.Add(42);
      testList.Add(33);
      testList.Add(99);
      testList.Add(55);
      testList.Add(42);
      actual = testList[index];

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


    [TestMethod]
    public void Remove_RemoveItemFromEmptyList_DoNothingToCount()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 0;
      int actual;

      //act
      testList.Remove(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveItemFromEmptyList_DoNothingToCapacity()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 4;
      int actual;

      //act
      testList.Remove(42);
      actual = testList.Capacity;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveItemThatIsNotInAListWithFiveItems_DoNothingToCount()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 5;
      int actual;

      //act
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfOne_CountBecomesZero()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 0;
      int actual;

      //act
      testList.Add(42);
      testList.Remove(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfFive_CountBecomesFour()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 4;
      int actual;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfNine_CountBecomesEight()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 8;
      int actual;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Add(6);
      testList.Add(7);
      testList.Add(8);
      testList.Add(9);
      testList.Remove(42);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfFive_IndexOneBecomesIndexZero()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 2;
      int actual;
      int index = 0;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      actual = testList[index];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfFive_IndexTwoBecomesIndexOne()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 3;
      int actual;
      int index = 1;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      actual = testList[index];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveItemsAtIndicesZeroAndTwoFromListWithLengthOfFive_IndexFourBecomesIndexTwo()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 5;
      int actual;
      int index = 2;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      testList.Remove(3);
      actual = testList[index];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveAllFiveItemsFromListWithLengthOfFive_CountAtZero()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 0;
      int actual;

      //act
      testList.Add(42);
      testList.Add(3);
      testList.Add(3);
      testList.Add(42);
      testList.Add(3);
      testList.Remove(42);
      testList.Remove(3);
      testList.Remove(42);
      testList.Remove(3);
      testList.Remove(3);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveAllFiveItemsFromListWithLengthOfFiveThenAddThreeItems_CountAtThree()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 3;
      int actual;

      //act
      testList.Add(42);
      testList.Add(3);
      testList.Add(3);
      testList.Add(42);
      testList.Add(3);
      testList.Remove(42);
      testList.Remove(3);
      testList.Remove(42);
      testList.Remove(3);
      testList.Remove(3);
      testList.Add(25);
      testList.Add(81);
      testList.Add(242);
      actual = testList.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfFive_IndexThreeBecomesIndexTwo()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 4;
      int actual;
      int index = 2;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      actual = testList[index];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void Remove_RemoveASingleItemFromFrontOfListWithLengthOfFive_IndexFourBecomesIndexThree()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int expected = 5;
      int actual;
      int index = 3;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      actual = testList[index];

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Indexer_RemoveASingleItemFromFrontOfListWithLengthOfFive_IndexFourThrowsIndexOutOfRangeException()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int number;
      int index = 4;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Remove(42);
      number = testList[index];
    }


    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Indexer_RemoveASingleItemFromListWithLengthOfOneAndTryAccessingIndexZero_ThrowIndexOutOfRangeException()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int index = 0;
      int number;

      //act
      testList.Add(42);
      testList.Remove(42);
      number = testList[index];
    }


    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Indexer_TryAccessingNegativeIndex_ThrowIndexOutOfRangeException()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      int index = -1;
      int number;

      //act
      testList.Add(42);
      number = testList[index];
    }


    [TestMethod]
    public void ToString_ConvertListToString_ReturnedStringHasCommaSeparatedValuesEnclosedInParenthesis()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();
      string expected = "42,2,3,5";
      string actual;

      //act
      testList.Add(42);
      testList.Add(2);
      testList.Add(3);
      testList.Add(5);
      actual = testList.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void ToString_ConvertStringListWithNullItemsToString_ReturnedStringHasCommaSeparatedValuesEnclosedInParenthesis()
    {
      //arrange
      CustomList<string> testList = new CustomList<string>();
      string expected = ",Cacophony,,,Test,thing,word";
      string actual;

      //act
      testList.Add(null);
      testList.Add("Cacophony");
      testList.Add(null);
      testList.Add(null);
      testList.Add("Test");
      testList.Add("thing");
      testList.Add("word");
      actual = testList.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void PlusSign_AddTwoListsWithThreeElementsTogether_ToStringOfResultHasBothListContents()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string actual;
      string expected = "1,3,5,2,4,6";

      //act
      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);

      testListOne += testListTwo;
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void PlusSign_AddTwoListsWithThreeElementsTogether_CountBecomesSix()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      int actual;
      int expected = 6;

      //act
      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);

      testListOne += testListTwo;
      actual = testListOne.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void PlusSign_AddTwoListsTogetherOneHasThreeItemsOneIsEmpty_ResultingStringHasNothingFromEmptyListAndThreeItemsFromOtherList()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "2,4,6";
      string actual;

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);

      //act
      testListOne += testListTwo;
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void PlusSign_AddTwoEmptyListsTogether_ResultingStringIsEmpty()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "";
      string actual;

      //act
      testListOne += testListTwo;
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void MinusSign_SubtractTwoEmptyLists_ResultingStringIsEmpty()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "";
      string actual;

      //act
      testListOne += testListTwo;
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void MinusSign_SubtractOneListFromAnotherWithOneCommonItem_ResultingStringHasOneValueRemoved()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "3,5";
      string actual;

      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(1);
      testListTwo.Add(6);

      //act
      testListOne -= testListTwo;
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }



    [TestMethod]

    public void MinusSign_SubtractOneListFromAnotherWithAllCommonItemsButInDifferentOrder_ResultingToStringIsEmpty()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "";
      string actual;

      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(5);
      testListTwo.Add(1);
      testListTwo.Add(3);

      //act
      testListOne -= testListTwo;
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }



    [TestMethod]

    public void MinusSign_SubtractOneListFromAnotherWithAllCommonItemsButInDifferentOrder_CountBecomesZero()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      int expected = 0;
      int actual;
      
      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(5);
      testListTwo.Add(1);
      testListTwo.Add(3);

      //act
      testListOne -= testListTwo;
      actual = testListOne.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void ZipperMerge_CombineTwoListsTogetherEachWithLengthOfThree_ToStringOfResultWillHaveTheSixExpectedItems()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "1,2,3,4,5,6";
      string actual;

      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);

      //act
      testListOne.ZipperMerge(testListTwo);
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void ZipperMerge_CombineTwoListsOneWithLengthOfSixOneWithLengthOfThree_ToStringOfResultWillHaveTheNineExpectedItems()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      string expected = "1,2,3,4,5,6,1,3,5";
      string actual;

      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);
      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);

      //act
      testListOne.ZipperMerge(testListTwo);
      actual = testListOne.ToString();

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void ZipperMerge_CombineTwoListsTogetherOneWithLengthOfThreeOneWithLengthOfSeven_CountBecomesTen()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      int expected = 10;
      int actual;

      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);
      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);
      testListTwo.Add(6);

      //act
      testListOne.ZipperMerge(testListTwo);
      actual = testListOne.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void ZipperMerge_CombineTwoListsTogetherOneWithLengthOfNineOneWithLengthOfThree_CountBecomesTwelve()
    {
      //arrange
      CustomList<int> testListOne = new CustomList<int>();
      CustomList<int> testListTwo = new CustomList<int>();

      int expected = 12;
      int actual;

      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);
      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);
      testListOne.Add(1);
      testListOne.Add(3);
      testListOne.Add(5);

      testListTwo.Add(2);
      testListTwo.Add(4);
      testListTwo.Add(6);


      //act
      testListOne.ZipperMerge(testListTwo);
      actual = testListOne.Count;

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void GetEnumerator_UseForeachLoopToDisplayContentsOfListAsSingleStringAndIntersperseCommas_WillResultInCommaSeparatedValuesOfList()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();

      string expected = "1,3,5,1,3,5,1,3,5";
      string actual = "";

      testList.Add(1);
      testList.Add(3);
      testList.Add(5);
      testList.Add(1);
      testList.Add(3);
      testList.Add(5);
      testList.Add(1);
      testList.Add(3);
      testList.Add(5);


      //act
      bool shouldPlaceComma = false;
      foreach (int number in testList)
      {
        if (shouldPlaceComma)
        {
          actual += ",";
        }
        actual += $"{number}";
        shouldPlaceComma = true;
      }
      

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void GetEnumerator_UseForeachLoopToDisplayContentsOfBlankListAsSingleStringAndIntersperseCommas_WillResultInBlankString()
    {
      //arrange
      CustomList<int> testList = new CustomList<int>();

      string expected = "";
      string actual = "";


      //act
      bool shouldPlaceComma = false;
      foreach (int number in testList)
      {
        if (shouldPlaceComma)
        {
          actual += ",";
        }
        actual += $"{number}";
        shouldPlaceComma = true;
      }

      //assert
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]

    public void GetEnumerator_UseForeachLoopToDisplayContentsOfListAsSingleStringAndIntersperseCommas_WillResultInCommaSeparatedValuesOfListOfStrings()
    {
      //arrange
      CustomList<string> testList = new CustomList<string>();

      string expected = "Pete is a cow. Pete is a cow. Pete is a cow. ";
      string actual = "";

      testList.Add("Pete ");
      testList.Add("is ");
      testList.Add("a ");
      testList.Add("cow. ");
      testList.Add("Pete ");
      testList.Add("is ");
      testList.Add("a ");
      testList.Add("cow. ");
      testList.Add("Pete ");
      testList.Add("is ");
      testList.Add("a ");
      testList.Add("cow. ");


      //act
      foreach (string word in testList)
      {
        actual += $"{word}";
      }


      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}
