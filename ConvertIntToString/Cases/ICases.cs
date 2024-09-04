namespace ConvertIntToString.Cases
{
    public interface ICases
    {
        #region Units
        Transfer Zero { get; }
        Transfer One { get; }
        Transfer Two { get; }
        Transfer Three { get; }
        Transfer Four { get; }
        Transfer Five { get; }
        Transfer Six { get; }
        Transfer Seven { get; }
        Transfer Eight { get; }
        Transfer Nine { get; }
        Transfer Ten { get; }
        Transfer Eleven { get; }
        Transfer Twelve { get; }
        Transfer Thirteen { get; }
        Transfer Fouteen { get; }
        Transfer Fifteen { get; }
        Transfer Sixteen { get; }
        Transfer Seventeen { get; }
        Transfer Eightteen { get; }
        Transfer Nineteen { get; }
        #endregion

        #region Tens
        Transfer Tens { get; }
        Transfer Twenty { get; }
        Transfer Thirty { get; }
        Transfer Forty { get; }
        Transfer Fifty { get; }
        Transfer Sixty { get; }
        Transfer Seventy { get; }
        Transfer Eighty { get; }
        Transfer Ninety { get; }
        #endregion

        #region Hundreds
        Transfer OneHundred { get; }
        Transfer TwoHundred { get; }
        Transfer ThreeHundred { get; }
        Transfer FourHundred { get; }
        Transfer FiveHundred { get; }
        Transfer SixHundred { get; }
        Transfer SevenHundred { get; }
        Transfer EightHundred { get; }
        Transfer NineHundred { get; }
        #endregion

        #region Thousands/Millions/Billions
        Transfer OneMillion { get; }
        Transfer LessThanFiveMillions { get; }
        Transfer MoreThanFiveMillions { get; }

        Transfer OneBillion { get; }
        Transfer LessThanFiveBillions { get; }
        Transfer MoreThanFiveBillions { get; }
        
        Transfer Thousands { get; }
        Transfer OneThousand { get; }
        Transfer TwoThousand { get; }
        Transfer ThreeThousand { get; }
        Transfer FourThousand { get; }
        Transfer FiveThousand { get; }
        Transfer SixThousand { get; }
        Transfer SevenThousand { get; }
        Transfer EightThousand { get; }
        Transfer NineThousand { get; }
        #endregion
    }
}
