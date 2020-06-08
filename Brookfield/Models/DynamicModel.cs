using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brookfield.Models
{
    public class DynamicModel : INotifyPropertyChanged
    {
        public Dictionary<string, object> _values;
        public object _groupProperty;
       
        public event PropertyChangedEventHandler PropertyChanged;

        public object GroupProperty
        {
            get
            {
                return _groupProperty;
            }
            set
            {
                _groupProperty = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("GroupProperty"));
            }
        }

        public Dictionary<string, object> Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Values"));
            }

        }
        public DynamicModel()
        {
            this._values = new Dictionary<string, object>();

        }

        public void RefreshGroupProperty(string key)
        {
            object value = null;
            this.Values.TryGetValue(key, out value);
            this.GroupProperty = value;
        }
    }
}
