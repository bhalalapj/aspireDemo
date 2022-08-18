using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp3_Demo.Commands;
using WpfApp3_Demo.Models;

namespace WpfApp3_Demo.ViewModels
{
    public class SensorViewModel : BaseViewModel
    {

        public SensorViewModel()
        {
            PopualteDataAsync();
        }

        #region Properties
        private List<ISensor> _sensors;

        public List<ISensor> Sensors
        {
            get { return _sensors; }
            set
            {
                if (_sensors == value) return;
                _sensors = value;
                NotifyChanged(nameof(Sensors));
            }
        }

        private ISensor _selectedSensor;

        public ISensor SelectedSensor
        {
            get { return _selectedSensor; }
            set
            {
                if (value == _selectedSensor) return;
                _selectedSensor = value;

                //if (_selectedSensor != null)
                //    SelectedSensorValue = _selectedSensor.Value.ToString();

                NotifyChanged(nameof(SelectedSensor));
            }
        }


        private string _selectedSensorValue;

        public string SelectedSensorValue
        {
            get { return _selectedSensorValue; }
            set
            {
                if (value == _selectedSensorValue) return;
                _selectedSensorValue = value;
                NotifyChanged(nameof(SelectedSensorValue));
            }
        }


        private DelegateCommand _selectedSensorValueCommand;

        public ICommand SelectedSensorValueCommand
        {
            get
            {
                if (_selectedSensorValueCommand == null)
                    _selectedSensorValueCommand = new DelegateCommand((para) =>
            {
                if (para == null) return;
                if (para is ISensor sens)
                    SelectedSensorValue = sens.Value.ToString();
            });
                return _selectedSensorValueCommand;
            }
        }
        #endregion

        #region Helpers
        public void PopualteDataAsync()
        {
            try
            {
                var lightSensorImgPath = @"images\light_sensor.jpg";
                var tempSensorImgPath = @"images\temp_sensor.png";

                var sensors = new List<ISensor>
                {
                    new LightSensor { SensImage = lightSensorImgPath, SensorId = 0, SensorName = "light 1", SensorType = Utilities.SensorType.Light, Value = 0.5 },
                    new LightSensor { SensImage = tempSensorImgPath, SensorId = 1, SensorName = "temp 1", SensorType = Utilities.SensorType.Temprature, Value = 10 },
                    new LightSensor { SensImage = lightSensorImgPath, SensorId = 2, SensorName = "light 1", SensorType = Utilities.SensorType.Light, Value = 0.2 }
                };

                Sensors = sensors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
