namespace WpfApp2
{
    class Uber
    {
        private int a;
        private int c;

        public Uber(string n, string s, string a, string c)
        {
            N = n;
            S = s;
            A = a;
            C = c;

        }

        public Uber(string n, string s, int a, int c)
        {
            N = n;
            S = s;
            this.a = a;
            this.c = c;
        }

        public string N { get; set; }
        public string S { get; set; }
        public string A { get; set; }
        public string C { get; set; }

    }
}
