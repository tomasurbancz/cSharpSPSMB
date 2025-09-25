namespace OopExamples.Tests.NewComputerTests;

public class ValidComputer : Base.NewComputerTests
{
    
    [Fact]
    public void NewComputer_WithComponents()
    {
        IsValidComputer(Computer);
    }
    
    [Fact]
    public void NewComputer_WithoutOwenerAndMonitors()
    {
        Assert.Null(Computer.Owner);
        Assert.Empty(Computer.Monitors);

        IsValidComputer(Computer);
    }
    
}