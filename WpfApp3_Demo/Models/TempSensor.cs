using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp3_Demo.Utilities;

namespace WpfApp3_Demo.Models
{
    internal class TempSensor : BaseModel, ISensor
    {
        private SensorType _sensorType;

        public SensorType SensorType
        {
            get { return _sensorType; }
            set
            {
                if (_sensorType == value) return;
                _sensorType = value;
                NotifyPropertyChanged(nameof(SensorType));
            }
        }

        private int _sensorId;

        public int SensorId
        {
            get { return _sensorId; }
            set
            {
                if (_sensorId == value) return;
                _sensorId = value;
                NotifyPropertyChanged(nameof(SensorId));
            }
        }

        private string _sensorName;

        public string SensorName
        {
            get { return _sensorName; }
            set
            {
                if (_sensorName == value) return;
                _sensorName = value;
                NotifyPropertyChanged(nameof(SensorName));
            }
        }

        private double? _value;

        public double? Value
        {
            get { return _value; }
            set
            {
                if (value == _value) return;
                _value = value;
                NotifyPropertyChanged(nameof(Value));
            }
        }

        private string _sensImage;

        public string SensImage
        {
            get { return _sensImage; }
            set
            {
                if (_sensImage == value) return;
                _sensImage = value;
                NotifyPropertyChanged(nameof(SensImage));
            }
        }
    }
}
