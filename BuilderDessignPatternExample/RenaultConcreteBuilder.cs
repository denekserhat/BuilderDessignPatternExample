using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDessignPatternExample
{

    class RenaultConcreteBuilder : ArabaBuilder
    {
        public RenaultConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 100;
        public override void SetMarka() => araba.Marka = "Renault";
        public override void SetModel() => araba.Model = "Clio";
        public override void SetVites() => araba.Vites = true;
    }
    class MercedesConcreteBuilder : ArabaBuilder
    {
        public MercedesConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 150;
        public override void SetMarka() => araba.Marka = "Mercedes";
        public override void SetModel() => araba.Model = "C180";
        public override void SetVites() => araba.Vites = true;
    }
    class BMWConcreteBuilder : ArabaBuilder
    {
        public BMWConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 25;
        public override void SetMarka() => araba.Marka = "BMW";
        public override void SetModel() => araba.Model = "520d";
        public override void SetVites() => araba.Vites = true;
    }
}
