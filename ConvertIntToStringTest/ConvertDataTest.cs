using ConvertIntToString;
using NUnit.Framework.Legacy;

namespace ConvertIntToStringTest
{
    [TestFixture]
    public class ConvertDataTest
    {
        [Test]
        public void CheckZeroAndNegativeNumber_Zero_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.CheckZeroAndNegativeNumber(0);

            Assert.That(data.Text, Is.EqualTo("Ноль"));
        }

        [Test]
        public void CheckZeroAndNegativeNumber_NegativeNumber_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.CheckZeroAndNegativeNumber(-1);

            Assert.That(data.Text, Is.EqualTo("Минус "));
        }

        [Test]
        public void EndingThousands_OneThousand_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingThousands("1");

            Assert.That(data.Text, Is.EqualTo("Одна Тысяча "));
        }

        [Test]
        public void EndingThousands_TwoThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingThousands("2");

            Assert.That(data.Text, Is.EqualTo("Две Тысячи "));
        }

        [Test]
        public void EndingThousands_FiveThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingThousands("5");

            Assert.That(data.Text, Is.EqualTo("Пять Тысяч "));
        }

        [Test]
        public void EndingThousands_MoreFiveThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingThousands("17");

            Assert.That(data.Text, Is.EqualTo("Семнадцать Тысяч "));
        }

        [Test]
        public void EndingThousands_MoreTwentyThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingThousands("30");

            Assert.That(data.Text, Is.EqualTo("Тридцать Тысяч "));
        }

        [Test]
        public void EndingMillions_OneMillion_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingMillions("1");

            Assert.That(data.Text, Is.EqualTo("Миллион "));
        }

        [Test]
        public void EndingMillions_TwoMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingMillions("2");

            Assert.That(data.Text, Is.EqualTo("Миллиона "));
        }

        [Test]
        public void EndingMillions_FiveMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingMillions("5");

            Assert.That(data.Text, Is.EqualTo("Миллионов "));
        }

        [Test]
        public void EndingBillions_OneBillion_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingBillions("1");

            Assert.That(data.Text, Is.EqualTo("Миллиард "));
        }

        [Test]
        public void EndingBillions_TwoMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingBillions("2");

            Assert.That(data.Text, Is.EqualTo("Миллиарда "));
        }

        [Test]
        public void EndingBillions_FiveMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.EndingBillions("5");

            Assert.That(data.Text, Is.EqualTo("Миллиардов "));
        }

        [Test]
        public void FirstLevelConvert_Hundreds_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.FirstLevelConvert("300");

            Assert.That(data.Text, Is.EqualTo("Триста "));
        }

        [Test]
        public void FirstLevelConvert_TensLessTwenty_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.FirstLevelConvert("17");

            Assert.That(data.Text, Is.EqualTo("Семнадцать "));
        }

        [Test]
        public void FirstLevelConvert_TensMoreTwenty_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.FirstLevelConvert("40");

            Assert.That(data.Text, Is.EqualTo("Сорок "));
        }

        [Test]
        public void FirstLevelConvert_Units_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("М", "И");

            data.FirstLevelConvert("2");

            Assert.That(data.Text, Is.EqualTo("Два "));
        }

        [Test]
        public void SecondLevelConvert_Thousands_ReturnsToString()
        {
            var data = new ConvertData();
            var numberSplit = new string[] { "242", "000" };
            data.DictionaryInitialization("М", "И");

            data.SecondLevelConvert(numberSplit);

            Assert.That(data.Text, Is.EqualTo("Двести Сорок Две Тысячи "));
        }

        [Test]
        public void ThirdLevelConvert_Thousands_ReturnsToString()
        {
            var data = new ConvertData();
            var numberSplit = new string[] { "242", "000", "000" };
            data.DictionaryInitialization("М", "И");

            data.ThirdLevelConvert(numberSplit);

            Assert.That(data.Text, Is.EqualTo("Двести Сорок Два Миллиона "));
        }

        [Test]
        public void FourthLevelConvert_Thousands_ReturnsToString()
        {
            var data = new ConvertData();
            var numberSplit = new string[] { "241", "000", "000", "000" };
            data.DictionaryInitialization("М", "И");

            data.FourthLevelConvert(numberSplit);

            Assert.That(data.Text, Is.EqualTo("Двести Сорок Один Миллиард "));
        }

        [Test]
        public void EndingHunders_NumberMoreOneHunders_ReturnsTensNumber()
        {
            var data = new ConvertData();
            var numberString = "734";
            data.DictionaryInitialization("М", "И");

            var result = data.EndingHunders(numberString);

            Assert.That(result == 34);
        }

        [Test]
        public void EndingHunders_NumberLessOneHunders_ReturnsTensNumber()
        {
            var data = new ConvertData();
            var numberString = "34";
            data.DictionaryInitialization("М", "И");

            var result = data.EndingHunders(numberString);

            Assert.That(result == 34);
        }

        [Test]
        public void EndingHunders_NumberMoreOneHunders_ReturnsToString()
        {
            var data = new ConvertData();
            var numberString = "734";
            data.DictionaryInitialization("М", "И");

            data.EndingHunders(numberString);

            Assert.That(data.Text, Is.EqualTo("Семьсот "));
        }

        [Test]
        public void GenderAndCaseSettings_Male_ReturnsNumberInMaleCases()
        {
            var data = new ConvertData();

            data.ConvertToString(1, "М", "И");

            Assert.That(data.Text, Is.EqualTo("Один "));
        }

        [Test]
        public void GenderAndCaseSettings_Female_ReturnsNumberInFemaleCases()
        {
            var data = new ConvertData();

            data.ConvertToString(1, "Ж", "И");

            Assert.That(data.Text, Is.EqualTo("Одна "));
        }

        [Test]
        public void GenderAndCaseSettings_Neuter_ReturnsNumberInNeuterCases()
        {
            var data = new ConvertData();

            data.ConvertToString(1, "С", "И");

            Assert.That(data.Text, Is.EqualTo("Одно "));
        }

        [Test]
        public void CheckForNullOrEmpty_EmptyGender_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() => data.CheckForNullOrEmpty("", "И"));

            StringAssert.Contains("Параметр <Пол> не задан", ex.Message);
        }

        [Test]
        public void CheckForNullOrEmpty_EmptyCase_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() => data.CheckForNullOrEmpty("М", ""));

            StringAssert.Contains("Параметр <Падеж> не задан", ex.Message);
        }

        [Test]
        public void CheckForNullOrEmpty_Empty_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() => data.CheckForNullOrEmpty("", "И"));

            StringAssert.Contains("Параметр <Пол> не задан", ex.Message);
        }

        [Test]
        public void CheckForCorrectData_IncorrectGender_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() =>
                data.CheckForCorrectData("Неверный пол", "И"));

            StringAssert.Contains
                ("Введены некорректные входные данные (Параметр <Пол>)", ex.Message);
        }

        [Test]
        public void CheckForCorrectData_IncorrectCase_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() =>
                data.CheckForCorrectData("М", "Неверный падеж"));

            StringAssert.Contains
                ("Введены некорректные входные данные (Параметр <Падеж>)", ex.Message);
        }

        [Test]
        public void CheckDigitCapacityNumber_NumberMoreOneTrillion_Throw()
        {
            var data = new ConvertData();
            var oneTrillion = 1000000000000;

            var ex = Assert.Catch<Exception>(() => data
                .CheckDigitCapacityNumber(oneTrillion));

            StringAssert.Contains("Допустимо число не более 999,999,999,999", ex.Message);
        }
    }
}