using System;
using System.Drawing;

namespace curtains
{
    class XkcdColour
    {
        [CsvHelper.Configuration.Attributes.Index(0)]
        public string Name { get; set; }

        [CsvHelper.Configuration.Attributes.Index(1)]
        public string Value { get; set; }

        private Color _colour;
        private Color Colour
        {
            get
            {
                if (_colour == Color.Empty)
                {
                    _colour = ColorTranslator.FromHtml(Value);
                }
                return _colour;
            }
        }

        private int Red => Colour.R;

        private int Green => Colour.G;

        private int Blue => Colour.B;

        public int Proximity(XkcdColour other)
        {
            var redDiff = Math.Abs(this.Red - other.Red);
            var greenDiff = Math.Abs(this.Green - other.Green);
            var blueDiff = Math.Abs(this.Blue - other.Blue);
            return redDiff + greenDiff + blueDiff;
        }
    }
}
