using OopExamples.Interfaces;

namespace OopExamples.classes;

public class Computer : IComputer
{
    public IEntity Owner { get; set; }
    public IMotherBoard MotherBoard { get; set; }
    public ICPU Cpu { get; set; }
    public IGPU Gpu { get; set; }
    public IRAM Ram { get; set; }
    public IPowerSupply PowerSupply { get; set; }
    public ICase Case { get; set; }
    public IMonitor[] Monitors { get; set; }
    public bool IsOn { get; private set; }
    public bool IsPersonalPC { get; }
    public bool IsCompanyPC { get; }
    
    public void PowerUp()
    {
        IsOn = true;
    }

    public void ShutDown()
    {
        IsOn = false;
    }

    public void PressPowerButton()
    {
        if(!IsOn) PowerUp();
        else ShutDown();
    }

    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public float Compute(string equation)
    {
        return 0;
    }

    public IComputer BuildNewComputer(IComputerConfiguration configuration)
    {
        return new ComputerBuilder().BuildFromConfiguration(configuration);
    }
}