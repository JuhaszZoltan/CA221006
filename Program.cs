using System.Drawing;

namespace CA221006
{
    class Ember
    {
        private string _nev;
        private int _eletkor;
        private Point _helyzet;

        public int Eletkor
        {
            get => _eletkor;
            set
            {
                if (value < 0)
                    throw new Exception("az életkor nem lehet negatív");
                if (value > 120)
                    throw new Exception("az életkor túl magas");

                _eletkor = value;
            }
        }

        public string Nev
        {
            get => _nev;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("a név kitöltése kötelező");
                if (value.Length < 3)
                    throw new Exception("a név túl rövid");
                if (!"AÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ".Contains(value[0]))
                    throw new Exception("A nevet nagy betűvel kell kezdeni!");
                if (value.Contains('!'))
                    throw new Exception("a névben nem lehet spec. karakter");

                _nev = value;
            }
        }


        //public void SetEletkor(int eletkor)
        //{
        //    if (eletkor < 0)
        //        throw new Exception("az életkor nem lehet kisebb, mint 0");
        //    if (eletkor > 121)
        //        throw new Exception("ez minimum gyanús életkornak...");
        //    _eletkor = eletkor;
        //}
        //public int GetEletkor()
        //{
        //    return _eletkor;
        //}

        public void Mozog(int x, int y)
        {
            _helyzet = new Point(x, y);
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            Ember e = new()
            {
                Nev = "Zoltán",
                Eletkor = 28,
            };

            Console.WriteLine($"{e.Nev} életkora: {e.Eletkor}");

            //e.SetEletkor(3242352);
            //Console.WriteLine($"emberünk életkora: {e.GetEletkor()}");

        }
    }
}