using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Bicycle : TwoWheeledVehicle
    {
        private SizeOfFrame _sizeOfFrame;

        public Bicycle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed, sizeOfWheels)
        {
        }

        public Bicycle(double weight, double maxSpeed, double sizeOfWheels, SizeOfFrame sizeOfFrame)
            : base(weight, maxSpeed, sizeOfWheels)
        {
            _sizeOfFrame = sizeOfFrame;
        }

        public enum SizeOfFrame
        {
            S,
            M,
            L,
            XL
        }

        public override string ToString()
        {
            string sizeOfFrame;

            sizeOfFrame = _sizeOfFrame switch
            {
                SizeOfFrame.S => "S",
                SizeOfFrame.M => "M",
                SizeOfFrame.L => "L",
                SizeOfFrame.XL => "XL",
                _ => "Incorrect value"
            };

            return $"Max speed: {MaxSpeed} km/h\nWeight: {Weight} kg\nSize of wheels: {SizeOfWheels} inches\nSize of frame: {sizeOfFrame}\nState: {State}";
        }
    }
}
