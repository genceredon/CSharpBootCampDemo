namespace Module03.CarpetCalculatorApp
{
    internal class CarpetCalculator
    {
        private double pricePerSqYard;
        private double noOfSqYards;

        // Property of the class
        public double PricePerSqYard
        {
            get
            {
                return pricePerSqYard;
            }
            set
            {
                pricePerSqYard = value;
            }
        }

        //public double PricePerSqYard { get; set; }

        // Default Constructor
        public CarpetCalculator()
		{
			//empty body
		}

		// Constructor
		public CarpetCalculator(double amountNeeded, double price)
		{
			noOfSqYards = amountNeeded;
			pricePerSqYard = price;
		}

		// Constructor
		public CarpetCalculator(double price)
		{
			pricePerSqYard = price;
		}

		public double DetermineTotalCost()
		{
			return (pricePerSqYard * noOfSqYards);
		}

		// One of the overloaded Mutator methods
		public void SetNoOfSqYards(double length, double width)
		{
			const int SQ_FT_PER_SQ_YARD = 9;

			noOfSqYards = length * width
				/ SQ_FT_PER_SQ_YARD;
		}

		// One of the overloaded Mutator methods
		public void SetNoOfSqYards(double squareYards)
		{
			noOfSqYards = squareYards;
		}

		// Accessor method
		public double GetNoOfSqYards()
		{
			return noOfSqYards;
		}

		public string DisplayResult()
		{
			return "Price Per Square Yard: " +
				   pricePerSqYard.ToString("C") +
				   "\nTotal Square Yards: " +
				   noOfSqYards.ToString("F1") +
				   "\nTotal Price: " +
				   DetermineTotalCost().ToString("C");
		}
	}
}