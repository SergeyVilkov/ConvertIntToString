﻿namespace ConvertIntToString.Cases.MaleCases
{
    public class MInstrumental : ICases
    {
        #region property Units
        public Transfer Zero => new Transfer { Id = 0, Name = "Нолём" };
        public Transfer One => new Transfer { Id = 1, Name = "Одним" };
        public Transfer Two => new Transfer { Id = 2, Name = "Двумя" };
        public Transfer Three => new Transfer { Id = 3, Name = "Тремя" };
        public Transfer Four => new Transfer { Id = 4, Name = "Четырьмя" };
        public Transfer Five => new Transfer { Id = 5, Name = "Пятью" };
        public Transfer Six => new Transfer { Id = 6, Name = "Шестью" };
        public Transfer Seven => new Transfer { Id = 7, Name = "Семью" };
        public Transfer Eight => new Transfer { Id = 8, Name = "Восемью" };
        public Transfer Nine => new Transfer { Id = 9, Name = "Девятью" };
        public Transfer Ten => new Transfer { Id = 10, Name = "Десятью" };
        public Transfer Eleven => new Transfer { Id = 11, Name = "Одинадцатью" };
        public Transfer Twelve => new Transfer { Id = 12, Name = "Двенадцатью" };
        public Transfer Thirteen => new Transfer { Id = 13, Name = "Тринадцатью" };
        public Transfer Fouteen => new Transfer { Id = 14, Name = "Четырнадцатью" };
        public Transfer Fifteen => new Transfer { Id = 15, Name = "Пятнадцатью" };
        public Transfer Sixteen => new Transfer { Id = 16, Name = "Шестнадцатью" };
        public Transfer Seventeen => new Transfer { Id = 17, Name = "Семнадцатью" };
        public Transfer Eightteen => new Transfer { Id = 18, Name = "Восемнадцатью" };
        public Transfer Nineteen => new Transfer { Id = 19, Name = "Девятнадцатью" };
        #endregion

        #region property Tens
        public Transfer Tens => new Transfer { Id = 21, Name = "Десятью" };
        public Transfer Twenty => new Transfer { Id = 22, Name = "Двадцатью" };
        public Transfer Thirty => new Transfer { Id = 23, Name = "Тридцатью" };
        public Transfer Forty => new Transfer { Id = 24, Name = "Сорока" };
        public Transfer Fifty => new Transfer { Id = 25, Name = "Пятьюдесятью" };
        public Transfer Sixty => new Transfer { Id = 26, Name = "Шестидесятью" };
        public Transfer Seventy => new Transfer { Id = 27, Name = "Семидесятью" };
        public Transfer Eighty => new Transfer { Id = 28, Name = "Восьмидесятью" };
        public Transfer Ninety => new Transfer { Id = 29, Name = "Девяноста" };
        #endregion

        #region property Hundreds
        public Transfer OneHundred => new Transfer { Id = 31, Name = "Ста" };
        public Transfer TwoHundred => new Transfer { Id = 32, Name = "Двумястами" };
        public Transfer ThreeHundred => new Transfer { Id = 33, Name = "Тремястами" };
        public Transfer FourHundred => new Transfer { Id = 34, Name = "Четырьмястами" };
        public Transfer FiveHundred => new Transfer { Id = 35, Name = "Пятьюстами" };
        public Transfer SixHundred => new Transfer { Id = 36, Name = "Шестьюстами" };
        public Transfer SevenHundred => new Transfer { Id = 37, Name = "Семьюстами" };
        public Transfer EightHundred => new Transfer { Id = 38, Name = "Восемьюстами" };
        public Transfer NineHundred => new Transfer { Id = 39, Name = "Девятьюстами" };
        #endregion

        #region property Ending Thousands/Millions/Billions
        public Transfer OneMillion => new Transfer { Id = 44, Name = "Миллионом" };
        public Transfer LessThanFiveMillions => new Transfer { Id = 45, Name = "Миллионами" };
        public Transfer MoreThanFiveMillions => new Transfer { Id = 46, Name = "Миллионами" };

        public Transfer OneBillion => new Transfer { Id = 47, Name = "Миллиардом" };
        public Transfer LessThanFiveBillions => new Transfer { Id = 48, Name = "Миллиардами" };
        public Transfer MoreThanFiveBillions => new Transfer { Id = 49, Name = "Миллиардами" };

        public Transfer Thousands => new Transfer { Id = 50, Name = "Тысячами" };
        public Transfer OneThousand => new Transfer { Id = 51, Name = "Одной Тысячей" };
        public Transfer TwoThousand => new Transfer { Id = 52, Name = "Двумя Тысячами" };
        public Transfer ThreeThousand => new Transfer { Id = 53, Name = "Тремя Тысячами" };
        public Transfer FourThousand => new Transfer { Id = 54, Name = "Четырьмя Тысячами" };
        public Transfer FiveThousand => new Transfer { Id = 55, Name = "Пятью Тысячами" };
        public Transfer SixThousand => new Transfer { Id = 56, Name = "Шестью Тысячами" };
        public Transfer SevenThousand => new Transfer { Id = 57, Name = "Семью Тысячами" };
        public Transfer EightThousand => new Transfer { Id = 58, Name = "Восьмью Тысячами" };
        public Transfer NineThousand => new Transfer { Id = 59, Name = "Девятью Тысячами" };
        #endregion
    }
}
