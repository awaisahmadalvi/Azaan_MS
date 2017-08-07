using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Azaan.Core.UI
{
    public class TimePickerMillisPanel : Panel
    {

        TimePicker timePicker = new TimePicker(0, true, true, true, false);
        public TimePickerMillisPanel()
        {
            Controls.Add(timePicker);

            this.Dock = DockStyle.None;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        public void setTimeChangeListener(ValueChangedEventHandler<DateTime> listener)
        {
            this.timePicker.ValueChanged += listener;
        }
        public void setTime(DateTime t)
        {
            timePicker.Value = t;
        }
        public DateTime getTime()
        {
            return this.timePicker.Value;
        }
    }
}