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
            number = CheckZeroAndNegativeNumber(number);
            var numberString = number.ToString("#,#", CultureInfo.InvariantCulture);
            var numberSplit = numberString.Split(",");

            switch (numberSplit.Count())
            {
                case 1:
                    FirstLevelConvert(numberSplit[0]);
                    break;
                case 2:
                    SecondLevelConvert(numberSplit);
                    break;
                case 3:
                    ThirdLevelConvert(numberSplit);
                    break;
                case 4:
                    FourthLevelConvert(numberSplit);
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
        public ICases MaleCases(string sCase) => sCase switch
        {
            "И" => Obj = new MNominative(),
            "Р" => Obj = new MGenitive(),
            "Д" => Obj = new MDative(),
            "В" => Obj = new MAccusative(),
            "Т" => Obj = new MInstrumental(),
            "П" => Obj = new MPrepositional(),
            _ => throw new NotImplementedException()
        };

        public ICases FemaleCases(string sCase) => sCase switch
        {
            "И" => Obj = new FNominative(),
            "Р" => Obj = new FGenitive(),
            "Д" => Obj = new FDative(),
            "В" => Obj = new FAccusative(),
            "Т" => Obj = new FInstrumental(),
            "П" => Obj = new FPrepositional(),
            _ => throw new NotImplementedException()
        };

        public ICases NeuterCases(string sCase) => sCase switch
        {
            "И" => Obj = new NNominative(),
            "Р" => Obj = new NGenitive(),
            "Д" => Obj = new NDative(),
            "В" => Obj = new NAccusative(),
            "Т" => Obj = new NInstrumental(),
            "П" => Obj = new NPrepositional(),
            _ => throw new NotImplementedException()
        };

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

        public void FourthLevelConvert(string[] numberSplit)
        {
            FirstLevelConvert(numberSplit[0]);
            EndingBillions(numberSplit[0]);
            FirstLevelConvert(numberSplit[1]);
            if (!numberSplit[1].Equals("000"))
                EndingMillions(numberSplit[1]);
            FirstLevelConvert(numberSplit[2]);
            if (!numberSplit[2].Equals("000"))
                EndingThousands(numberSplit[2]);
            FirstLevelConvert(numberSplit[3]);
        }

        public void ThirdLevelConvert(string[] numberSplit)
        {
            FirstLevelConvert(numberSplit[0]);
            EndingMillions(numberSplit[0]);
            EndingThousands(numberSplit[1]);
            FirstLevelConvert(numberSplit[2]);
        }

        public void SecondLevelConvert(string[] numberSplit)
        {
            EndingThousands(numberSplit[0]);
            FirstLevelConvert(numberSplit[1]);
        }

        public void FirstLevelConvert(string numberString)
        {
            var number = EndingHunders(numberString);
            if (number > 0)
            {
                if (number < 20)
                    Text += $"{Case[number]} ";
                else
                {
                    Text += $"{Case[number / 10 + 20]} ";
                    if ((number % 10) > 0)
                        Text += $"{Case[number % 10]} ";
                }
            }
        }

        public string EndingBillions(string numberString) => numberString.Last() switch
        {
            '1' => Text += $"{Case[47]} ",
            '2' or '3' or '4' => Text += $"{Case[48]} ",
            _ => Text += $"{Case[49]} "
        };

        public string EndingMillions(string numberString) => numberString.Last() switch
        {
            '1' => Text += $"{Case[44]} ",
            '2' or '3' or '4' => Text += $"{Case[45]} ",
            _ => Text += $"{Case[46]} "
        };

        public void EndingThousands(string numberString)
        {
            var number = EndingHunders(numberString);
            if (number <= 0) return;
            switch (number)
            {
                case < 5:
                    Text += $"{Case[number + 50]} ";
                    break;
                case < 20:
                    Text += $"{Case[number] + " " + Case[50]} ";
                    break;
                default:
                    Text += $"{Case[number / 10 + 20]} ";
                    if ((number % 10) > 0)
                        Text += $"{Case[number % 10 + 50]} ";
                    else Text += $"{Case[50]} ";
                    break;
            }
        }

        public int EndingHunders(string numberString)
        {
            var number = int.Parse(numberString);

            if ((number / 100) > 0)
            {
                Text += $"{Case[number / 100 + 30]} ";
                number %= 100;
            }

            return number;
        }

        public long CheckZeroAndNegativeNumber(long number)
        {
            if (number == 0)
                Text = $"{Case[0]}";
            if (number < 0)
                Text = $"Минус ";

            return Math.Abs(number);
        }
    }
}
