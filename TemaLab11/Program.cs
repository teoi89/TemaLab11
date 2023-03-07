using System;
using System.Collections.Generic;

namespace TemaLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiem cateva autovehicule
            GasolineVehicle gasolineVehicle = new GasolineVehicle("Audi A4", 1);
            DieselVehicle dieselVehicle = new DieselVehicle("BMW X5", 2);
            GPLVehicle GPLVehicle = new GPLVehicle("Dacia Logan", 3);
            ElectricVehicle electricVehicle = new ElectricVehicle("Tesla Model S", 4);
            HybridVehicle hybridVehicle = new HybridVehicle("Toyota Prius", 5);

            // Alimentam autovehiculele la statia clasica
            ClassicGasStation.RefuelGasolineVehicle(gasolineVehicle);
            ClassicGasStation.RefuelDieselVehicle(dieselVehicle);
            ClassicGasStation.RefuelGPLVehicle(GPLVehicle);

            // Alimentam autovehiculele la statia hibrida
            HybridGasStation.RefuelHybridVehicle(hybridVehicle);
            HybridGasStation.RefuelElectric(electricVehicle);

            // Afisam descrierea completa a autovehiculelor
            gasolineVehicle.GetDescription();
            dieselVehicle.GetDescription();
            GPLVehicle.GetDescription();
            electricVehicle.GetDescription();
            hybridVehicle.GetDescription();
        }

    }
}

