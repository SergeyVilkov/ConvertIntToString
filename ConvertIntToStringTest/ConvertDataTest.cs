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
            data.DictionaryInitialization("�", "�");

            data.CheckZeroAndNegativeNumber(0);

            Assert.That(data.Text, Is.EqualTo("����"));
        }

        [Test]
        public void CheckZeroAndNegativeNumber_NegativeNumber_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.CheckZeroAndNegativeNumber(-1);

            Assert.That(data.Text, Is.EqualTo("����� "));
        }

        [Test]
        public void EndingThousands_OneThousand_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingThousands("1");

            Assert.That(data.Text, Is.EqualTo("���� ������ "));
        }

        [Test]
        public void EndingThousands_TwoThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingThousands("2");

            Assert.That(data.Text, Is.EqualTo("��� ������ "));
        }

        [Test]
        public void EndingThousands_FiveThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingThousands("5");

            Assert.That(data.Text, Is.EqualTo("���� ����� "));
        }

        [Test]
        public void EndingThousands_MoreFiveThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingThousands("17");

            Assert.That(data.Text, Is.EqualTo("���������� ����� "));
        }

        [Test]
        public void EndingThousands_MoreTwentyThousands_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingThousands("30");

            Assert.That(data.Text, Is.EqualTo("�������� ����� "));
        }

        [Test]
        public void EndingMillions_OneMillion_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingMillions("1");

            Assert.That(data.Text, Is.EqualTo("������� "));
        }

        [Test]
        public void EndingMillions_TwoMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingMillions("2");

            Assert.That(data.Text, Is.EqualTo("�������� "));
        }

        [Test]
        public void EndingMillions_FiveMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingMillions("5");

            Assert.That(data.Text, Is.EqualTo("��������� "));
        }

        [Test]
        public void EndingBillions_OneBillion_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingBillions("1");

            Assert.That(data.Text, Is.EqualTo("�������� "));
        }

        [Test]
        public void EndingBillions_TwoMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingBillions("2");

            Assert.That(data.Text, Is.EqualTo("��������� "));
        }

        [Test]
        public void EndingBillions_FiveMillions_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.EndingBillions("5");

            Assert.That(data.Text, Is.EqualTo("���������� "));
        }

        [Test]
        public void FirstLevelConvert_Hundreds_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.FirstLevelConvert("300");

            Assert.That(data.Text, Is.EqualTo("������ "));
        }

        [Test]
        public void FirstLevelConvert_TensLessTwenty_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.FirstLevelConvert("17");

            Assert.That(data.Text, Is.EqualTo("���������� "));
        }

        [Test]
        public void FirstLevelConvert_TensMoreTwenty_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.FirstLevelConvert("40");

            Assert.That(data.Text, Is.EqualTo("����� "));
        }

        [Test]
        public void FirstLevelConvert_Units_ReturnsToString()
        {
            var data = new ConvertData();
            data.DictionaryInitialization("�", "�");

            data.FirstLevelConvert("2");

            Assert.That(data.Text, Is.EqualTo("��� "));
        }

        [Test]
        public void SecondLevelConvert_Thousands_ReturnsToString()
        {
            var data = new ConvertData();
            var numberSplit = new string[] { "242", "000" };
            data.DictionaryInitialization("�", "�");

            data.SecondLevelConvert(numberSplit);

            Assert.That(data.Text, Is.EqualTo("������ ����� ��� ������ "));
        }

        [Test]
        public void ThirdLevelConvert_Thousands_ReturnsToString()
        {
            var data = new ConvertData();
            var numberSplit = new string[] { "242", "000", "000" };
            data.DictionaryInitialization("�", "�");

            data.ThirdLevelConvert(numberSplit);

            Assert.That(data.Text, Is.EqualTo("������ ����� ��� �������� "));
        }

        [Test]
        public void FourthLevelConvert_Thousands_ReturnsToString()
        {
            var data = new ConvertData();
            var numberSplit = new string[] { "241", "000", "000", "000" };
            data.DictionaryInitialization("�", "�");

            data.FourthLevelConvert(numberSplit);

            Assert.That(data.Text, Is.EqualTo("������ ����� ���� �������� "));
        }

        [Test]
        public void EndingHunders_NumberMoreOneHunders_ReturnsTensNumber()
        {
            var data = new ConvertData();
            var numberString = "734";
            data.DictionaryInitialization("�", "�");

            var result = data.EndingHunders(numberString);

            Assert.That(result == 34);
        }

        [Test]
        public void EndingHunders_NumberLessOneHunders_ReturnsTensNumber()
        {
            var data = new ConvertData();
            var numberString = "34";
            data.DictionaryInitialization("�", "�");

            var result = data.EndingHunders(numberString);

            Assert.That(result == 34);
        }

        [Test]
        public void EndingHunders_NumberMoreOneHunders_ReturnsToString()
        {
            var data = new ConvertData();
            var numberString = "734";
            data.DictionaryInitialization("�", "�");

            data.EndingHunders(numberString);

            Assert.That(data.Text, Is.EqualTo("������� "));
        }

        [Test]
        public void GenderAndCaseSettings_Male_ReturnsNumberInMaleCases()
        {
            var data = new ConvertData();

            data.ConvertToString(1, "�", "�");

            Assert.That(data.Text, Is.EqualTo("���� "));
        }

        [Test]
        public void GenderAndCaseSettings_Female_ReturnsNumberInFemaleCases()
        {
            var data = new ConvertData();

            data.ConvertToString(1, "�", "�");

            Assert.That(data.Text, Is.EqualTo("���� "));
        }

        [Test]
        public void GenderAndCaseSettings_Neuter_ReturnsNumberInNeuterCases()
        {
            var data = new ConvertData();

            data.ConvertToString(1, "�", "�");

            Assert.That(data.Text, Is.EqualTo("���� "));
        }

        [Test]
        public void CheckForNullOrEmpty_EmptyGender_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() => data.CheckForNullOrEmpty("", "�"));

            StringAssert.Contains("�������� <���> �� �����", ex.Message);
        }

        [Test]
        public void CheckForNullOrEmpty_EmptyCase_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() => data.CheckForNullOrEmpty("�", ""));

            StringAssert.Contains("�������� <�����> �� �����", ex.Message);
        }

        [Test]
        public void CheckForNullOrEmpty_Empty_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() => data.CheckForNullOrEmpty("", "�"));

            StringAssert.Contains("�������� <���> �� �����", ex.Message);
        }

        [Test]
        public void CheckForCorrectData_IncorrectGender_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() =>
                data.CheckForCorrectData("�������� ���", "�"));

            StringAssert.Contains
                ("������� ������������ ������� ������ (�������� <���>)", ex.Message);
        }

        [Test]
        public void CheckForCorrectData_IncorrectCase_Throw()
        {
            var data = new ConvertData();

            var ex = Assert.Catch<Exception>(() =>
                data.CheckForCorrectData("�", "�������� �����"));

            StringAssert.Contains
                ("������� ������������ ������� ������ (�������� <�����>)", ex.Message);
        }

        [Test]
        public void CheckDigitCapacityNumber_NumberMoreOneTrillion_Throw()
        {
            var data = new ConvertData();
            var oneTrillion = 1000000000000;

            var ex = Assert.Catch<Exception>(() => data
                .CheckDigitCapacityNumber(oneTrillion));

            StringAssert.Contains("��������� ����� �� ����� 999,999,999,999", ex.Message);
        }
    }
}