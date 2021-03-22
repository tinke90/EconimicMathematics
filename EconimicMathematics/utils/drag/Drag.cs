using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils.grab
{
    class Drag
    {
        Form m_form;
        Panel m_panel;

        bool m_mouseDown;               // If mouse button has click and held down...
        Point m_lastLocation;           // Save last location to give new location...

        public Drag(Form _form, Panel _panel)
        {
            this.m_form = _form;
            this.m_panel = _panel;
        }

        // Mouse movement loader...
        public void LoadFormDrag()
        {
            MouseDown();
            MouseUp();
            MouseMove();
        }

        // If mouse button is click and held down
        // store mouse last location...
        private void MouseDown()
        {
            m_panel.MouseDown += (sender, e) => {
                m_mouseDown = true;
                m_lastLocation = e.Location;
            };
        }

        // If mouse button was released...
        private void MouseUp()
        {
            m_panel.MouseUp += (sender, e) => {
                m_mouseDown = false;
            };
        }

        // If mouse down is true, windwod form follow the mouse where ever it goes...
        // Note to self: Window form would follow mouse anytime unless m_mouseDown was not
        // added to tell if mouse button is held down...
        private void MouseMove()
        {
            m_panel.MouseMove += (sender, e) => {
                if(m_mouseDown)
                {
                    m_form.Location = new Point((m_form.Location.X - m_lastLocation.X) +
                        e.X, (m_form.Location.Y - m_lastLocation.Y) + e.Y);

                    m_form.Update();
                }
            };
        }
    }
}
