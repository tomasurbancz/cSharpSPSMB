using OopExamples.Interfaces;

namespace OopExamples.classes;

public class ComputerBuilder : IComputerBuilder
{
    private Computer _computer;

    public ComputerBuilder()
    {
        _computer = new Computer();
    }
    
    public IComputer BuildFromConfiguration(IComputerConfiguration configuration)
    {
        return new Computer().BuildNewComputer(configuration);
    }

    public IComputerBuilder AddMotherBoard(IMotherBoard motherBoard)
    {
        _computer.MotherBoard = motherBoard;
        return this;
    }

    public IComputerBuilder AddCPU(ICPU cpu)
    {
        _computer.Cpu = cpu;
        return this;
    }

    public IComputerBuilder AddGPU(IGPU gpu)
    {
        _computer.Gpu = gpu;
        return this;
    }

    public IComputerBuilder AddRam(IRAM ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public IComputerBuilder AddPowerSupply(IPowerSupply powerSupply)
    {
        _computer.PowerSupply = powerSupply;
        return this;
    }

    public IComputerBuilder AddCase(ICase pcCase)
    {
        _computer.Case = pcCase;
        return this;
    }

    public IComputer Build()
    {
        return _computer;
    }
}