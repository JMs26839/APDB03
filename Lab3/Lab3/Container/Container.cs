using Lab3.Exceptions;
using Lab3.Interfaces;

namespace Lab3.Container;

public class Container : IContainer
{
    
    
    private double _massOfCargo{ get; set; }
    private double _tareWeight{ get; set; }
    private double _height{ get; set; }

    public Container(double massOfCargo, double tareWeight, double height)
    {
        _massOfCargo = massOfCargo;
        _tareWeight = tareWeight;
        _height = height;
    }


    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double mass)
    {
        throw new OverfillException();
    }
}