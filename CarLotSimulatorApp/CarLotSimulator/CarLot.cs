using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        #region Properties
        public List<Car> Cars { get; set; }
        #endregion

        #region Constructor
        public CarLot()
        {
            Cars = new List<Car>();
        }
        #endregion

        #region Methods
        public void Add (Car car)
        {
           Cars.Add(car); 
        }
        

        public void ShowCarList()
        {
            //for (int i = 0; i < Cars.Count; i++)
            //{
            //    Console.WriteLine($"Year: {Cars[i].Year} Year: {Cars[i].Make} Model: {Cars[i].Model}");
            //}

            foreach (var car in Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model:{car.Model}");
            }
        
        
        }
        #endregion

    }
}
