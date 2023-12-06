
using Laboratorium2.Controllers;

public class Calculator
    {
        public operators? Operator { get; set; }
        public double? x { get; set; }
        public double? y { get; set; }

        public String Op
        {
            get
            {
                switch (Operator)
                {
                    case operators.ADD:
                        return "+";
                    case operators.SUB:
                        return "-";
                    case operators.MUL: 
                        return "*";
                    case operators.DIV: 
                        return "/"; 
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return Operator != null && x != null && y != null;
        }

        public double Calculate()
        {
            double? result = 0;
            switch (Operator)
            {
                case operators.ADD:
                    result = x + y;
                    break;

                case operators.SUB:
                    result = x - y;
                    break;

                case operators.MUL:
                    result = x * y;
                    break;

                case operators.DIV:
                    result = x / y;
                    break;

                default: return double.NaN;

            }
            return (double)result;
        }
    }
