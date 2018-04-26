using System;

namespace Lab6
{
    class Client
    {
        public string Name { get; }

        public Style Style { get; set; }
        public Stylist PersonalStylist { get; set; }

        public Client(string name, Style style, Stylist stylist = null)
        {
            Name = name;
            Style = style;
            PersonalStylist = stylist;
        }
    }
}
