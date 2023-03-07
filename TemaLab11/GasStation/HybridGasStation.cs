using System;
using System.Collections.Generic;
using System.Text;

namespace TemaLab11
{
    public class HybridGasStation : IHybridFuelStation
    {
        void IHybridFuelStation.RefuelGasolineVehicle(Vehicle vehicle, int quantity)
        {
            Console.WriteLine($"{vehicle.Model} with the id {vehicle.Id} was fueled with {quantity} of gasoline.");
        }
        void IHybridFuelStation.RefuelDieselVehicle(Vehicle vehicle, int quantity)
        {
            Console.WriteLine($"{vehicle.Model} with the id{vehicle.Id} was fueled with {quantity} of diesel.");
        }
        void IHybridFuelStation.RefuelGPLVehicle(Vehicle vehicle, int quantity)
        {
            Console.WriteLine($"{vehicle.Model} with the id {vehicle.Id} was fueled with {quantity} liters of GPL.");
        }
        void IHybridFuelStation.RefuelElectricVehicle(Vehicle vehicle, int quantity)
        {
            Console.WriteLine($"{vehicle.Model} with the id {vehicle.Id} was fueled with {quantity} kWh of electric energy");
        }

        internal static void RefuelElectric(ElectricVehicle electricVehicle)
        {
            throw new NotImplementedException();
        }

        internal static void RefuelHybridVehicle(HybridVehicle hybridVehicle)
        {
            throw new NotImplementedException();
        }

        void IHybridFuelStation.RefuelHybridVehicle(Vehicle vehicle, int gasolineQuantity, int electricQuantity)
        {
            Console.WriteLine($"{vehicle.Model} with the id {vehicle.Id} was fueled with {gasolineQuantity} liters of gasoline and {electricQuantity} kWh of electric energy.");
        }
    }
}
