using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VehicleRental.Validation
{
    public class Validator
    {
        private readonly ErrorProvider _errorProvider;
        private readonly List<Func<bool>> _rules = new List<Func<bool>>();

        public Validator(ErrorProvider errorProvider)
        {
            _errorProvider = errorProvider;
        }

        public void Clear()
        {
            _errorProvider.Clear();
            _rules.Clear();
        }

        public void Required(Control control, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = !string.IsNullOrWhiteSpace(control.Text);

                _errorProvider.SetError(control, isValid ? "" : message);

                return isValid;
            });
        }

        public void Required(ComboBox comboBox, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = comboBox.SelectedIndex != 1;

                _errorProvider.SetError(comboBox, isValid ? "" : message);

                return isValid;
            });
        }

        public void IsInteger(Control control, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = int.TryParse(control.Text, out _);

                _errorProvider.SetError(control, isValid ? "" : message);

                return isValid;
            });
        }

        public void IsEmail(Control control, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = Regex.IsMatch(control.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                _errorProvider.SetError(control, isValid ? "" : message);

                return isValid;
            });
        }

        public void Custom(Control control, Func<bool> validationFunc, string message)
        {
            _rules.Add(() =>
            {
                bool isValid = validationFunc();

                _errorProvider.SetError(control, isValid ? "" : message);

                return isValid;
            });
        }

        public bool Validate()
        {
            bool isValid = true;

            foreach(var rule in _rules)
            {
                if(!rule())
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
