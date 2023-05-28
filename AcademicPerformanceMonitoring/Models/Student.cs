using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicPerformanceMonitoring.Models
{
    public class Student
    {
        public string FIO = string.Empty;
        public ushort MarkMathem;
        public ushort MarkOOP;
        public ushort MarkSIAOD;
        public ushort MarkPhysics;
        public double Average;
        public string AverageColor = string.Empty;
        public string MathemColor = string.Empty;
        public string OOPColor = string.Empty;
        public string SIAODColor = string.Empty;
        public string PhysicsColor = string.Empty;
        public string fio
        {
            get => FIO;
            set => FIO = value;
        }
        public ushort PmarkMathem
        {
            get => MarkMathem;
            set => MarkMathem = value;
        }
        public ushort PmarkOOP
        {
            get => MarkOOP;
            set => MarkOOP = value;
        }
        public ushort PmarkSIAOD
        {
            get => MarkSIAOD;
            set => MarkSIAOD = value;
        }
        public ushort PmarkPhysics
        {
            get => MarkPhysics;
            set => MarkPhysics = value;
        }
        public double GetAverage
        {
            get => Average;
            set => Average = (MarkMathem + MarkOOP + MarkSIAOD + MarkPhysics) / 4.0;
        }
        public string GetAverageColor
        {
            get => AverageColor;
            set
            {
                if (GetAverage < 1)
                {
                    AverageColor = "Red";
                }
                if (GetAverage <= 1.5 && GetAverage >= 1)
                {
                    AverageColor = "Yellow";
                }
                if (GetAverage > 1.5)
                {
                    AverageColor = "Green";
                }
            }
        }
        public string GetMathemColor
        {
            get => MathemColor;
            set
            {
                if (MarkMathem == 0)
                {
                    MathemColor = "Red";
                }
                if (MarkMathem == 1)
                {
                    MathemColor = "Yellow";
                }
                if (MarkMathem == 2)
                {
                    MathemColor = "Green";
                }
            }
        }
        public string GetOOPColor
        {
            get => OOPColor;
            set
            {
                if (MarkOOP == 0)
                {
                    OOPColor = "Red";
                }
                if (MarkOOP == 1)
                {
                    OOPColor = "Yellow";
                }
                if (MarkOOP == 2)
                {
                    OOPColor = "Green";
                }
            }
        }
        public string GetSIAODColor
        {
            get => SIAODColor;
            set
            {
                if (MarkSIAOD == 0)
                {
                    SIAODColor = "Red";
                }
                if (MarkSIAOD == 1)
                {
                    SIAODColor = "Yellow";
                }
                if (MarkSIAOD == 2)
                {
                    SIAODColor = "Green";
                }
            }
        }
        public string GetPhysicsColor
        {
            get => PhysicsColor;
            set
            {
                if (MarkPhysics == 0)
                {
                    PhysicsColor = "Red";
                }
                if (MarkPhysics == 1)
                {
                    PhysicsColor = "Yellow";
                }
                if (MarkPhysics == 2)
                {
                    PhysicsColor = "Green";
                }
            }
        }
    }
}
