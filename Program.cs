namespace GroupWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlemlere başlayabilirsiniz.");

            Shape shape;

            #region dikdortgen
            shape = new dikdortgen();
            shape.draw();
            shape.alanHesapla();
            shape.cevreHesapla();
            #endregion

            #region Triangle
            shape = new triangle();
            shape.draw();
            shape.alanHesapla();
            shape.cevreHesapla();
            #endregion
        }
    }
}