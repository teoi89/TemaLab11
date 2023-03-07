using System;
using System.Collections.Generic;
using System.Text;

namespace TemaLab11
{
    public interface IClassicFuelStation
    {
        public void RefuelGasolineVehicle(Vehicle vehicle, int quantity);
        public void RefuelDieselVehicle(Vehicle vehicle, int quantity);
        public void RefuelGPLVehicle(Vehicle vehicle, int quantity);
    }
}
