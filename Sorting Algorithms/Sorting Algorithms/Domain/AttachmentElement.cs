using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public class AttachmentElement
    {
        public Label Attachment { get; private set; }
        public string Value { get; private set; }
        public Point Location { get; private set; }

        public AttachmentElement(string value)
        {
            Location = new Point(0, 0);

            Attachment = new Label();
            Attachment.AutoSize = true;
            Attachment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            Attachment.Size = new System.Drawing.Size(25, 30);
            Attachment.Text = value.ToString();
            Attachment.BackColor = Color.Transparent;
            Value = value;
        }

        public void setLocation(Point elementLocation, int row)
        {
            Attachment.Location = new Point(elementLocation.X + 17 - Value.Length * 7, elementLocation.Y + row * 40);
            Location = elementLocation;
        }

        public void setAsArrayName(Point elementLocation)
        {
            Attachment.Location = new Point(elementLocation.X-35,elementLocation.Y+5);
        }

        public void Dispose()
        {
            Attachment.Dispose();
        }
    }
}
