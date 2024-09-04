using ConvertIntToString.Cases;
using ConvertIntToString.Cases.FemaleCases;
using ConvertIntToString.Cases.MaleCases;
using ConvertIntToString.Cases.NeuterCases;
using System.Globalization;

namespace ConvertIntToString
{
    public class ConvertData
    {
        public string Text;
        public ICases Obj;
        public Dictionary<int, string> Case;

        public string ConvertToString(long number, string sGender, string sCase)
        {
            CheckDigitCapacityNumber(number);
            CheckForNullOrEmpty(sGender, sCase);
            CheckForCorrectData(sGender, sCase);
            DictionaryInitialization(sGender, sCase);
            var numberString = number.ToString("#,#", CultureInfo.InvariantCulture);
            var numberSplit = numberString.Split(",");

            number = CheckZeroAndNegativeNumber(number, Case);
            switch (numberSplit.Count())
            {
                case 1:
                    FirstLevelConvert(numberSplit[0], Case);
                    break;
                case 2:
                    SecondLevelConvert(numberSplit, Case);
                    break;
                case 3:
                    ThirdLevelConvert(numberSplit, Case);
                    break;
                case 4:
                    FourthLevelConvert(numberSplit, Case);
                    break;
            }

            return Text;
        }

        public void CheckDigitCapacityNumber(long number)
        {
            var maxNumberAllowed = 999999999999;
            if (number > maxNumberAllowed)
                throw new Exception("Допустимо число не более 999,999,999,999");
        }

        public void CheckForNullOrEmpty(string sGender, string sCase)
        {
            if (String.IsNullOrEmpty(sGender))
            {
                throw new Exception("Параметр <Пол> не задан");
            }
            if (String.IsNullOrEmpty(sCase))
            {
                throw new Exception("Параметр <Падеж> не задан");
            }
        }

        public void CheckForCorrectData(string sGender, string sCase)
        {
            string[] cases = { "И", "Р", "Д", "В", "Т", "П" };
            string[] genders = { "М", "С", "Ж" };

            if (!genders.Contains(sGender)) throw new Exception
                ("Введены некорректные входные данные (Параметр <Пол>)");
            if (!cases.Contains(sCase)) throw new Exception
                ("Введены некорректные входные данные (Параметр <Падеж>)");
        }

        #region Setting cases and genders
        public void MaleCases(string sCase)
        {
            switch (sCase)
            {
                case "И":
                    Obj = new MNominative();
                    break;
                case "Р":
                    Obj = new MGenitive();
                    break;
                case "Д":
                    Obj = new MDative();
                    break;
                case "В":
                    Obj = new MAccusative();
                    break;
                case "Т":
                    Obj = new MInstrumental();
                    break;
                case "П":
                    Obj = new MPrepositional();
                    break;
            }
        }

        public void FemaleCases(string sCase)
        {
            switch (sCase)
            {
                case "И":
                    Obj = new FNominative();
                    break;
                case "Р":
                    Obj = new FGenitive();
                    break;
                case "Д":
                    Obj = new FDative();
                    break;
                case "В":
                    Obj = new FAccusative();
                    break;
                case "Т":
                    Obj = new FInstrumental();
                    break;
                case "П":
                    Obj = new FPrepositional();
                    break;
            }
        }

        public void NeuterCases(string sCase)
        {
            switch (sCase)
            {
                case "И":
                    Obj = new NNominative();
                    break;
                case "Р":
                    Obj = new NGenitive();
                    break;
                case "Д":
                    Obj = new NDative();
                    break;
                case "В":
                    Obj = new NAccusative();
                    break;
                case "Т":
                    Obj = new NInstrumental();
                    break;
                case "П":
                    Obj = new NPrepositional();
                    break;
            }
        }

        public void GenderAndCaseSettings(string sGender, string sCase)
        {
            switch (sGender)
            {
                case "М":
                    MaleCases(sCase);
                    break;
                case "Ж":
                    FemaleCases(sCase);
                    break;
                case "С":
                    NeuterCases(sCase);
                    break;
            }
        }
        #endregion

