using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sorting_Algorithms
{
    public class SortingElement
    {
        public PictureBox Block { get; private set; }
        public Label Value { get; private set; }
        public Point Location { get { return Block.Location; } set { Block.Location = value; } }
        public int IntegerValue { get; private set; }

        public SortingElement(int value_)
        {
            IntegerValue = value_;

            Block = new PictureBox();
            Block.BackColor = System.Drawing.Color.Orange;
            Block.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Block.Location = new Point(0, 0);
            Block.Size = new System.Drawing.Size(40, 40);

            Value = new Label();
            Value.AutoSize = true;
            Value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            if (value_ >= 10)
                Value.Location = new Point(2, 4);
            else
                Value.Location = new Point(9, 4);

            Value.Size = new System.Drawing.Size(25, 30);

            if (value_ == -1)
                Value.Text = "-";
            else
                Value.Text = value_.ToString();

            Value.BackColor = Color.Transparent;

            Block.Controls.Add(Value);
        }

        public void ChangeValue(int value)
        {
            if (value == -1)
                Value.Text = "-";
            else
                Value.Text = value.ToString();

            IntegerValue = value;

            if (value >= 10)
                Value.Location = new Point(2, 4);
            else
                Value.Location = new Point(9, 4);
        }

        public void Dispose()
        {
            Value.Dispose();
            Block.Controls.Clear();
            Block.Dispose();
        }
    }
}
