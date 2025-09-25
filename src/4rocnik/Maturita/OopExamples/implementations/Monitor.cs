using OopExamples.Interfaces;
using OopExamples.Interfaces.Types;

namespace OopExamples.implementations;

public class Monitor : IMonitor
{
    public string Name { get; set; }
    public GPUConnector Connector { get; }

    public Monitor(string name, GPUConnector connector)
    {
        Name = name;
        Connector = connector;
    }
}