        public void DictionaryInitialization(string sGender, string sCase)
        {
            GenderAndCaseSettings(sGender, sCase);
            Case = new Dictionary<int, string>()
            {
                [Obj.Zero.Id] = Obj.Zero.Name,
                [Obj.One.Id] = Obj.One.Name,
                [Obj.Two.Id] = Obj.Two.Name,
                [Obj.Three.Id] = Obj.Three.Name,
                [Obj.Four.Id] = Obj.Four.Name,
                [Obj.Five.Id] = Obj.Five.Name,
                [Obj.Six.Id] = Obj.Six.Name,
                [Obj.Seven.Id] = Obj.Seven.Name,
                [Obj.Eight.Id] = Obj.Eight.Name,
                [Obj.Nine.Id] = Obj.Nine.Name,
                [Obj.Ten.Id] = Obj.Ten.Name,
                [Obj.Eleven.Id] = Obj.Eleven.Name,
                [Obj.Twelve.Id] = Obj.Twelve.Name,
                [Obj.Thirteen.Id] = Obj.Thirteen.Name,
                [Obj.Fouteen.Id] = Obj.Fouteen.Name,
                [Obj.Fifteen.Id] = Obj.Fifteen.Name,
                [Obj.Sixteen.Id] = Obj.Sixteen.Name,
                [Obj.Seventeen.Id] = Obj.Seventeen.Name,
                [Obj.Eightteen.Id] = Obj.Eightteen.Name,
                [Obj.Nineteen.Id] = Obj.Nineteen.Name,
                //----------------+20---------------------
                [Obj.Tens.Id] = Obj.Tens.Name,
                [Obj.Twenty.Id] = Obj.Twenty.Name,
                [Obj.Thirty.Id] = Obj.Thirty.Name,
                [Obj.Forty.Id] = Obj.Forty.Name,
                [Obj.Fifty.Id] = Obj.Fifty.Name,
                [Obj.Sixty.Id] = Obj.Sixty.Name,
                [Obj.Seventy.Id] = Obj.Seventy.Name,
                [Obj.Eighty.Id] = Obj.Eighty.Name,
                [Obj.Ninety.Id] = Obj.Ninety.Name,
                //----------------+30---------------------
                [Obj.OneHundred.Id] = Obj.OneHundred.Name,
                [Obj.TwoHundred.Id] = Obj.TwoHundred.Name,
                [Obj.ThreeHundred.Id] = Obj.ThreeHundred.Name,
                [Obj.FourHundred.Id] = Obj.FourHundred.Name,
                [Obj.FiveHundred.Id] = Obj.FiveHundred.Name,
                [Obj.SixHundred.Id] = Obj.SixHundred.Name,
                [Obj.SevenHundred.Id] = Obj.SevenHundred.Name,
                [Obj.EightHundred.Id] = Obj.EightHundred.Name,
                [Obj.NineHundred.Id] = Obj.NineHundred.Name,
                //----------------+40---------------------
                [Obj.OneMillion.Id] = Obj.OneMillion.Name,
                [Obj.LessThanFiveMillions.Id] = Obj.LessThanFiveMillions.Name,
                [Obj.MoreThanFiveMillions.Id] = Obj.MoreThanFiveMillions.Name,
                [Obj.OneBillion.Id] = Obj.OneBillion.Name,
                [Obj.LessThanFiveBillions.Id] = Obj.LessThanFiveBillions.Name,
                [Obj.MoreThanFiveBillions.Id] = Obj.MoreThanFiveBillions.Name,
                //----------------+50---------------------
                [Obj.Thousands.Id] = Obj.Thousands.Name,
                [Obj.OneThousand.Id] = Obj.OneThousand.Name,
                [Obj.TwoThousand.Id] = Obj.TwoThousand.Name,
                [Obj.ThreeThousand.Id] = Obj.ThreeThousand.Name,
                [Obj.FourThousand.Id] = Obj.FourThousand.Name,
                [Obj.FiveThousand.Id] = Obj.FiveThousand.Name,
                [Obj.SixThousand.Id] = Obj.SixThousand.Name,
                [Obj.SevenThousand.Id] = Obj.SevenThousand.Name,
                [Obj.EightThousand.Id] = Obj.EightThousand.Name,
                [Obj.NineThousand.Id] = Obj.NineThousand.Name,
            };
        }

