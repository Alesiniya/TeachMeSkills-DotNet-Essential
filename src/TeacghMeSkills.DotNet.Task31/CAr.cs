using System;
using System.Collections.Generic;
using System.Text;

namespace TeacghMeSkills.DotNet.Task31
{
    public class Car
    {
        public string Model { get; private set; }
        public DateTime ProdDate { get; private set; }
        public Car()
        {
            Model = "Unknown";
            ProdDate = DateTime.Now;
        }
        public Car(string Model, DateTime ProdDate)
        {
            this.Model = Model;
            this.ProdDate = ProdDate;
        }
        public override string ToString()
        {
            return "Model : " + Model + "; " + ProdDate.ToString("d") + ";" + "\n";
        }
    }
}
