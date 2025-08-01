using Autodesk.DataExchange.SchemaObjects.Units;
using Rhino;
using UnitSystem = Rhino.UnitSystem;

namespace RhinoServices.RhinoUtility
{
    /// <summary>
    /// Utility class for converting Rhino unit systems to corresponding schema units.
    /// </summary>
    public class UnitUtils
    {
        /// <summary>
        /// Converts a Rhino unit system to a corresponding schema unit using the unit factory.
        /// </summary>
        /// <param name="rhinoUnit">The Rhino unit system to be converted.</param>
        /// <returns>The corresponding schema unit.</returns>
        public static Unit ConvertRhinoUnitToSchemaUnit(UnitSystem rhinoUnit)
        {
            Unit unitFactory = null;
            switch (rhinoUnit)
            {
                case UnitSystem.Feet:
                    unitFactory = UnitFactory.Feet;
                    break;
                case UnitSystem.Centimeters:
                    unitFactory = UnitFactory.Centimeter;
                    break;
                case UnitSystem.Millimeters:
                    unitFactory = UnitFactory.MilliMeter;
                    break;
                case UnitSystem.Inches:
                    unitFactory = UnitFactory.Inches;
                    break;
                case UnitSystem.Meters:
                    unitFactory = UnitFactory.Meter;
                    break;
                case UnitSystem.Decimeters:
                    unitFactory = UnitFactory.Decimeter;
                    break;
                case UnitSystem.Microinches:
                    unitFactory = UnitFactory.Microinches;
                    break;
                case UnitSystem.Microns:
                    unitFactory = UnitFactory.Microns;
                    break;
                case UnitSystem.Miles:
                    unitFactory = UnitFactory.Miles;
                    break;
                case UnitSystem.Mils:
                    unitFactory = UnitFactory.Mils;
                    break;
                case UnitSystem.Nanometers:
                    unitFactory = UnitFactory.Nanometer;
                    break;
                case UnitSystem.Yards:
                    unitFactory = UnitFactory.Yards;
                    break;
                case UnitSystem.Hectometers:
                    unitFactory = UnitFactory.Hectometer;
                    break;
                case UnitSystem.Kilometers:
                    unitFactory = UnitFactory.Kilometer;
                    break;
            }

            return unitFactory;
        }

        /// <summary>
        /// Converts a string input representing a unit to the corresponding Rhino unit system.
        /// </summary>
        /// <param name="input">The string input representing a unit.</param>
        /// <returns>The corresponding Rhino unit system.</returns>
        public static UnitSystem GetUnit(string input)
        {
            UnitSystem unitToReturn;

            switch (input)
            {
                case "Feet":
                    {
                        unitToReturn = UnitSystem.Feet;
                        break;
                    }

                case "Meters":
                    {
                        unitToReturn = UnitSystem.Meters;
                        break;
                    }

                case "Inches":
                    {
                        unitToReturn = UnitSystem.Inches;
                        break;
                    }

                case "Centimeters":
                    {
                        unitToReturn = UnitSystem.Centimeters;
                        break;
                    }

                case "Millimeters":
                    {
                        unitToReturn = UnitSystem.Millimeters;
                        break;
                    }

                default:
                    {
                        unitToReturn = UnitSystem.Feet;
                        break;
                    }
            }

            return unitToReturn;
        }

        /// <summary>
        /// Retrieves the active document unit from Rhino and converts it to a schema unit.
        /// </summary>
        /// <returns>The schema unit corresponding to the active Rhino document unit.</returns>
        public static Unit GetActiveDocUnit()
        {
            var unitFactory = ConvertRhinoUnitToSchemaUnit(RhinoDoc.ActiveDoc.ModelUnitSystem);
            return unitFactory;
        }
    }
}
