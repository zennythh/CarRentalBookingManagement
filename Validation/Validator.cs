using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PL_VehicleRental.Validation
{
    public class Validator
    {
        private sealed class ValidationRule
        {
            public Control Control { get; set; }
            public Func<bool> Validate { get; set; }
            public string Message { get; set; }
            public Label ErrorLabel { get; set; }
        }

        private readonly List<ValidationRule> _rules = new List<ValidationRule>();
        private readonly HashSet<Control> _wiredControls = new HashSet<Control>();
        private readonly Dictionary<Guna2TextBox, Color> _originalBorderColors = new Dictionary<Guna2TextBox, Color>();
        private readonly Dictionary<Guna2ComboBox, Color> _originalComboColors = new Dictionary<Guna2ComboBox, Color>();
        private readonly HashSet<Control> _validatingControls = new HashSet<Control>();

        private readonly ToolTip _toolTip;
        private readonly Color _errorBorderColor = Color.Red;

        public Validator()
        {
            _toolTip = new ToolTip
            {
                InitialDelay = 100,
                ReshowDelay = 100,
                AutoPopDelay = 5000,
                ShowAlways = true,
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Warning,
                ToolTipTitle = "Validation Error"
            };
        }

        public void Clear()
        {
            foreach (var kvp in _originalBorderColors)
            {
                kvp.Key.BorderColor = kvp.Value;
                kvp.Key.HoverState.BorderColor = kvp.Value;
                kvp.Key.FocusedState.BorderColor = kvp.Value;
            }

            foreach (var kvp in _originalComboColors)
            {
                kvp.Key.BorderColor = kvp.Value;
                kvp.Key.HoverState.BorderColor = kvp.Value;
                kvp.Key.FocusedState.BorderColor = kvp.Value;
            }

            foreach (var rule in _rules)
            {
                if (rule.ErrorLabel != null)
                {
                    rule.ErrorLabel.Text = string.Empty;
                    rule.ErrorLabel.Visible = false;
                }
            }

            _toolTip.RemoveAll();
        }

        private void WireValidationEvents(Control control)
        {
            if (!_wiredControls.Add(control))
            {
                return;
            }

            if (control is Guna2ComboBox gunaCmb)
            {
                gunaCmb.SelectedIndexChanged += (sender, e) => ValidateControl(gunaCmb);
                return;
            }

            control.TextChanged += (sender, e) =>
            {
                if (!_validatingControls.Contains(control))
                {
                    ValidateControl(control);
                }
            };
        }

        private void RestoreOriginalStyle(Control control)
        {
            if (control is Guna2TextBox gunaTxt && _originalBorderColors.TryGetValue(gunaTxt, out Color originalTextBorder))
            {
                gunaTxt.BorderColor = originalTextBorder;
                gunaTxt.HoverState.BorderColor = originalTextBorder;
                gunaTxt.FocusedState.BorderColor = originalTextBorder;
                _toolTip.SetToolTip(gunaTxt, null);
                return;
            }

            if (control is Guna2ComboBox gunaCombo && _originalComboColors.TryGetValue(gunaCombo, out Color originalComboBorder))
            {
                gunaCombo.BorderColor = originalComboBorder;
                gunaCombo.HoverState.BorderColor = originalComboBorder;
                gunaCombo.FocusedState.BorderColor = originalComboBorder;
                _toolTip.SetToolTip(gunaCombo, null);
            }
        }

        private void SetError(Control control, string message, Label errorLabel)
        {
            bool hasError = !string.IsNullOrWhiteSpace(message);

            if (control is Guna2TextBox gunaTxt)
            {
                if (!_originalBorderColors.ContainsKey(gunaTxt))
                {
                    _originalBorderColors[gunaTxt] = gunaTxt.BorderColor;
                }

                if (hasError)
                {
                    gunaTxt.BorderColor = _errorBorderColor;
                    gunaTxt.HoverState.BorderColor = _errorBorderColor;
                    gunaTxt.FocusedState.BorderColor = _errorBorderColor;
                    _toolTip.SetToolTip(gunaTxt, message);
                }
                else
                {
                    RestoreOriginalStyle(gunaTxt);
                }
            }
            else if (control is Guna2ComboBox gunaCmb)
            {
                if (!_originalComboColors.ContainsKey(gunaCmb))
                {
                    _originalComboColors[gunaCmb] = gunaCmb.BorderColor;
                }

                if (hasError)
                {
                    gunaCmb.BorderColor = _errorBorderColor;
                    gunaCmb.HoverState.BorderColor = _errorBorderColor;
                    gunaCmb.FocusedState.BorderColor = _errorBorderColor;
                    _toolTip.SetToolTip(gunaCmb, message);
                }
                else
                {
                    RestoreOriginalStyle(gunaCmb);
                }
            }

            if (errorLabel != null)
            {
                errorLabel.Text = message ?? string.Empty;
                errorLabel.Visible = hasError;
            }
        }

        private void AddRule(Control control, Func<bool> validationFunc, string message, Label errorLabel = null)
        {
            _rules.Add(new ValidationRule
            {
                Control = control,
                Validate = validationFunc,
                Message = message,
                ErrorLabel = errorLabel
            });

            if (errorLabel != null)
            {
                errorLabel.Text = string.Empty;
                errorLabel.Visible = false;
            }

            WireValidationEvents(control);
        }

        public void Required(Control control, string message, Label errorLabel = null)
        {
            AddRule(control, () => !string.IsNullOrWhiteSpace(control.Text), message, errorLabel);
        }

        public void Required(ComboBox comboBox, string message, Label errorLabel = null)
        {
            if (comboBox is Guna2ComboBox gunaCmb)
            {
                Required(gunaCmb, message, errorLabel);
                return;
            }

            AddRule(comboBox, () => comboBox.SelectedIndex > -1, message, errorLabel);
        }

        public void Required(Guna2ComboBox comboBox, string message, Label errorLabel = null)
        {
            AddRule(comboBox, () => comboBox.SelectedIndex > -1, message, errorLabel);
        }

        public void IsInteger(Control control, string message, Label errorLabel = null)
        {
            AddRule(control, () => int.TryParse(control.Text, out _), message, errorLabel);
        }

        public void IsPhoneNumber(Control control, string message, Label errorLabel = null)
        {
            AddRule(control, () =>
            {
                string input = control.Text.Trim();

                if (string.IsNullOrWhiteSpace(input) || input == "+63")
                {
                    return true;
                }

                string cleaned = Regex.Replace(input, @"[^\d+]", "");

                if (cleaned.StartsWith("09") && cleaned.Length == 11)
                {
                    cleaned = "+63" + cleaned.Substring(1);
                }
                else if (cleaned.StartsWith("9") && cleaned.Length == 10)
                {
                    cleaned = "+63" + cleaned;
                }
                else if (cleaned.StartsWith("639") && cleaned.Length == 12)
                {
                    cleaned = "+" + cleaned;
                }

                bool isValid = Regex.IsMatch(cleaned, @"^\+639\d{9}$");

                if (isValid && control.Text != cleaned)
                {
                    _validatingControls.Add(control);
                    control.Text = cleaned;
                    _validatingControls.Remove(control);
                }
                return isValid;
            }, message, errorLabel);
        }

        public void IsEmail(Control control, string message, Label errorLabel = null)
        {
            AddRule(control, () => Regex.IsMatch(control.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"), message, errorLabel);
        }

        public void Custom(Control control, Func<bool> validationFunc, string message, Label errorLabel = null)
        {
            AddRule(control, validationFunc, message, errorLabel);
        }

        public bool ValidateControl(Control control)
        {
            bool isValid = true;
            string firstErrorMessage = null;
            Label firstErrorLabel = null;
            var errorLabelsToClear = new HashSet<Label>();

            foreach (var rule in _rules)
            {
                if (!ReferenceEquals(rule.Control, control))
                {
                    continue;
                }

                if (rule.ErrorLabel != null)
                {
                    errorLabelsToClear.Add(rule.ErrorLabel);
                }

                bool rulePassed = rule.Validate();
                if (!rulePassed)
                {
                    isValid = false;
                    if (firstErrorMessage == null)
                    {
                        firstErrorMessage = rule.Message;
                        firstErrorLabel = rule.ErrorLabel;
                    }
                }
            }

            SetError(control, firstErrorMessage, firstErrorLabel);

            if (isValid)
            {
                foreach (var errorLabel in errorLabelsToClear)
                {
                    if (errorLabel != null && errorLabel != firstErrorLabel)
                    {
                        errorLabel.Text = string.Empty;
                        errorLabel.Visible = false;
                    }
                }
            }

            return isValid;
        }

        public bool Validate()
        {
            bool isValid = true;
            var controls = new HashSet<Control>();

            foreach (var rule in _rules)
            {
                controls.Add(rule.Control);
            }

            foreach (var control in controls)
            {
                if (!ValidateControl(control))
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
