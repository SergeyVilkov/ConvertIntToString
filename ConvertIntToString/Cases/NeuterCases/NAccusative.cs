namespace ConvertIntToString.Cases.NeuterCases
{
    public class NAccusative : ICases
    {
        #region property Units
        public Transfer Zero => new Transfer { Id = 0, Name = "Ноль" };
        public Transfer One => new Transfer { Id = 1, Name = "Одно" };
        public Transfer Two => new Transfer { Id = 2, Name = "Два" };
        public Transfer Three => new Transfer { Id = 3, Name = "Три" };
        public Transfer Four => new Transfer { Id = 4, Name = "Четыре" };
        public Transfer Five => new Transfer { Id = 5, Name = "Пять" };
        public Transfer Six => new Transfer { Id = 6, Name = "Шесть" };
        public Transfer Seven => new Transfer { Id = 7, Name = "Семь" };
        public Transfer Eight => new Transfer { Id = 8, Name = "Восемь" };
        public Transfer Nine => new Transfer { Id = 9, Name = "Девять" };
        public Transfer Ten => new Transfer { Id = 10, Name = "Десять" };
        public Transfer Eleven => new Transfer { Id = 11, Name = "Одинадцать" };
        public Transfer Twelve => new Transfer { Id = 12, Name = "Двенадцать" };
        public Transfer Thirteen => new Transfer { Id = 13, Name = "Тринадцать" };
        public Transfer Fouteen => new Transfer { Id = 14, Name = "Четырнадцать" };
        public Transfer Fifteen => new Transfer { Id = 15, Name = "Пятнадцать" };
        public Transfer Sixteen => new Transfer { Id = 16, Name = "Шестнадцать" };
        public Transfer Seventeen => new Transfer { Id = 17, Name = "Семнадцать" };
        public Transfer Eightteen => new Transfer { Id = 18, Name = "Восемнадцать" };
        public Transfer Nineteen => new Transfer { Id = 19, Name = "Девятнадцать" };
        #endregion

        #region property Tens
        public Transfer Tens => new Transfer { Id = 21, Name = "Десять" };
        public Transfer Twenty => new Transfer { Id = 22, Name = "Двадцать" };
        public Transfer Thirty => new Transfer { Id = 23, Name = "Тридцать" };
        public Transfer Forty => new Transfer { Id = 24, Name = "Сорок" };
        public Transfer Fifty => new Transfer { Id = 25, Name = "Пятьдесят" };
        public Transfer Sixty => new Transfer { Id = 26, Name = "Шестьдесят" };
        public Transfer Seventy => new Transfer { Id = 27, Name = "Семьдесят" };
        public Transfer Eighty => new Transfer { Id = 28, Name = "Восемьдесят" };
        public Transfer Ninety => new Transfer { Id = 29, Name = "Девяносто" };
        #endregion

        #region property Hundreds
        public Transfer OneHundred => new Transfer { Id = 31, Name = "Сто" };
        public Transfer TwoHundred => new Transfer { Id = 32, Name = "Двести" };
        public Transfer ThreeHundred => new Transfer { Id = 33, Name = "Триста" };
        public Transfer FourHundred => new Transfer { Id = 34, Name = "Четыреста" };
        public Transfer FiveHundred => new Transfer { Id = 35, Name = "Пятьсот" };
        public Transfer SixHundred => new Transfer { Id = 36, Name = "Шестьсот" };
        public Transfer SevenHundred => new Transfer { Id = 37, Name = "Семьсот" };
        public Transfer EightHundred => new Transfer { Id = 38, Name = "Восемьсот" };
        public Transfer NineHundred => new Transfer { Id = 39, Name = "Девятьсот" };
        #endregion

        #region property Ending Thousands/Millions/Billions
        public Transfer OneMillion => new Transfer { Id = 44, Name = "Миллион" };
        public Transfer LessThanFiveMillions => new Transfer { Id = 45, Name = "Миллиона" };
        public Transfer MoreThanFiveMillions => new Transfer { Id = 46, Name = "Миллионов" };

        public Transfer OneBillion => new Transfer { Id = 47, Name = "Миллиард" };
        public Transfer LessThanFiveBillions => new Transfer { Id = 48, Name = "Миллиарда" };
        public Transfer MoreThanFiveBillions => new Transfer { Id = 49, Name = "Миллиардов" };

        public Transfer Thousands => new Transfer { Id = 50, Name = "Тысяч" };
        public Transfer OneThousand => new Transfer { Id = 51, Name = "Одну Тысячу" };
        public Transfer TwoThousand => new Transfer { Id = 52, Name = "Две Тысячи" };
        public Transfer ThreeThousand => new Transfer { Id = 53, Name = "Три Тысячи" };
        public Transfer FourThousand => new Transfer { Id = 54, Name = "Четыре Тысяч" };
        public Transfer FiveThousand => new Transfer { Id = 55, Name = "Пять Тысяч" };
        public Transfer SixThousand => new Transfer { Id = 56, Name = "Шесть Тысяч" };
        public Transfer SevenThousand => new Transfer { Id = 57, Name = "Семь Тысяч" };
        public Transfer EightThousand => new Transfer { Id = 58, Name = "Восемь Тысяч" };
        public Transfer NineThousand => new Transfer { Id = 59, Name = "Девять Тысяч" };
        #endregion
    }
}
