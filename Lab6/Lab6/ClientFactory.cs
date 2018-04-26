using System;

namespace Lab6
{
    class ClientFactory : IFactory<Client>
    {
        private readonly Style[] _styles;
        private readonly Stylist[] _stylists;
        private readonly IDecisionRandomizer _hasPersonalStylistRandomizer;

        private readonly Random _stylesAndStylistsRandom = new Random();

        public ClientFactory(Style[] styles, Stylist[] stylists,
            IDecisionRandomizer hasStylistRandomizer)
        {
            _styles = styles;
            _stylists = stylists;
            _hasPersonalStylistRandomizer = hasStylistRandomizer;
        }

        public Client Create()
        {
            var style = _styles[_stylesAndStylistsRandom.Next(_styles.Length)];
            var stylist = _stylists[_stylesAndStylistsRandom.Next(_stylists.Length)];
            return new Client(null, style, _hasPersonalStylistRandomizer.Decide() ? stylist : null);
        }
    }
}
