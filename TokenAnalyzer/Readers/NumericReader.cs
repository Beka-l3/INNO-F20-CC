namespace INNO_F20_CC.TokenAnalyzer
{
    class NumericReader : IReader
    {
        public bool IsTrigger(string source, ref int i) =>
            char.IsDigit(source[i]);

        public bool Read(string source, ref int i, ref string token)
        {
            var c = source[i];
            if (char.IsDigit(c))
            {
                token += c;
                i++;
                return true;
            }
            return false;
        }
    }
}
