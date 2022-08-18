using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp3_Demo.Utilities;

namespace WpfApp3_Demo.Models
{
    public interface ISensor
    {
        SensorType SensorType { get; set; }
        int SensorId { get; set; }
        string SensorName { get; set; }
        double? Value { get; set; }
        string SensImage { get; set; }
    }
}
