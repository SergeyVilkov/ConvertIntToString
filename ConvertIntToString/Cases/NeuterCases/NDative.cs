namespace ConvertIntToString.Cases.NeuterCases
{
    public class NDative : ICases
    {
        #region property Units
        public Transfer Zero => new Transfer { Id = 0, Name = "Нолю" };
        public Transfer One => new Transfer { Id = 1, Name = "Одному" };
        public Transfer Two => new Transfer { Id = 2, Name = "Двум" };
        public Transfer Three => new Transfer { Id = 3, Name = "Трём" };
        public Transfer Four => new Transfer { Id = 4, Name = "Четырём" };
        public Transfer Five => new Transfer { Id = 5, Name = "Пяти" };
        public Transfer Six => new Transfer { Id = 6, Name = "Шести" };
        public Transfer Seven => new Transfer { Id = 7, Name = "Семи" };
        public Transfer Eight => new Transfer { Id = 8, Name = "Восеми" };
        public Transfer Nine => new Transfer { Id = 9, Name = "Девяти" };
        public Transfer Ten => new Transfer { Id = 10, Name = "Десяти" };
        public Transfer Eleven => new Transfer { Id = 11, Name = "Одинадцати" };
        public Transfer Twelve => new Transfer { Id = 12, Name = "Двенадцати" };
        public Transfer Thirteen => new Transfer { Id = 13, Name = "Тринадцати" };
        public Transfer Fouteen => new Transfer { Id = 14, Name = "Четырнадцати" };
        public Transfer Fifteen => new Transfer { Id = 15, Name = "Пятнадцати" };
        public Transfer Sixteen => new Transfer { Id = 16, Name = "Шестнадцати" };
        public Transfer Seventeen => new Transfer { Id = 17, Name = "Семнадцати" };
        public Transfer Eightteen => new Transfer { Id = 18, Name = "Восемнадцати" };
        public Transfer Nineteen => new Transfer { Id = 19, Name = "Девятнадцати" };
        #endregion

        #region property Tens
        public Transfer Tens => new Transfer { Id = 21, Name = "Десяти" };
        public Transfer Twenty => new Transfer { Id = 22, Name = "Двадцати" };
        public Transfer Thirty => new Transfer { Id = 23, Name = "Тридцати" };
        public Transfer Forty => new Transfer { Id = 24, Name = "Сорока" };
        public Transfer Fifty => new Transfer { Id = 25, Name = "Пятидесяти" };
        public Transfer Sixty => new Transfer { Id = 26, Name = "Шестидесяти" };
        public Transfer Seventy => new Transfer { Id = 27, Name = "Семидесяти" };
        public Transfer Eighty => new Transfer { Id = 28, Name = "Восемьдесяти" };
        public Transfer Ninety => new Transfer { Id = 29, Name = "Девяноста" };
        #endregion

        #region property Hundreds
        public Transfer OneHundred => new Transfer { Id = 31, Name = "Ста" };
        public Transfer TwoHundred => new Transfer { Id = 32, Name = "Двухстам" };
        public Transfer ThreeHundred => new Transfer { Id = 33, Name = "Трёхстам" };
        public Transfer FourHundred => new Transfer { Id = 34, Name = "Четырёхстам" };
        public Transfer FiveHundred => new Transfer { Id = 35, Name = "Пятистам" };
        public Transfer SixHundred => new Transfer { Id = 36, Name = "Шестистам" };
        public Transfer SevenHundred => new Transfer { Id = 37, Name = "Семистам" };
        public Transfer EightHundred => new Transfer { Id = 38, Name = "Восьмистам" };
        public Transfer NineHundred => new Transfer { Id = 39, Name = "Девятистам" };
        #endregion

        #region property Ending Thousands/Millions/Billions
        public Transfer OneMillion => new Transfer { Id = 44, Name = "Миллиону" };
        public Transfer LessThanFiveMillions => new Transfer { Id = 45, Name = "Миллионам" };
        public Transfer MoreThanFiveMillions => new Transfer { Id = 46, Name = "Миллионам" };

        public Transfer OneBillion => new Transfer { Id = 47, Name = "Миллиарду" };
        public Transfer LessThanFiveBillions => new Transfer { Id = 48, Name = "Миллиардам" };
        public Transfer MoreThanFiveBillions => new Transfer { Id = 49, Name = "Миллиардам" };

        public Transfer Thousands => new Transfer { Id = 50, Name = "Тысяч" };
        public Transfer OneThousand => new Transfer { Id = 51, Name = "Одной Тысяче" };
        public Transfer TwoThousand => new Transfer { Id = 52, Name = "Двум Тысячам" };
        public Transfer ThreeThousand => new Transfer { Id = 53, Name = "Трём Тысячам" };
        public Transfer FourThousand => new Transfer { Id = 54, Name = "Четырём Тысячам" };
        public Transfer FiveThousand => new Transfer { Id = 55, Name = "Пяти Тысячам" };
        public Transfer SixThousand => new Transfer { Id = 56, Name = "Шести Тысячам" };
        public Transfer SevenThousand => new Transfer { Id = 57, Name = "Семи Тысячам" };
        public Transfer EightThousand => new Transfer { Id = 58, Name = "Восьми Тысячам" };
        public Transfer NineThousand => new Transfer { Id = 59, Name = "Девяти Тысячам" };
        #endregion
    }
}
