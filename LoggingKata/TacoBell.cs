using System;
using System.Net.NetworkInformation;

namespace LoggingKata
{
	public class TacoBell : ITrackable
    {
        public TacoBell()
		{
		}

        public string Name { get; set; }
        public Point Location { get; set; }


    }
}

