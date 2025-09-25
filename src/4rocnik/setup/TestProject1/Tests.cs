using System;
using System.Security.AccessControl;
using setup;
using Xunit;

namespace TestProject1
{ 
  public class Tests
  {
    [Fact]
    public void ThreePlusTwoEqualsFive_ResultsTrue()
    {
      // Arrange
      
      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 + 2";
      var output= "3 + 2 = 5";
      
      // Act
      
      var result = kalkulacka.CalculateEquation(input);
      
      // Assert
      
      Assert.Equal(result, output);
    }
    
    [Fact]
    public void ThreePlusTwoDoesntEqualSix_ResultsFalse()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 + 2";
      var output= "3 + 2 = 6";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.NotEqual(result, output);
    }
    
    [Fact]
    public void ThreeMinusTwoEqualsOne_ResultsTrue()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 - 2";
      var output= "3 - 2 = 1";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert
      
      Assert.Equal(result, output);
    }
    
    [Fact]
    public void ThreeMinusTwoDoesntEqualTwo_ResultsFalse()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 - 2";
      var output= "3 + 2 = 2";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.NotEqual(result, output);
    }
    
    [Fact]
    public void ThreeTimesTwoEqualsSix_ResultsTrue()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 * 2";
      var output= "3 * 2 = 6";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.Equal(result, output);
    }
    
    [Fact]
    public void ThreeTimesTwoDoesntEqualFour_ResultsFalse()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 * 2";
      var output= "3 * 2 = 4";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.NotEqual(result, output);
    }
    
    [Fact]
    public void ThreeDivideTwoEqualsOneAndHalf_ResultsTrue()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 / 2";
      var output= "3 / 2 = 1.5";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);       
      
      // Assert

      Assert.Equal(result, output);
    }
    
    [Fact]
    public void ThreeDivideTwoDoesntEqualOne_ResultsFalse()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 / 2";
      var output= "3 / 2 = 1";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.NotEqual(result, output);
    }
    
    [Fact]
    public void ThreePowTwoEqualsNine_ResultsTrue()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3 ** 2";
      var output= "3 ** 2 = 9";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.Equal(result, output);
    }
    
    [Fact]
    public void ThreePowTwoDoesntEqualEight_ResultsFalse()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      
      var input = "3 ** 2";
      var output= "3 ** 2 = 8";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.NotEqual(result, output);
    }
    
    [Fact]
    public void Validation()
    {
      // Arrange

      Kalkulacka kalkulacka = new Kalkulacka();
      var input = "3         **   2";
      var output = "3 ** 2 = 9";
      
      // Act

      var result = kalkulacka.CalculateEquation(input);
      
      // Assert

      Assert.Equal(result, output);
    }
  }
}