        public void FourthLevelConvert(string[] numberSplit, Dictionary<int, string> sCase)
        {
            FirstLevelConvert(numberSplit[0], sCase);
            EndingBillions(numberSplit[0], sCase);
            FirstLevelConvert(numberSplit[1], sCase);
            if (!numberSplit[1].Equals("000"))
            {
                EndingMillions(numberSplit[1], sCase);
            }
            FirstLevelConvert(numberSplit[2], sCase);
            if (!numberSplit[2].Equals("000"))
            {
                EndingThousands(numberSplit[2], sCase);
            }
            FirstLevelConvert(numberSplit[3], sCase);
        }

        public void ThirdLevelConvert(string[] numberSplit, Dictionary<int, string> sCase)
        {
            FirstLevelConvert(numberSplit[0], sCase);
            EndingMillions(numberSplit[0], sCase);
            EndingThousands(numberSplit[1], sCase);
            FirstLevelConvert(numberSplit[2], sCase);
        }

        public void SecondLevelConvert(string[] numberSplit, Dictionary<int, string> sCase)
        {
            EndingThousands(numberSplit[0], sCase);
            FirstLevelConvert(numberSplit[1], sCase);
        }

        public void FirstLevelConvert(string numberString, Dictionary<int, string> sCase)
        {
            var number = EndingHunders(numberString, sCase);
            if (number > 0)
            {
                if (number < 20)
                    Text += $"{sCase[number]} ";
                else
                {
                    Text += $"{sCase[number / 10 + 20]} ";
                    if ((number % 10) > 0)
                        Text += $"{sCase[number % 10]} ";
                }
            }
        }

        public void EndingBillions(string text, Dictionary<int, string> sCase)
        {
            var number = int.Parse(text.Last().ToString());
            switch (number)
            {
                case 1:
                    Text += $"{sCase[47]} ";
                    break;
                case 2:
                case 3:
                case 4:
                    Text += $"{sCase[48]} ";
                    break;
                default:
                    Text += $"{sCase[49]} ";
                    break;
            }
        }

        public void EndingMillions(string text, Dictionary<int, string> sCase)
        {
            var number = int.Parse(text.Last().ToString());
            switch (number)
            {
                case 1:
                    Text += $"{sCase[44]} ";
                    break;
                case 2:
                case 3:
                case 4:
                    Text += $"{sCase[45]} ";
                    break;
                default:
                    Text += $"{sCase[46]} ";
                    break;
            }
        }

        public void EndingThousands(string numberString, Dictionary<int, string> sCase)
        {
            var number = EndingHunders(numberString, sCase);
            if (number > 0)
            {
                switch (number)
                {
                    case < 5:
                        Text += $"{sCase[number + 50]} ";
                        break;
                    case < 20:
                        Text += $"{sCase[number] + " " + sCase[50]} ";
                        break;
                    default:
                        Text += $"{sCase[number / 10 + 20]} ";
                        if ((number % 10) > 0)
                            Text += $"{sCase[number % 10 + 50]} ";
                        else Text += $"{sCase[50]} ";
                        break;
                }
            }
        }

        public int EndingHunders(string numberString, Dictionary<int, string> sCase)
        {
            var number = int.Parse(numberString);

            if ((number / 100) > 0)
            {
                Text += $"{sCase[number / 100 + 30]} ";
                number %= 100;
            }

            return number;
        }

        public long CheckZeroAndNegativeNumber(long number, Dictionary<int, string> sCase)
        {
            if (number == 0)
                Text = $"{sCase[0]}";
            if (number < 0)
                Text = $"Минус ";

            return Math.Abs(number);
        }
    }
}
