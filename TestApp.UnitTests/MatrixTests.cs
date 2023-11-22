using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7 ,8 } };
        List<List<int>> expected = new() { new() { 6, 8 }, new() { 10, 12 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
       Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        List<List<int>> matrixA = new() ;
        List<List<int>> matrixB = new() ;
       

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_MatrixAddition_DifferentRowsSecondMatrix_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5 }, new() { 7, 8 } };


        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentRowsFirstMatrix_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5 , 6}, new() { 7, 8 } };


        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentLinesFirstMatrix_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1 ,2 }, new() {  4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };


        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentLinesSecondMatrix_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 4, 5 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7} };


        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_EmptyLinesSecondMatrix_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 4, 5 } };
        List<List<int>> matrixB = new() { new() { 4, 5 }, new()};


        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

     [Test]
    public void Test_MatrixAddition_EmptyLinesAndRowsSecondMatrix_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 4, 5 } };
        List<List<int>> matrixB = new() { new() , new()};


        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_NegativeNumbersSecondMatrix_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { -1, -2 }, new() { -3, -4 } };
        List<List<int>> matrixB = new() { new() { -5, -6 }, new() { -7, -8 } };
        List<List<int>> expected = new() { new() { -6, -8 }, new() { -10, -12 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_AllNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { -5, -6 }, new() { -7, -8 } };
        List<List<int>> expected = new() { new() { -4, -4 }, new() { -4, -4 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {       
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 0, 0 }, new() { 0, 0 } };
        List<List<int>> expected = matrixA;

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
       
    }
}
